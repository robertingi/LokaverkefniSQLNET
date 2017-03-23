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
    public partial class Leita : Form
    {
        SQL sql = new SQL();
        Form1 form;
        public Leita(Form1 f)
        {
            form = f;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (rBID.Checked)
            {
                Nafn nafn = new Nafn();
                try
                {
                    nafn.ID = int.Parse(txtLeita.Text);
                }
                catch
                {
                    textBox1.Text = "Villa kom upp";
                }
                if (sql.faID(nafn))
                {
                    textBox1.Text = nafn.ToString();
                }
                else
                {
                    textBox1.Text = "Þetta ID fannst ekki";
                }
            }

            if (rBKT.Checked)
            {
                Nafn nafn = new Nafn();
                nafn.Kennitala = txtLeita.Text;
                List<Nafn> nofn = sql.faKT(nafn);
                if (nofn.Count == 0)
                {
                    textBox1.Text = "Ekkert fannst";
                }
                for (int i = 0; i < nofn.Count; i++)
                {
                    textBox1.AppendText(nofn[i].ToString());
                }
            }

            if (rBHeimilisfang.Checked)
            {
                Nafn nafn = new Nafn();
                nafn.Heimilisfang = txtLeita.Text;
                List<Nafn> nofn = sql.faHeimilisfang(nafn);
                if (nofn.Count == 0)
                {
                    textBox1.Text = "Ekkert fannst";
                }
                for (int i = 0; i < nofn.Count; i++)
                {
                    textBox1.AppendText(nofn[i].ToString());
                }
            }

            if (rBPostnr.Checked)
            {
                Nafn nafn = new Nafn();
                try
                {
                    nafn.Postnumer = int.Parse(txtLeita.Text);
                }
                catch
                {
                    textBox1.Text = "Villa kom upp";
                }
                List<Nafn> nofn = sql.faPostnr(nafn);
                if (nofn.Count == 0)
                {
                    textBox1.Text = "Ekkert fannst";
                }
                for (int i = 0; i < nofn.Count; i++)
                {
                    textBox1.AppendText(nofn[i].ToString());
                }
            }

            if (rBNafn.Checked)
            {
                Nafn nafn = new Nafn();
                nafn.Fulltnafn = txtLeita.Text;
                List<Nafn> nofn = sql.faNafn(nafn);
                if (nofn.Count == 0)
                {
                    textBox1.Text = "Ekkert fannst";
                }
                for (int i = 0; i < nofn.Count; i++)
                {
                    textBox1.AppendText(nofn[i].ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
