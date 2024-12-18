using HotelDB;
using MySql.Data.MySqlClient;
using System.Data;

namespace DBHotel
{
    public partial class MainForm : Form
    {
        private DatabaseConnector connector = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand(GenerateSQL(), connector.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private string GenerateSQL()
        {
            string request = string.Empty;

            request += "SELECT * FROM room WHERE ";

            if (RoomNumbers.Text != string.Empty && AboveZeroCheck(RoomNumbers.Text))
                request += $"Rooms = {RoomNumbers.Text} AND ";
            if (SleepingPlaces.Text != string.Empty && AboveZeroCheck(SleepingPlaces.Text))
                request += $"SleepingPlace = {SleepingPlaces.Text} AND ";
            if (ClassBox.Text != string.Empty)
                request += $"Class = {ClassBox.Text} AND ";
            if (CostBox.Text != string.Empty && AboveZeroCheck(CostBox.Text))
                request += $"Price <= {CostBox.Text} AND ";
            if (TVCheckbox.Checked == true)
                request += $"TV = 1 AND ";
            if (FridgeCheckbox.Checked == true)
                request += $"Fridge = 1 AND ";
            if (OccupiedCheckbox.Checked == true)
                request += "NOT EXIST (SELECT 1 FROM receipt WHERE receipt.Room = room.ID)";

            string last4Chars = request.Substring(request.Length - 4);

            if (last4Chars == "AND ")
                request = request.Substring(0, request.Length - 5);
            else if (last4Chars == "ERE ")
                request = request.Substring(0, request.Length - 7);

            return request;
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

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            var newform = new AddRoomForm();
            newform.ShowDialog();
        }

        private void EditRoomButton_Click(object sender, EventArgs e)
        {
            var newform = new ChangeRoomForm();
            newform.ShowDialog();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var newform = new AddCustomer();
            newform.ShowDialog();
        }
    }
}
