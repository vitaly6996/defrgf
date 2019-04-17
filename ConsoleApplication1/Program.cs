using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов");
            int N = Convert.ToInt32(Console.ReadLine());
            Footwear[] arr = new Footwear[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = new Footwear();
                arr[i].Writing();
            }

            Console.WriteLine("Вывод:");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i].ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
