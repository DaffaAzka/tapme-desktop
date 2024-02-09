namespace TapMeeDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            brandingLabel = new Label();
            inButton = new Button();
            upButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // brandingLabel
            // 
            brandingLabel.AutoSize = true;
            brandingLabel.Font = new Font("Pacifico", 17.855999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            brandingLabel.ForeColor = Color.DarkSlateGray;
            brandingLabel.Location = new Point(332, 18);
            brandingLabel.Name = "brandingLabel";
            brandingLabel.Size = new Size(144, 54);
            brandingLabel.TabIndex = 0;
            brandingLabel.Text = "Tap Me!";
            brandingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inButton
            // 
            inButton.BackColor = Color.DarkSlateGray;
            inButton.Font = new Font("Montserrat", 17.8559971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inButton.ForeColor = SystemColors.Control;
            inButton.Location = new Point(529, 315);
            inButton.Name = "inButton";
            inButton.Size = new Size(172, 70);
            inButton.TabIndex = 1;
            inButton.Text = "SIGN IN";
            inButton.UseVisualStyleBackColor = false;
            // 
            // upButton
            // 
            upButton.BackColor = Color.CadetBlue;
            upButton.Font = new Font("Montserrat", 17.8559971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upButton.ForeColor = SystemColors.Control;
            upButton.Location = new Point(117, 315);
            upButton.Name = "upButton";
            upButton.Size = new Size(172, 70);
            upButton.TabIndex = 2;
            upButton.Text = "SIGN UP";
            upButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(upButton);
            Controls.Add(inButton);
            Controls.Add(brandingLabel);
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label brandingLabel;
        private Button inButton;
        private Button upButton;
        private PictureBox pictureBox1;
    }
}