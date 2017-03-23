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
    public partial class frmSkraNafn : Form
    {
        formNafn fN;
        SQL sql = new SQL();
        public frmSkraNafn(formNafn f)
        {
            fN = f;        
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rBStrakur.Checked)
            {
                fN.kyn = 1;
                Strakar strakur = new Strakar();
                strakur.nafn = txtNafn.Text;
                strakur.tidni1 = int.Parse(txtTidni.Text);
                strakur.eignarfall = txtEF.Text;
                strakur.eignarfall2 = txtEF2.Text;
                sql.baetaStraki(strakur);
            }
            if (rBStelpa.Checked)
            {
                fN.kyn = 0;
                Stelpur stelpa = new Stelpur();
                stelpa.nafn = txtNafn.Text;
                stelpa.tidni1 = int.Parse(txtTidni.Text);
                sql.baetaStelpu(stelpa);
            }
            fN.ok = true;
            fN.string1 = txtNafn.Text;
            fN.string2 = txtEF.Text;
            fN.string3 = txtEF2.Text;
            fN.tidni = int.Parse(txtTidni.Text);
            this.Close();
        }

        private void frmSkraNafn_Load(object sender, EventArgs e)
        {

        }
    }
}
