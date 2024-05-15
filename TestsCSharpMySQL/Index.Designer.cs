namespace TestsCSharpMySQL
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailTextBox = new TextBox();
            loginButton = new Button();
            labelEmail = new Label();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(9, 37);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Digite seu e-mail...";
            emailTextBox.Size = new Size(514, 23);
            emailTextBox.TabIndex = 7;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(9, 66);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 35);
            loginButton.TabIndex = 8;
            loginButton.Text = "Acessar";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelEmail.Location = new Point(9, 9);
            labelEmail.Margin = new Padding(0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(68, 25);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "E-Mail";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(loginButton);
            Controls.Add(emailTextBox);
            Controls.Add(labelEmail);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTextBox;
        private Button loginButton;
        private Label labelEmail;
    }
}
