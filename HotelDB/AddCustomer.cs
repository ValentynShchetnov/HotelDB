using DBHotel;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelDB
{
    public partial class AddCustomer : Form
    {
        private DatabaseConnector connector = new();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(GenerateAddingSQL(), connector.GetConnection());

            cmd.Parameters.Add("@PhoneNumber", MySqlDbType.Int32).Value = int.Parse(PhoneNumberBox.Text);
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailBox.Text;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = FirstNameBox.Text;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = LastNameBox.Text;
            cmd.Parameters.Add("@Room", MySqlDbType.Int32).Value = int.Parse(RoomIDBox.Text);
            cmd.Parameters.Add("@ArrivalDate", MySqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@DepartureDate", MySqlDbType.Date).Value = DateTime.Now.AddDays(double.Parse(DaysBox.Text)).Date;

            connector.OpenConnection();
            cmd.ExecuteNonQuery();
            connector.CloseConnection();
        }

        private void RemoveButton_Click(Object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(GenerateRemoveSQL(), connector.GetConnection());

            connector.OpenConnection();
            cmd.ExecuteNonQuery();
            connector.CloseConnection();
        }

        private string GenerateRemoveSQL()
        {
            string request = string.Empty;

            request += $"DELETE FROM contacts WHERE ID = (SELECT Contacts FROM customer WHERE FirstName = {FirstNameBox} AND LastName = {LastNameBox};\n";
            request += $"DELETE FROM receipt WHERE ID = (SELECT Receipt FROM receipt_customer WHERE Customer = (SELECT ID FROM customer WHERE FirstName = { FirstNameBox} AND LastName = { LastNameBox }));\n";
            request += $"DELETE FROM receipt WHERE ID = (SELECT Receipt FROM receipt_customer WHERE Customer = (SELECT ID FROM customer WHERE FirstName = { FirstNameBox} AND LastName = { LastNameBox }));\n";
            request += $"DELETE FROM receipt_customer WHERE Customer = (SELECT ID FROM Customer WHERE FirstName = {FirstNameBox} AND LastName = {LastNameBox});";

            return request;
        }
        
        private string GenerateAddingSQL()
        {
            string request = string.Empty;

            request += "INSERT INTO contacts (PhoneNumber, Email) VALUES (@PhoneNumber, @Email);\n";
            request += $"INSERT INTO customers (FirstName, LastName, Contacts) VALUES (@FirstName, @LastName, (SELECT ID FROM contacts WHERE PhoneNumber = @PhoneNumber));\n";
            request += "INSERT INTO receipt (Room, ArrivalDate, DepartureDate) VALUES (@Room, @ArrivalDate, @DepartureDate);\n";
            request += "INSERT INTO receipt_customers (Receipt, Customer) VALUES ((SELECT ID FROM receipt WHERE ArrivalDate = @ArrivalDate), (SELECT ID FROM customers WHERE FirstName = @FirstName AND LastName = @LastName));";

            return request;
        }
    }
}
