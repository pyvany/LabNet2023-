using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tpe> Omnibus = new List<Tpe> { };
            for (int i = 1; i < 6; i++) {
                Console.WriteLine("Ingrese el num de pasajeros del Omnibus n° " + i);
                int pasajerosomnibus=  Convert.ToInt32(Console.ReadLine());
                Omnibus.Add(new Omnibus(pasajerosomnibus));

            }

            
            List<Tpe> Taxi = new List<Tpe> { };
            for (int i = 1; i < 6; i++)
            {
                
                Console.WriteLine("Ingrese el num de pasajeros del Taxi n° " + i);
                int pasajerostaxi = Convert.ToInt32(Console.ReadLine());
                Taxi.Add(new Omnibus(pasajerostaxi));

            }
            int num = 0;
            foreach (var item in Omnibus)
            {

                num++;
                Console.WriteLine("Omnibus n°" + num);
                Console.WriteLine(item.Pasajeros());
            }

            int num2 = 0;
            foreach (var item in Taxi)
            {

                num2++;
                Console.WriteLine("Omnibus n°" + num);
                Console.WriteLine(item.Pasajeros());
            }

            Console.ReadLine();
        }
    }
}
