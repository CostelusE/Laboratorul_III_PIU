using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student s = new Student("Ionescu");
            s.SetNote("10 9 4,3 4 5,6 7 8,5 6");
            s.AfisareStudNote();
            Console.ReadKey();
            bool ok = true;
            do
            {
                Console.Clear();
                Console.WriteLine("S. Citire note de la tastatura ca un sir de caractere");
                Console.WriteLine("T. Citire note de la tastatura(cate o nota pe sir)");
                Console.WriteLine("C. Citire note din linia de comanda");
                Console.WriteLine("A. Afisare note");
                Console.WriteLine("X. Iesire");
                Console.WriteLine("Introdu optiunea:");

                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        s.CitireTastatura();
                        break;
                    case "T":
                        s.CitireTastaturaRand();
                        break;
                    case "C":


                        s.CitireLinieComanda(args);
                        break;
                    case "A":
                        s.Afisare();
                        break;
                    case "X":
                        ok = false;
                        break;
                }
                Console.ReadKey();
            }
            while (ok);
            Console.ReadKey();
        }
    }
}
