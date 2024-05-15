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
using TestsCSharpMySQL.Connection;

namespace TestsCSharpMySQL
{
    public partial class ShowUsers : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        public ShowUsers()
        {
            InitializeComponent();
        }

        private void comebackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAllUsersbutton_Click(object sender, EventArgs e)
        {
            ShowAllUsers();
        }
        public void ShowAllUsers()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySQLConnectionString());

            try
            {
                connection.Open();

                string query = new string(
                    $"SELECT firstName, lastName, email FROM users"
                );

                
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                usersDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    usersDataGridView.Rows.Add(reader["firstName"], reader["lastName"], reader["email"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
