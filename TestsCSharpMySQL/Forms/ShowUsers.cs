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
        private void firstNameSearchButton_Click(object sender, EventArgs e)
        {
            SearchByFirstName();
        }
        private void lastNameSearchButton_Click(object sender, EventArgs e)
        {
            SearchByLastName();
        }

        private void emailSearchButton_Click(object sender, EventArgs e)
        {
            SearchByEmail();
        }

        private void comebackButton_Click(object sender, EventArgs e)
        {
            usersDataGridView.Rows.Clear();
            this.Close();
        }

        private void showAllUsersbutton_Click(object sender, EventArgs e)
        {
            ShowAllUsers();
        }

        void SearchByFirstName()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySQLConnectionString());

            string firstName = firstNameTextBox.Text;

            if(firstName == "")
            {
                MessageBox.Show("Você precisa digitar algo para pesquisar!");
                return;
            }

            try
            {
                connection.Open();

                string query = new string(
                    $"SELECT firstName, lastName, email FROM users WHERE firstName = '{firstName}'"
                    );

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    usersDataGridView.Rows.Clear();
                    while (reader.Read())
                    {
                        usersDataGridView.Rows.Add(reader["firstName"], reader["lastName"], reader["email"]);
                    }
                    firstNameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum usuário com este primeiro nome!");
                    firstNameTextBox.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }
        void SearchByLastName()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySQLConnectionString());

            string lastName = lastNameTextBox.Text;

            if (lastName == "")
            {
                MessageBox.Show("Você precisa digitar algo para pesquisar!");
                return;
            }

            try
            {
                connection.Open();

                string query = new string(
                    $"SELECT firstName, lastName, email FROM users WHERE lastName = '{lastName}'"
                    );

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    usersDataGridView.Rows.Clear();
                    while (reader.Read())
                    {
                        usersDataGridView.Rows.Add(reader["firstName"], reader["lastName"], reader["email"]);
                    }
                    lastNameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum usuário com este último nome!");
                    lastNameTextBox.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }
        void SearchByEmail()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySQLConnectionString());

            string email = emailTextBox.Text;

            if (email == "")
            {
                MessageBox.Show("Você precisa digitar algo para pesquisar!");
                return;
            }

            try
            {
                connection.Open();

                string query = new string(
                    $"SELECT firstName, lastName, email FROM users WHERE email = '{email}'"
                    );

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    usersDataGridView.Rows.Clear();
                    while (reader.Read())
                    {
                        usersDataGridView.Rows.Add(reader["firstName"], reader["lastName"], reader["email"]);
                    }
                    emailTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum usuário com este e-mail!");
                    emailTextBox.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }

        void ShowAllUsers()
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
