using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lokaverkefni
{
    public class Stelpur
    {
        public string nafn;
        public int tidni1, tidni2;

        public Stelpur()
        {
            this.nafn = string.Empty;
            this.tidni1 = 0;
            this.tidni2 = 0;
        }

        public Stelpur(string nf, int t1, int t2)
        {
            this.nafn = nf;
            this.tidni1 = t1;
            this.tidni2 = t2;
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

        public override string ToString()
        {
            return this.nafn + Environment.NewLine + "\t " + "\t"+this.tidni1 + "\t " + this.tidni2 + Environment.NewLine;
        }
    }
}
