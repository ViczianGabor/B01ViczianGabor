using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01ViczianGabor
{
    class Program
    {
        static int[] tomb = new int[3000];

        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.txt",true);
            string[] atmeneti;
            int i = 0;
            while (!sr.EndOfStream)
            {
                atmeneti = Console.ReadLine().Split();
                tomb[i] = Convert.ToInt32(atmeneti[i]);
                i++;


            }


            sr.Close();


        }
        static int min = tomb[0];
        static int Minimumertek (int min)
        {
            
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            
            return min;
            

        }
        static int oszthato = 0;
        static int Egyediek(int oszthato)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 5 ==0)
                {
                    if (tomb[i] % 4 !=0)
                    {
                        StreamWriter sw = new StreamWriter("adatok.txt");
                        for (int j = 0; j < tomb.Length; j++)
                        {
                            sw.WriteLine(tomb[i]);
                        }

                        sw.Close();
                        oszthato++;
                    }
                }
            }
            return oszthato;
            
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Minimumertek(min);
            Console.WriteLine("A minimum: {0}", Minimumertek(min));
            Egyediek(oszthato);
            Console.WriteLine("5 osztható de 4 nem oszthatóak száma: {0}", Egyediek(oszthato));
            Console.ReadKey();
        }
    }
}
