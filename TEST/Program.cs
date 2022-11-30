using System;
using TEST;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat kat1 = new("grå");
            Console.WriteLine(kat1.Farve);

            kat1.skiftfarve();
        }
    }
}