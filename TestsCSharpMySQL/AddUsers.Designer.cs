namespace TestsCSharpMySQL
{
    partial class AddUsers
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
            labelPrimeiroNome = new Label();
            firstNameTextBox = new TextBox();
            labelUltimoNome = new Label();
            lastNameTextBox = new TextBox();
            labelEmail = new Label();
            emailTextBox = new TextBox();
            addButton = new Button();
            comebackButton = new Button();
            SuspendLayout();
            // 
            // labelPrimeiroNome
            // 
            labelPrimeiroNome.AutoSize = true;
            labelPrimeiroNome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelPrimeiroNome.Location = new Point(12, 9);
            labelPrimeiroNome.Margin = new Padding(0);
            labelPrimeiroNome.Name = "labelPrimeiroNome";
            labelPrimeiroNome.Size = new Size(148, 25);
            labelPrimeiroNome.TabIndex = 0;
            labelPrimeiroNome.Text = "Primeiro Nome";
            labelPrimeiroNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 38);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "Digite seu primeiro nome...";
            firstNameTextBox.Size = new Size(514, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // labelUltimoNome
            // 
            labelUltimoNome.AutoSize = true;
            labelUltimoNome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelUltimoNome.Location = new Point(12, 64);
            labelUltimoNome.Margin = new Padding(0);
            labelUltimoNome.Name = "labelUltimoNome";
            labelUltimoNome.Size = new Size(131, 25);
            labelUltimoNome.TabIndex = 2;
            labelUltimoNome.Text = "Último Nome";
            labelUltimoNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 92);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Digite seu último nome...";
            lastNameTextBox.Size = new Size(514, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelEmail.Location = new Point(12, 118);
            labelEmail.Margin = new Padding(0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(68, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-Mail";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 146);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Digite seu e-mail...";
            emailTextBox.Size = new Size(514, 23);
            emailTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 175);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 35);
            addButton.TabIndex = 6;
            addButton.Text = "Cadastrar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // comebackButton
            // 
            comebackButton.Location = new Point(426, 175);
            comebackButton.Name = "comebackButton";
            comebackButton.Size = new Size(100, 35);
            comebackButton.TabIndex = 7;
            comebackButton.Text = "Voltar";
            comebackButton.UseVisualStyleBackColor = true;
            comebackButton.Click += comebackButton_Click;
            // 
            // AddUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(comebackButton);
            Controls.Add(addButton);
            Controls.Add(emailTextBox);
            Controls.Add(labelEmail);
            Controls.Add(lastNameTextBox);
            Controls.Add(labelUltimoNome);
            Controls.Add(firstNameTextBox);
            Controls.Add(labelPrimeiroNome);
            Name = "AddUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrimeiroNome;
        private TextBox firstNameTextBox;
        private Label labelUltimoNome;
        private TextBox lastNameTextBox;
        private Label labelEmail;
        private TextBox emailTextBox;
        private Button addButton;
        private Button comebackButton;
    }
}