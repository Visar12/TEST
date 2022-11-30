using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Kat
    {
        public string Farve = "grå";

        public Kat(string farve)
        {
           Farve=farve;
        }   
        public void skiftfarve()
        {
            Farve="gul";
            Console.WriteLine($"Din farve er {Farve}");
        }
    }
}
