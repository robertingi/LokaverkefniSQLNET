using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lokaverkefni
{
    public class Strakar
    {
        public string nafn;
        public int tidni1, tidni2;
        public string eignarfall, eignarfall2;

        public Strakar()
        {
            this.nafn = string.Empty;
            this.tidni1 = 0;
            this.tidni2 = 0;
            this.eignarfall = string.Empty;
            this.eignarfall2 = string.Empty;
        }

        public Strakar(string nf, int t1, int t2, string ef, string ef2)
        {
            this.nafn = nf;
            this.tidni1 = t1;
            this.tidni2 = t2;
            this.eignarfall = ef;
            this.eignarfall2 = ef2;
        }

        public string Nafn
        {
            get { return this.nafn; }
            set { this.nafn = value; }
        }

        public int Tidni1
        {
            get { return this.tidni1; }
            set { this.tidni1 = value; }
        }

        public int Tidni2
        {
            get { return this.tidni2; }
            set { this.tidni2 = value; }
        }

        public string Eignarfall
        {
            get { return this.eignarfall; }
            set { this.eignarfall = value; }
        }

        public string Eignarfall2
        {
            get { return this.eignarfall2; }
            set { this.eignarfall2 = value; }
        }

        public override string ToString()
        {
            return this.nafn + "\\" + this.eignarfall + "\\" + this.eignarfall2 +Environment.NewLine + "\t\t\t\t" + this.tidni1 + "\t " + this.tidni2 + "\t " + Environment.NewLine;
        }
    }
}
