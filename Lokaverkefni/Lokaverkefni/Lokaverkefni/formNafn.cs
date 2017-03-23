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
    public partial class formNafn : Form
    {
        SQL sql = new SQL();
        Form1 form;
        public bool ok = false;
        public int kyn = 2;
        public int tidni = 0;
        public string string1,string2,string3;
        public formNafn(Form1 f)
        {
            form = f;
            InitializeComponent();
        }

        private void btnStrakar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nafn\\Eignarfall\t\t\tTíðni1\tTíðni2" + Environment.NewLine;
            List<Strakar> strakar = sql.faStrakaNofn();
            for (int i = 0; i < strakar.Count; i++)
            {
                textBox1.AppendText(strakar[i].ToString());
            }
        }

        private void btnStelpur_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nafn\t\tTíðni1\tTíðni2" + Environment.NewLine;
            List<Stelpur> stelpur = sql.faStelpuNofn();
            for (int i = 0; i < stelpur.Count; i++)
            {
                textBox1.AppendText(stelpur[i].ToString());
            }
        }

        private void btnEydaNafni_Click(object sender, EventArgs e)
        {
            frmEydaNafni fen = new frmEydaNafni(this);
            fen.ShowDialog();
            fen.Dispose();

            if (ok)
            {
                if (kyn == 1)
                {
                    sql.eydaStrakaNafni(string1);
                }
                if (kyn == 0)
	            {
                    sql.eydaStelpuNafni(string1);
	            }
                ok = false;

            }
        }

        private void btnFaNofn_Click(object sender, EventArgs e)
        {
            sql.skrastelpuNofn();
            sql.skrastrakaNofn();
        }

        private void btnSkraNafn_Click(object sender, EventArgs e)
        {
            frmSkraNafn fsn = new frmSkraNafn(this);
            fsn.ShowDialog();
            fsn.Dispose();

            if (ok)
            {
                if (kyn == 1)
                {
                    MessageBox.Show("Strákanafni var bætt við");
                }
                else if (kyn == 0)
                {
                    MessageBox.Show("Stelpunafni var bætt við");
                }
            }
        }

        private void btnBreytaNafni_Click(object sender, EventArgs e)
        {
            formBreytaNafni fbn = new formBreytaNafni(this);
            fbn.ShowDialog();
            fbn.Dispose();

        }
    }
}
