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
    public partial class EydaNofn : Form
    {
        Form1 form;
        SQL sql = new SQL();
        public EydaNofn(Form1 f)
        {
            form = f;
            InitializeComponent();
        }

        private void btnJa_Click(object sender, EventArgs e)
        {
            form.ok = true;
            this.Close();
        }

        private void btnNei_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
