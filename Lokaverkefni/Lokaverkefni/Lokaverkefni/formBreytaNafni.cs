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
    public partial class formBreytaNafni : Form
    {
        formNafn form;
        SQL sql = new SQL();
        int kyn = 2;
        public formBreytaNafni(formNafn f)
        {
            form = f;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (sql.breytaNafni(txtNafn.Text, txtNyttNafn.Text, int.Parse(txtTidni.Text), kyn))
            {
                MessageBox.Show("Nafninu " + txtNafn.Text + " var breytt");
            }
            else
                MessageBox.Show("Villa kom upp");

            this.Close();
        }

        private void btnBreyta_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
            txtNyttNafn.Enabled = true;
            txtTidni.Enabled = true;
            txtNafn.Enabled = false;
            btnBreyta.Enabled = false;

            Strakar strakur = new Strakar();
            strakur.nafn = txtNafn.Text;
            Stelpur stelpa = new Stelpur();
            stelpa.nafn = txtNafn.Text;
            if (sql.faStrak(strakur))
            {
                kyn = 0;
                txtNyttNafn.Text = strakur.nafn;
                txtTidni.Text = strakur.tidni1.ToString();
            }
            else if (sql.faStelpu(stelpa))
            {
                kyn = 1;
                txtNyttNafn.Text = stelpa.nafn;
                txtTidni.Text = stelpa.tidni1.ToString();
            }
            else
                MessageBox.Show("Nafn fannst ekki");
            
        }
    }
}
