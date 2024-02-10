namespace TapMeeDesktop.MVC.Views
{
    partial class SignUpForm
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
            brandingLabel = new Label();
            usernameBox = new TextBox();
            usernameLabel = new Label();
            emailLabel = new Label();
            emailBox = new TextBox();
            paswordLabel = new Label();
            passwordBox = new TextBox();
            reLabel = new Label();
            reBox = new TextBox();
            signUpButton = new Button();
            SuspendLayout();
            // 
            // brandingLabel
            // 
            brandingLabel.AutoSize = true;
            brandingLabel.Font = new Font("Pacifico", 17.855999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            brandingLabel.ForeColor = Color.DarkSlateGray;
            brandingLabel.Location = new Point(328, 19);
            brandingLabel.Name = "brandingLabel";
            brandingLabel.Size = new Size(144, 54);
            brandingLabel.TabIndex = 1;
            brandingLabel.Text = "Tap Me!";
            brandingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(244, 113);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(402, 29);
            usernameBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(154, 116);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(84, 21);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(154, 155);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 21);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(244, 152);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(402, 29);
            emailBox.TabIndex = 4;
            // 
            // paswordLabel
            // 
            paswordLabel.AutoSize = true;
            paswordLabel.Location = new Point(154, 195);
            paswordLabel.Name = "paswordLabel";
            paswordLabel.Size = new Size(79, 21);
            paswordLabel.TabIndex = 7;
            paswordLabel.Text = "Password:";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(244, 192);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(402, 29);
            passwordBox.TabIndex = 6;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // reLabel
            // 
            reLabel.AutoSize = true;
            reLabel.Location = new Point(154, 234);
            reLabel.Name = "reLabel";
            reLabel.Size = new Size(67, 21);
            reLabel.TabIndex = 9;
            reLabel.Text = "Re-Pass:";
            // 
            // reBox
            // 
            reBox.Location = new Point(244, 231);
            reBox.Name = "reBox";
            reBox.Size = new Size(402, 29);
            reBox.TabIndex = 8;
            reBox.UseSystemPasswordChar = true;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.CadetBlue;
            signUpButton.Font = new Font("Montserrat", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = SystemColors.Control;
            signUpButton.Location = new Point(340, 275);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(121, 51);
            signUpButton.TabIndex = 11;
            signUpButton.Text = "SIGN UP";
            signUpButton.UseVisualStyleBackColor = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signUpButton);
            Controls.Add(reLabel);
            Controls.Add(reBox);
            Controls.Add(paswordLabel);
            Controls.Add(passwordBox);
            Controls.Add(emailLabel);
            Controls.Add(emailBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameBox);
            Controls.Add(brandingLabel);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label brandingLabel;
        private TextBox usernameBox;
        private Label usernameLabel;
        private Label emailLabel;
        private TextBox emailBox;
        private Label paswordLabel;
        private TextBox passwordBox;
        private Label reLabel;
        private TextBox reBox;
        private Button signUpButton;
    }
}