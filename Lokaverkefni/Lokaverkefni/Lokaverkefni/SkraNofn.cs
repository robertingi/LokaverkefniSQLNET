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
    public partial class SkraNofn : Form
    {
        Form1 form;
        public SkraNofn(Form1 f)
        {
            form = f;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSkra_Click(object sender, EventArgs e)
        {
            form.karlar = int.Parse(txtKK.Text);
            form.konur = int.Parse(txtKVK.Text);
            form.aldur1 = int.Parse(txtAldurMin.Text);
            form.aldur2 = int.Parse(txtAldurMax.Text);
            form.ok = true;
            this.Close();
        }
    }
}
