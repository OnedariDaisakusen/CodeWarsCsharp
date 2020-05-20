using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de unos  : " + CountBits(1234));

            Console.ReadLine();
        }

        public static int CountBits(int n)
        {
            Console.WriteLine("Numero : " + n);
            string binario = Convert.ToString(n, 2);
            Console.WriteLine("Binario : " + binario);
            int cont = 0;
            for(int  i = 0; i< binario.Length; i++)
            {
                if (binario[i].Equals('1'))
                {
                    cont++;
                }


            }

            return cont;
        }
    }
}
