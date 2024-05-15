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
    public partial class AddUsers : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        public AddUsers()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
        private void comebackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddNewUser()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;

            string addNewUserQuery = new string(
                $"INSERT INTO users (firstName, lastName, email) VALUES ('{firstName}', '{lastName}', '{email}');"
                );

            if (firstName == "")
            {
                MessageBox.Show("Digite o primeiro nome!");
                return;
            }
            else if (lastName == "")
            {
                MessageBox.Show("Digite o último nome!");
                return;
            }
            else if (email == "")
            {
                MessageBox.Show("Digite o e-mail!");
                return;
            }

            MySqlConnection connection = new MySqlConnection(connectionInfo.MySQLConnectionString());

            MySqlCommand command = new MySqlCommand(addNewUserQuery, connection);
            command.CommandTimeout = 60;
            try
            {
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                   
                MessageBox.Show("Usuário cadastrado com sucesso!");

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show($"Query error: {e.Message}");
            }
        }
    }
}
