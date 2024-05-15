namespace TestsCSharpMySQL
{
    partial class Menu
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
            welcomeLabel = new Label();
            addUsersButton = new Button();
            showUsersButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Top;
            welcomeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            welcomeLabel.Location = new Point(0, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(584, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bem-vindo ao Sistema de Cadastro de Usuários!";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addUsersButton
            // 
            addUsersButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addUsersButton.Location = new Point(197, 60);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(200, 35);
            addUsersButton.TabIndex = 1;
            addUsersButton.Text = "Cadastrar Novo Usuário";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // showUsersButton
            // 
            showUsersButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showUsersButton.Location = new Point(197, 101);
            showUsersButton.Name = "showUsersButton";
            showUsersButton.Size = new Size(200, 35);
            showUsersButton.TabIndex = 2;
            showUsersButton.Text = "Visualizar Usuários";
            showUsersButton.UseVisualStyleBackColor = true;
            showUsersButton.Click += showUsersButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitButton.BackColor = Color.DarkRed;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(197, 142);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 35);
            exitButton.TabIndex = 3;
            exitButton.Text = "Sair";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(exitButton);
            Controls.Add(showUsersButton);
            Controls.Add(addUsersButton);
            Controls.Add(welcomeLabel);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Label welcomeLabel;
        private Button addUsersButton;
        private Button showUsersButton;
        private Button exitButton;
    }
}