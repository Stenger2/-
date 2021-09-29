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
            int a, b;
            

            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("числа:");


            for (int i = a; i <= b; i+= ++a)
            {
                

                string c = "";

                while (i != 0)
                {
                    int t = i % 3;
                    i /= 3;
                    c += t.ToString();
                }
                char[] arr = c.ToCharArray();
                Array.Reverse(arr);
                if (new string(arr).Contains("22"))
                {
                Console.WriteLine(new string(arr));
                }

            }

            Console.ReadKey();
        }

        
            
        
    }
}
