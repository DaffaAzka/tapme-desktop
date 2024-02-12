namespace TapMeeDesktop.MVC.Views
{
    partial class SignInForm
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
            paswordLabel = new Label();
            passwordBox = new TextBox();
            emailLabel = new Label();
            emailBox = new TextBox();
            brandingLabel = new Label();
            signInButton = new Button();
            SuspendLayout();
            // 
            // paswordLabel
            // 
            paswordLabel.AutoSize = true;
            paswordLabel.Location = new Point(154, 198);
            paswordLabel.Name = "paswordLabel";
            paswordLabel.Size = new Size(79, 21);
            paswordLabel.TabIndex = 12;
            paswordLabel.Text = "Password:";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(244, 195);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(402, 29);
            passwordBox.TabIndex = 11;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(154, 158);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 21);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(244, 155);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(402, 29);
            emailBox.TabIndex = 9;
            // 
            // brandingLabel
            // 
            brandingLabel.AutoSize = true;
            brandingLabel.Font = new Font("Pacifico", 17.855999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            brandingLabel.ForeColor = Color.DarkSlateGray;
            brandingLabel.Location = new Point(328, 36);
            brandingLabel.Name = "brandingLabel";
            brandingLabel.Size = new Size(144, 54);
            brandingLabel.TabIndex = 8;
            brandingLabel.Text = "Tap Me!";
            brandingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.CadetBlue;
            signInButton.Font = new Font("Montserrat", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInButton.ForeColor = SystemColors.Control;
            signInButton.Location = new Point(340, 274);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(121, 51);
            signInButton.TabIndex = 13;
            signInButton.Text = "SIGN IN";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signInButton);
            Controls.Add(paswordLabel);
            Controls.Add(passwordBox);
            Controls.Add(emailLabel);
            Controls.Add(emailBox);
            Controls.Add(brandingLabel);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paswordLabel;
        private TextBox passwordBox;
        private Label emailLabel;
        private TextBox emailBox;
        private Label brandingLabel;
        private Button signInButton;
    }
}