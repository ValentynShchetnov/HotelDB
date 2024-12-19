using DBHotel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDB
{
    public partial class Clients : Form
    {
        private DatabaseConnector connector = new();

        public Clients()
        {
            InitializeComponent();
            FindClients();
        }

        private void FindClients()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers JOIN contacts ON customers.Contacts = contacts.ID", connector.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            ClientsView.DataSource = table;
        }
    }
}
