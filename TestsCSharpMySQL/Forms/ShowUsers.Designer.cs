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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameSearchButton = new Button();
            lastNameSearchButton = new Button();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            emailSearchButton = new Button();
            emailTextBox = new TextBox();
            emailLabel = new Label();
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
            usersDataGridView.Location = new Point(0, 95);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.ReadOnly = true;
            usersDataGridView.Size = new Size(585, 413);
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
            comebackButton.Location = new Point(472, 514);
            comebackButton.Name = "comebackButton";
            comebackButton.Size = new Size(100, 35);
            comebackButton.TabIndex = 1;
            comebackButton.Text = "Voltar";
            comebackButton.UseVisualStyleBackColor = true;
            comebackButton.Click += comebackButton_Click;
            // 
            // showAllUsersbutton
            // 
            showAllUsersbutton.Location = new Point(366, 514);
            showAllUsersbutton.Name = "showAllUsersbutton";
            showAllUsersbutton.Size = new Size(100, 35);
            showAllUsersbutton.TabIndex = 2;
            showAllUsersbutton.Text = "Mostrar Todos";
            showAllUsersbutton.UseVisualStyleBackColor = true;
            showAllUsersbutton.Click += showAllUsersbutton_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            firstNameLabel.Location = new Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(113, 19);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Primeiro Nome";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(131, 8);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "Digite o primeiro nome que deseja procurar...";
            firstNameTextBox.Size = new Size(335, 23);
            firstNameTextBox.TabIndex = 4;
            // 
            // firstNameSearchButton
            // 
            firstNameSearchButton.Location = new Point(472, 8);
            firstNameSearchButton.Name = "firstNameSearchButton";
            firstNameSearchButton.Size = new Size(100, 23);
            firstNameSearchButton.TabIndex = 5;
            firstNameSearchButton.Text = "Procurar";
            firstNameSearchButton.UseVisualStyleBackColor = true;
            firstNameSearchButton.Click += firstNameSearchButton_Click;
            // 
            // lastNameSearchButton
            // 
            lastNameSearchButton.Location = new Point(472, 37);
            lastNameSearchButton.Name = "lastNameSearchButton";
            lastNameSearchButton.Size = new Size(100, 23);
            lastNameSearchButton.TabIndex = 8;
            lastNameSearchButton.Text = "Procurar";
            lastNameSearchButton.UseVisualStyleBackColor = true;
            lastNameSearchButton.Click += lastNameSearchButton_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(131, 37);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Digite o último nome que deseja procurar...";
            lastNameTextBox.Size = new Size(335, 23);
            lastNameTextBox.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lastNameLabel.Location = new Point(12, 38);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(99, 19);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Último Nome";
            // 
            // emailSearchButton
            // 
            emailSearchButton.Location = new Point(472, 66);
            emailSearchButton.Name = "emailSearchButton";
            emailSearchButton.Size = new Size(100, 23);
            emailSearchButton.TabIndex = 11;
            emailSearchButton.Text = "Procurar";
            emailSearchButton.UseVisualStyleBackColor = true;
            emailSearchButton.Click += emailSearchButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(131, 66);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Digite o e-mail que deseja procurar...";
            emailTextBox.Size = new Size(335, 23);
            emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            emailLabel.Location = new Point(12, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 19);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "E-mail";
            // 
            // ShowUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(emailSearchButton);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(lastNameSearchButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameSearchButton);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(showAllUsersbutton);
            Controls.Add(comebackButton);
            Controls.Add(usersDataGridView);
            Name = "ShowUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Usuários";
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersDataGridView;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn email;
        private Button comebackButton;
        private Button showAllUsersbutton;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Button firstNameSearchButton;
        private Button lastNameSearchButton;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Button emailSearchButton;
        private TextBox emailTextBox;
        private Label emailLabel;
    }
}