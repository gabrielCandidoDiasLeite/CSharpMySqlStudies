namespace TestsCSharpMySQL
{
    partial class ShowUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usersDataGridView = new DataGridView();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            comebackButton = new Button();
            showAllUsersbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AllowUserToDeleteRows = false;
            usersDataGridView.AllowUserToOrderColumns = true;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Columns.AddRange(new DataGridViewColumn[] { firstName, lastName, email });
            usersDataGridView.Location = new Point(0, 0);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.ReadOnly = true;
            usersDataGridView.Size = new Size(585, 508);
            usersDataGridView.TabIndex = 0;
            // 
            // firstName
            // 
            firstName.HeaderText = "Primeiro Nome";
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            firstName.Width = 125;
            // 
            // lastName
            // 
            lastName.HeaderText = "Último Nome";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            lastName.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 290;
            // 
            // comebackButton
            // 
            comebackButton.Location = new Point(304, 514);
            comebackButton.Name = "comebackButton";
            comebackButton.Size = new Size(100, 35);
            comebackButton.TabIndex = 1;
            comebackButton.Text = "Voltar";
            comebackButton.UseVisualStyleBackColor = true;
            comebackButton.Click += comebackButton_Click;
            // 
            // showAllUsersbutton
            // 
            showAllUsersbutton.Location = new Point(198, 514);
            showAllUsersbutton.Name = "showAllUsersbutton";
            showAllUsersbutton.Size = new Size(100, 35);
            showAllUsersbutton.TabIndex = 2;
            showAllUsersbutton.Text = "Mostrar";
            showAllUsersbutton.UseVisualStyleBackColor = true;
            showAllUsersbutton.Click += showAllUsersbutton_Click;
            // 
            // ShowUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(showAllUsersbutton);
            Controls.Add(comebackButton);
            Controls.Add(usersDataGridView);
            Name = "ShowUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Usuários";
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView usersDataGridView;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn email;
        private Button comebackButton;
        private Button showAllUsersbutton;
    }
}