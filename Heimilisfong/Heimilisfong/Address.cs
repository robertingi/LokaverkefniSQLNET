using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heimilisfong
{
    public class Address
    {
        private int postnumer;
        private string nefnifall;
        private string thagufall;

        public Address()
        {
            this.postnumer = 0;
            this.nefnifall = string.Empty;
            this.thagufall = string.Empty;
        }

        public Address(int pn, string nf, string thf)
        {
            this.postnumer = pn;
            this.nefnifall = nf;
            this.thagufall = thf;
        }

        public int Postnumer
        {
            get { return this.postnumer; }
            set { this.postnumer = value; }
        }
        public string Nefnifall
        {
            get { return this.nefnifall; }
            set { this.nefnifall = value; }
        }
        public string Thagufall
        {
            get { return this.thagufall; }
            set { this.nefnifall = value; }
        }

    }
}
