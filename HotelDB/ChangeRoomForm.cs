using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Text;

namespace DBHotel
{
    public partial class ChangeRoomForm : Form
    {
        private int number;
        private int roomsNumber;
        private int sleepingPlace;
        private int floorNumber;
        private string? className;
        private double price;
        private bool tV;
        private bool fridge;

        private DatabaseConnector connector = new();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public ChangeRoomForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(GenerateFindSQL(), connector.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                FillParameters();
                DisplayParameters();
            }
        }

        private void DisplayParameters()
        {
            RoomNumbers.Text = roomsNumber.ToString();
            SleepingPlaces.Text = sleepingPlace.ToString();
            ClassBox.Text = className;
            CostBox.Text = price.ToString();
            TV.Checked = tV;
            Fridge.Checked = fridge;
        }

        private void FillParameters()
        {
            DataRow row = table.Rows[0];

            int.TryParse(row["ID"].ToString(), out number);
            int.TryParse(row["Rooms"].ToString(), out roomsNumber);
            int.TryParse(row["SleepingPlace"].ToString(), out sleepingPlace);
            int.TryParse(row["Floor"].ToString(), out floorNumber);
            className = row["Class"].ToString();
            double.TryParse(row["Price"].ToString(), out price);
            int.TryParse(row["TV"].ToString(), out int result);
            tV = Convert.ToBoolean(result);
            int.TryParse(row["Fridge"].ToString(), out result);
            fridge = Convert.ToBoolean(result);
        }

        private string GenerateFindSQL()
        {
            string request = string.Empty;

            request += $"SELECT * FROM room WHERE ID = {NumberText.Text}";

            return request;
        }

        private string GenerateDeleteSQL()
        {
            string request = string.Empty;

            request += $"DELETE FROM room WHERE ID = {number}";

            return request;
        }

        private string GenerateChangeSQL()
        {
            string request = string.Empty;

            if (RoomNumbers.Text != roomsNumber.ToString())
                request += $"UPDATE room SET Rooms = {roomsNumber} WHERE ID = {number};\n";
            if (SleepingPlaces.Text != sleepingPlace.ToString())
                request += $"UPDATE room SET SleepingPlace = {SleepingPlaces.Text} WHERE ID = {number};\n";
            if (ClassBox.Text != className)
                request += $"UPDATE room SET Class = {GetClass()} WHERE ID = {number};\n";
            if (CostBox.Text != price.ToString())
                request += $"UPDATE room SET Price = {CostBox.Text} WHERE ID = {number};\n";
            if (TV.Checked == tV)
            {
                int i = TV.Checked ? 1 : 0;
                request += $"UPDATE room SET TV = {i} WHERE ID = {number};\n";
            }
            if (Fridge.Checked == fridge)
            {
                int i = Fridge.Checked ? 1 : 0;
                request += $"UPDATE room SET Fridge = {i} WHERE ID = {number};\n";
            }

            return request;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(GenerateDeleteSQL(), connector.GetConnection());

            connector.OpenConnection();
            cmd.ExecuteNonQuery();

            var resetAutoIncrementalCommand = new MySqlCommand("ALTER TABLE room AUTO_INCREMENT = 1", connector.GetConnection());
            resetAutoIncrementalCommand.ExecuteNonQuery();
            connector.CloseConnection();
        }

        private int GetClass()
        {
            int roomClass = ClassCheck();

            if (roomClass == -1)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO class (Name) VALUES (@name)", connector.GetConnection());
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = ClassBox.Text;

                connector.OpenConnection();

                cmd.ExecuteNonQuery();

                connector.CloseConnection();

                roomClass = ClassCheck();
            }

            return roomClass;
        }

        private int ClassCheck()
        {
            DataTable classTable = new DataTable();
            MySqlCommand getRoomsClasses = new MySqlCommand("SELECT * FROM class WHERE Name = @class", connector.GetConnection());
            getRoomsClasses.Parameters.Add("@class", MySqlDbType.VarChar).Value = ClassBox.Text;

            adapter.SelectCommand = getRoomsClasses;
            classTable = new DataTable();
            adapter.Fill(classTable);

            if (classTable.Rows.Count > 0)
            {
                var id = classTable.Rows[0]["ID"];
                int.TryParse(id.ToString(), out int result);
                return id == null ? -1 : result;
            }
            else
            {
                return -1;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(GenerateChangeSQL(), connector.GetConnection());

            connector.OpenConnection();
            cmd.ExecuteNonQuery();
            connector.CloseConnection();
        }
    }
}
