using MySql.Data.MySqlClient;
using System.Data;

namespace DBHotel
{
    public partial class AddRoomForm : Form
    {
        private DatabaseConnector connector = new();
        private DataTable classTable = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                MySqlCommand cmd = new MySqlCommand(GenerateSql(), connector.GetConnection());
                cmd.Parameters.Add("@rooms", MySqlDbType.Int32).Value = int.Parse(RoomNumber.Text);
                cmd.Parameters.Add("@sleepingPlace", MySqlDbType.Int32).Value = int.Parse(SleepingPlaces.Text);
                cmd.Parameters.Add("@floor", MySqlDbType.Int32).Value = int.Parse(FloorNumber.Text);
                cmd.Parameters.Add("@TV", MySqlDbType.UByte).Value = TVCheckbox.Checked;
                cmd.Parameters.Add("@fridge", MySqlDbType.UByte).Value = FridgeCheckbox.Checked;
                cmd.Parameters.Add("@class", MySqlDbType.Int32).Value = GetClass();
                cmd.Parameters.Add("@price", MySqlDbType.Double).Value = Price.Text;

                connector.OpenConnection();

                cmd.ExecuteNonQuery();

                connector.CloseConnection();

                ClearInput();
            }
        }

        private void ClearInput()
        {
            RoomNumber.Text = string.Empty;
            SleepingPlaces.Text = string.Empty;
            FloorNumber.Text = string.Empty;
            Class.Text = string.Empty;
            Price.Text = string.Empty;
            TVCheckbox.Checked = false;
            FridgeCheckbox.Checked = false;
        }

        private string GenerateSql()
        {
            string request = string.Empty;
            request += $"INSERT INTO room (Rooms, SleepingPlace, Floor, TV, Fridge, Class, Price)";
            request += " VALUES (@rooms, @sleepingPlace, @floor, @TV, @fridge, @class, @price)";

            return request;
        }

        private bool CheckInputData()
        {
            if (!RoomNumberCheck() ||
                !SleepingPlacesCheck() ||
                !FloorNumberCheck() ||
                !PriceCheck())
                return false;
            return true;
        }

        private int GetClass()
        {
            int roomClass = ClassCheck();

            if (roomClass == -1)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO class (Name) VALUES (@name)", connector.GetConnection());
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Class.Text;

                connector.OpenConnection();

                cmd.ExecuteNonQuery();

                connector.CloseConnection();

                roomClass = ClassCheck();
            }

            return roomClass;
        }

        #region InputCheck
        private bool RoomNumberCheck()
        {
            return AboveZeroCheck(RoomNumber.Text);
        }

        private bool SleepingPlacesCheck()
        {
            return AboveZeroCheck(SleepingPlaces.Text);
        }

        private bool FloorNumberCheck()
        {
            return AboveZeroCheck(FloorNumber.Text);
        }

        private int ClassCheck()
        {
            MySqlCommand getRoomsClasses = new MySqlCommand("SELECT * FROM class WHERE Name = @class", connector.GetConnection());
            getRoomsClasses.Parameters.Add("@class", MySqlDbType.VarChar).Value = Class.Text;

            adapter.SelectCommand = getRoomsClasses;
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

        private bool PriceCheck()
        {
            return AboveZeroCheck(Price.Text);
        }

        private bool AboveZeroCheck(string text)
        {
            int number;

            try
            {
                number = int.Parse(text);
            }
            catch (Exception)
            {
                return false;
            }

            if (number <= 0)
                return false;

            return true;
        }
        #endregion
    }
}
