using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Tpe
    {
        public int pasajeros { get; set; }

        public Tpe(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }
        public abstract string Pasajeros();

    }
}
