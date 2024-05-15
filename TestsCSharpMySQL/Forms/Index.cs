using MySql.Data.MySqlClient;
using System.Data;
using TestsCSharpMySQL.Connection;

namespace TestsCSharpMySQL
{
    public partial class Index : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        Menu menu = new Menu();
        public Index()
        {
            InitializeComponent();

            menu.FormClosed += MenuForm_FormClosed;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        void Login()
        {
            MySqlConnection connection = new MySqlConnection(connectionInfo.MySQLConnectionString());

            string email = emailTextBox.Text;

            if(email == "")
            {
                MessageBox.Show("Digite seu e-mail para acessar o sistema!");
                return;
            }

            string query = new string(
                $"SELECT * FROM users WHERE email = '{email}'"
                );

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count == 0 ) 
            {
                MessageBox.Show("E-mail não cadastrado no sistema!"); 
                emailTextBox.Text = "";
            }
            else
            {
                this.Hide();
                emailTextBox.Text = "";
                menu.ShowDialog();
                return;
            }
        }

        void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
