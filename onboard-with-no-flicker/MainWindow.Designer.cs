namespace onboard_with_no_flicker
{
    partial class MainWindow
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
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.DarkSalmon;
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(648, 21);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(140, 34);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Log Out";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogout);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
    }
}
