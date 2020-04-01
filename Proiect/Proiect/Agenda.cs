using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Agenda
    {
        private string nume;
        private string prenume;
        private string nr_telefon;
        private string adresa_email;
        private string data_nastere;

        //Constructori 
      public Agenda()
        {
            nume = string.Empty;
            prenume = string.Empty;
            adresa_email = string.Empty;
            data_nastere = string.Empty;
            nr_telefon = string.Empty;
           
        }

        //Constructor cu parametri

        public Agenda(string _nume,string _prenume,string _data_nastere,string _nr_telefon, string _adresa_email)
        {
            nume = _nume;
            prenume = _prenume;
            adresa_email = _adresa_email;
            data_nastere = _data_nastere;
            nr_telefon = _nr_telefon;
         
        }

        //Constructor cu parametru de tip string

        public Agenda(string sir)
        {
            string[] buf = sir.Split(' ');
            nume = buf[0];
            prenume = buf[1];
            data_nastere = buf[2];
            nr_telefon = buf[3];
            adresa_email = buf[4];
        }

        //Afisare date 

        public string Info()
        {
            return String.Format("{0,-12}{1,8}{2,20}{3,21}{4,24}", nume,prenume,data_nastere,nr_telefon, adresa_email);
        }
    }
   

}
