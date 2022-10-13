using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz = ");
           
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = y; i >= 1; i--) //sol kısım
            {
                for (int j = y; j >= i; j--) //sağ kısım
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++) //iç boşluklar
                {
                    if (k == 1 || k == 2 * i - 1) 
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Read();
        }


        }
}
