using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Omnibus : Tpe
    {
        public Omnibus(int cantidadPatas):base(cantidadPatas)
        {

        }
        public override string Pasajeros()
        {
            return $": {pasajeros} pasajeros";
        }

      
    }
}
