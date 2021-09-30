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
            int sum = 0;

            Console.WriteLine("Введите размер массива: ");
            i = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[i];
            Console.WriteLine("Введите элементы массива: ");

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());  
            }

            int max = arr.Max();
            int min = arr.Min();

            int MaxInd = Array.IndexOf(arr, max);
            int MiniInd = Array.IndexOf(arr, min);

            for (i = MiniInd; i <= MaxInd; i++)
            {
                sum += arr[i]; 
            }

            

            Console.WriteLine("Ваш массив:");

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }

            
            Console.WriteLine("Сумма:" + sum);

            Console.ReadKey();

            /*
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

            */
        }
 
    }
}
