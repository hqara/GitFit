using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitFit
{
    public partial class FillInForm : Form
    {
        public FillInForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void exitFillBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain that you want to \nlose your registration information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // User clicked the OK button, exit the program
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }

        }
    }
}
