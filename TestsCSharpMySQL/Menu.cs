using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsCSharpMySQL
{
    public partial class Menu : Form
    {
        AddUsers addUsers = new AddUsers();
        ShowUsers showUsers = new ShowUsers();
        public Menu()
        {
            InitializeComponent();

            addUsers.FormClosed += Form_FormClosed;
            showUsers.FormClosed += Form_FormClosed;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addUsers.ShowDialog();
        }
        private void showUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            showUsers.ShowDialog();
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
