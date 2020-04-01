using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i, j,l,ok=0,p,k=0;
            string[][] vector = new string[26][];
            string buf,buf1;
            string buff,buf2;
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            string sir = "abcdefghijklmnopqrstuvwxyz";
            for (i = 0; i < sir.Length; i++)
            {
                ok = 0;
                for (j = 0; j < args.Length; j++)
                {
                    buf = args[j];
                    buf1 = args[j].ToLower();
                    if (sir[i] == buf1[0])
                        ok++;
                }
                if (ok > 0)
                {
                    vector[k] = new string[ok];
                    p = 0;
                    for (l = 0; l < args.Length; l++)
                    {
                        buff = args[l];
                        buf2 = args[l].ToLower();
                        if (sir[i] == buf2[0])
                        {
                            vector[k ][p] = args[l];
                            p++;
                        }
                    }
                    k++;
                }
                

            }
            
            for (i = 0; i < k; i++)
            {
                  
                    for (j = 0; j < vector[i].Length; j++)
                    
                        Console.Write("{0} ", vector[i][j]);
                Console.Write("\n");
            }
                Console.ReadKey();
        }
    }
}
