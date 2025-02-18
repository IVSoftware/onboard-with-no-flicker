using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onboard_with_no_flicker
{
    public partial class OnboardingForm2 : Form
    {
        public OnboardingForm2()
        {
            InitializeComponent();
            textBoxUid.TextChanged += localUpdateVisibility;
            textBoxPswd.TextChanged += localUpdateVisibility;
            void localUpdateVisibility(object? sender, EventArgs e)
            {
                textBoxPswd.Visible = !string.IsNullOrWhiteSpace(textBoxUid.Text);
                buttonLogin.Visible = textBoxUid.Visible && !string.IsNullOrWhiteSpace(textBoxPswd.Text);
            }
            buttonLogin.Click += (sender, e) => DialogResult = DialogResult.OK;
        }
    }
}
