using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lokaverkefni
{
    public partial class frmEydaNafni : Form
    {
        formNafn fN;
        public frmEydaNafni(formNafn f)
        {
            fN = f;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rBStelpur.Checked)
            {
                fN.kyn = 0;
            }
            if (rBStrakar.Checked)
            {
                fN.kyn = 1;
            }
            fN.ok = true;
            fN.string1 = txtEyda.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
