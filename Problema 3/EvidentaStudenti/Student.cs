using System;
namespace LibrarieEntitati
{
    public class Student
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
            for (int l = 0; l < 4; l++)
                note[l] = new int[15];

            for (int i = 0; i < prep.Length; i++)
            {
                string[] prep2 = prep[i].Split(' ');
                for (int j = 0; j < prep2.Length; j++)
                    note[i][j] = Convert.ToInt32(prep2[j]);
            }



        }
        public void AfisareStudNote()
        {

            
            Console.WriteLine("Studentul {0} are urmatoarele note:\n",nume);
            Afisare();

            
        }
        public void CitireTastatura()

        {
            
            String s1 = Console.ReadLine();            String [] prep = s1.Split(',');
            note = new int[4][];
            for (int l = 0; l < 4; l++)
                note[l] = new int[15];
            
            for (int i = 0; i < prep.Length; i++)
            {
                string[] prep2 = prep[i].Split(' ');
                for (int j = 0; j <prep2.Length ; j++)
                    note[i][j] = Convert.ToInt32(prep2[j]);
            }
        }

        public void CitireTastaturaRand()
        {
            int ok = 0;
            note = new int[4][];
            for (int l = 0; l < 4; l++)
                note[l] = new int[15];
            int i = 0;
            int j = 0;
            do
            {
                
                string s1 = Console.ReadLine();
                if (s1[0] == '.')
                    break;
                if (i < 4 || j < 15)
                {
                    if (s1[0] == ',')
                    {
                        i++;
                        j = 0;

                    }
                    else
                    {
                        note[i][j] = Convert.ToInt32(s1);
                        j++;
                    }
                }
                
            } while (true);
           

        }
        public void CitireLinieComanda(string[] s1 )
        {
            int j, k;
            note = new int[4][];
            for (int l = 0; l < 4; l++)
                note[l] = new int[15];
            j = 0;
            k = 0;
            for (int i = 0; i < s1.Length; i++)
            {

                if (s1[i] != ",")
                {
                    note[j][k] = Convert.ToInt32(s1[i]);
                    k++;
                }
                else
                {
                    k = 0;
                    j++;
                }
                
            }



        }
    public void Afisare()
        {
            for (int i = 0; i <4 ; i++)
            {
                for (int j = 0; j < 15; j++)
                    if (note[i][j] != 0)
                                            
                        Console.Write("{0} ", note[i][j]);
                if(note[i][0]!=0)    
                Console.Write("\b,\n");
               
            }
                   }


    }
}
