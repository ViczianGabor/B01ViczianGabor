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
            StreamReader sr = new StreamReader("adatok.txt");
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
        private static int Minimumertek (int min)
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
        static void Main(string[] args)
        {
            Beolvasas();
            Minimumertek(min);
            Console.WriteLine("A minimum: {0}", Minimumertek(min));
            Console.ReadKey();
        }
    }
}
