using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Lokaverkefni
{
    public class Nafn
    {
        private int id;
        private string kt;
        private string nafn;
        private string heimilisfang;
        private int postnumer;
        private string kennitala;

        public Nafn()
        {
            this.id = 0;
            this.kt = string.Empty;
            this.nafn = string.Empty;
            this.heimilisfang = string.Empty;
            this.postnumer = 0;
        }

        public Nafn(int id, string kt, string nf, string hf, int pn)
        {
            this.id = id;
            this.kt = kt;
            this.nafn = nf;
            this.heimilisfang = hf;
            this.postnumer = pn;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Kennitala
        {
            get { return this.kt; }
            set { this.kt = value; }
        }

        public string Fulltnafn
        {
            get { return this.nafn; }
            set { this.nafn = value; }
        }

        public string Heimilisfang
        {
            get { return this.heimilisfang; }
            set { this.heimilisfang = value; }
        }
        public int Postnumer
        {
            get { return this.postnumer; }
            set { this.postnumer = value; }
        }

        public override string ToString()
        {
            if (this.kt.Length == 10)
            {
                this.kennitala = this.kt.Insert(6, "-");
            }
            return "ID: " + this.id + Environment.NewLine + "Kennitala: " + this.kennitala + Environment.NewLine + "Nafn: " + this.nafn + Environment.NewLine + "Heimilisfang: " + this.heimilisfang + Environment.NewLine + "Póstnúmer: " + this.postnumer + Environment.NewLine + "---------------------------" + Environment.NewLine;
        }
    }
}
