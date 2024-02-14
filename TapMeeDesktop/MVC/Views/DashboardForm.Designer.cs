namespace TapMeeDesktop.MVC.Views
{
    partial class DashboardForm
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
            clickButton = new Button();
            pointTextLabel = new Label();
            pointLabel = new Label();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.BackColor = Color.DarkRed;
            clickButton.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickButton.ForeColor = SystemColors.ButtonHighlight;
            clickButton.Location = new Point(323, 143);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(155, 54);
            clickButton.TabIndex = 2;
            clickButton.Text = "CLICK";
            clickButton.UseVisualStyleBackColor = false;
            clickButton.Click += button1_Click;
            // 
            // pointTextLabel
            // 
            pointTextLabel.AutoSize = true;
            pointTextLabel.Font = new Font("Montserrat", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pointTextLabel.Location = new Point(43, 23);
            pointTextLabel.Name = "pointTextLabel";
            pointTextLabel.Size = new Size(110, 39);
            pointTextLabel.TabIndex = 3;
            pointTextLabel.Text = "POINT";
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Font = new Font("Montserrat", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pointLabel.Location = new Point(77, 62);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new Size(36, 39);
            pointLabel.TabIndex = 4;
            pointLabel.Text = "0";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pointLabel);
            Controls.Add(pointTextLabel);
            Controls.Add(clickButton);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickButton;
        private Label pointTextLabel;
        private Label pointLabel;
    }
}