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
            StreamReader sr = new StreamReader("adatok.dat");
            string[] atmeneti;
            int i = 0;
            while (!sr.EndOfStream)
            {
                atmeneti = Console.ReadLine().Split(' ');
                tomb[i] = int.Parse(atmeneti[i]);
                i++;


            }


            sr.Close();


        }
        static void Main(string[] args)
        {
            Beolvasas();

            Console.ReadKey();
        }
    }
}
