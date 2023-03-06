using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Taxi : Tpe
    {
        public Taxi(int cantidadPatas) : base(cantidadPatas)
        {

        }
        public override string Pasajeros()
        {
            return string.Format(":{0} pasajeros", pasajeros);
        }

        
    }
}
