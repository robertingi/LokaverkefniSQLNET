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
    public partial class Form1 : Form
    {
        SQL sql = new SQL();
        public bool ok = false;
        public int karlar;
        public int konur;
        public int aldur1;
        public int aldur2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkraNofn_Click(object sender, EventArgs e)
        {
            SkraNofn sn = new SkraNofn(this);
            sn.ShowDialog();
            sn.Dispose();

            if (ok)
            {
                if (sql.pantaNafn(karlar, konur, aldur1, aldur2))
                {
                    MessageBox.Show("Skráning tókst");
                }
                else
                    MessageBox.Show("Skráning mistókst");
                ok = false;
            }
        }

        private void btnSkodaNofn_Click(object sender, EventArgs e)
        {
            SkodaNofn skn = new SkodaNofn(this);
            skn.ShowDialog();
            skn.Dispose();
        }

        private void btnEydaNofn_Click(object sender, EventArgs e)
        {
            EydaNofn en = new EydaNofn(this);
            en.ShowDialog();
            en.Dispose();

            if (ok)
            {
                sql.eydaNofn();
                ok = false;
            }
        }

        private void btnLeita_Click(object sender, EventArgs e)
        {
            Leita le = new Leita(this);
            le.ShowDialog();
            le.Dispose();
        }

        private void btnNafn_Click(object sender, EventArgs e)
        {
            formNafn fm = new formNafn(this);
            fm.ShowDialog();
            fm.Dispose();
        }
    }
}
