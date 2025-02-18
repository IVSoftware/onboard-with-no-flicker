namespace onboard_with_no_flicker
{
    partial class OnboardingForm2
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
            textBoxUid = new TextBox();
            textBoxPswd = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUid
            // 
            textBoxUid.Location = new Point(52, 54);
            textBoxUid.Margin = new Padding(4);
            textBoxUid.Name = "textBoxUid";
            textBoxUid.PlaceholderText = "User Name";
            textBoxUid.Size = new Size(376, 39);
            textBoxUid.TabIndex = 0;
            // 
            // textBoxPswd
            // 
            textBoxPswd.Location = new Point(52, 117);
            textBoxPswd.Margin = new Padding(4);
            textBoxPswd.Name = "textBoxPswd";
            textBoxPswd.PasswordChar = '*';
            textBoxPswd.PlaceholderText = "Password";
            textBoxPswd.Size = new Size(376, 39);
            textBoxPswd.TabIndex = 1;
            textBoxPswd.Visible = false;
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.Green;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(52, 180);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Padding = new Padding(5);
            buttonLogin.Size = new Size(376, 52);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Visible = false;
            // 
            // OnboardingForm2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPswd);
            Controls.Add(textBoxUid);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "OnboardingForm2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Onboarding Screen 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUid;
        private TextBox textBoxPswd;
        private Button buttonLogin;
    }
}