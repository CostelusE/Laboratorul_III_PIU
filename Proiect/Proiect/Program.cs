using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var header = String.Format("{0,-12}{1,8}{2,20}{3,21}{4,24}\n",
                              "Nume", "Prenume", "Data de nastere", "Numar de telefon", "Adresa de email");
            Console.WriteLine(header);

            var persoana1 = new Agenda();

            var persoana2 = new Agenda("Popescu","Ioan","23.06.1989","0752024987","popescuion@yahoo.com");
            Console.WriteLine(persoana1.Info());
            Console.WriteLine(persoana2.Info());

            var persoana3 = new Agenda("Ionescu Radu 08.12.1992 075898782 radu_ionescu@gmail.com");
            Console.WriteLine(persoana3.Info());
            Console.ReadKey();
        }
    }
}
