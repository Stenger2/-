using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i;
            int res = 0;
            int res2 = 0;
            int d = 0;
            char x = 'X';

            int[] a = new int[9];
            int length = a.Length;
            Console.WriteLine("Введите первые 9 чисел ISBN: ");
            for (i = 0; i < 9; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                res += a[i] * length;
                length--;
            }

            res2 = res;

            while (d<10)
            {
                res = res2;
                res += d * 1;
                if (res % 11 == 0)
                {
                    
                    break;
                }
                d++;

            }

            for (i = 0; i < 9; i++)
            {
                Console.Write(a[i] + "");

            }
            if (d == 10)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(d);
            }
          
            Console.ReadKey();
        }
 
    }
}
