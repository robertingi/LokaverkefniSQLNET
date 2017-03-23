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
    public partial class SkodaNofn : Form
    {
        SQL sql = new SQL();
        Form1 form;
        public SkodaNofn(Form1 f)
        {
            form = f;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SkodaNofn_Load(object sender, EventArgs e)
        {
            List<Nafn> nafn = sql.faNafnalista();
            for (int i = 0; i < nafn.Count; i++)
            {
                textBox1.AppendText(nafn[i].ToString());
            }
        }
    }
}
