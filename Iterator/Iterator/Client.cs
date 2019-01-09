using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Client
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public Client(string nume, string adresa)
        {
            Nume = nume;
            Adresa = adresa;
        }

        public override string ToString()
        {
            return string.Format("Nume: {0}, Adresa: {1}", this.Nume, this.Adresa);
        }
    }
}
