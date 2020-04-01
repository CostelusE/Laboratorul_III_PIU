using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti3
{
    class Student
    {
        // date membre private
        string nume;
        int[][] note;


        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;

        }

        public void SetNote(string sirNote)
        {

            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in matricea note

            String[] prep = sirNote.Split(',');
            note = new int[4][];
            for (int i = 0; i < prep.Length; i++)
            {
                string[] prep2 = prep[i].Split(' ');
                note[i] = new int[prep2.Length];
                for (int j = 0; j < prep2.Length; j++)
                    note[i][j] = Convert.ToInt32(prep2[j]);
            }



        }
        public void AfisareStudNote()
        {


            Console.WriteLine("Studentul {0} are urmatoarele note:\n", nume);
            Afisare();


        }
        public void CitireTastatura()

        {

            String s1 = Console.ReadLine();            String[] prep = s1.Split(',');
            note = new int[4][];
            for (int i = 0; i < prep.Length; i++)
            {
                
                string[] prep2 = prep[i].Split(' ');
                note[i] = new int[prep2.Length];
                for (int j = 0; j < prep2.Length; j++)
                    note[i][j] = Convert.ToInt32(prep2[j]);
            }
        }

        public void CitireTastaturaRand()
        {
            int l,nr=0;
            note = new int[4][];
            int[]buf= new int[15];
            int i = 0;
            int j = 0;
            do
            {

                string s1 = Console.ReadLine();
                
                if (i < 4 || j < 15)
                {
                    if (s1[0] == ',' || s1[0]=='.')
                    {
                        note[i] = new int[nr];
                        for (l = 0; l < nr; l++)
                            note[i][l] = buf[l];
                        i++;
                        j = 0;
                        nr = 0;

                    }
                    else
                    {
                        buf[j] = Convert.ToInt32(s1);
                        j++;
                        nr++;
                    }
                }
                if (s1[0] == '.')
                    break;

            } while (true);


        }
        public void CitireLinieComanda(string[] s1)
        {
            int j, k,nr=0,l;
            note = new int[4][];
            int []buf=new int[15];
            j = 0;
            k = 0;
            for (int i = 0; i < s1.Length; i++)
            {

                if (s1[i] == ",")
                {
                    
                    note[k] = new int[j];
                    for (l = 0; l < j; l++)
                        note[k][l] = buf[l];
                    k++;
                    
                    j = 0;
                }
                else
                {
                    Int32.TryParse(s1[i], out buf[j]);
                    j++;
                   
                }
  
            }



        }
        public void Afisare()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < note[i].Length; j++)
                        Console.Write("{0} ", note[i][j]);
                if (note[i][0] != 0)
                    Console.Write("\b,\n");

            }
        }

    }
}
