namespace onboard_with_no_flicker
{
    partial class OnboardingForm1
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
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.Green;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(118, 96);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Padding = new Padding(5);
            buttonLogin.Size = new Size(202, 45);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // OnboardingForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(buttonLogin);
            Name = "OnboardingForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Onboarding Screen 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
    }
}