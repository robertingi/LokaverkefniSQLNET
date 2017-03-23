using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Heimilisfong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label2.Text = "Sending....";
            try
            {
                using (StreamReader sr = new StreamReader("streets.txt", System.Text.Encoding.UTF7))
                {
                    SQL sql = new SQL();
                    string line;
                    string[] array = new string[3];
                    int teljari = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        array = line.Split(';');
                        Address address = new Address(int.Parse(array[1]), array[2], array[3]);
                        sql.skraGotur(address);
                        teljari++;
                        label1.Text = teljari.ToString();
                    }
                    MessageBox.Show("Transfer done!");
                }
            }
            catch (Exception a)
            {
                label1.Text = "The file could not be read:";
                label1.Text = a.Message;
            }

        }
    }
}
