using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());
            double a1 = -2;
            for (int i = 2; i <= n; i++)
            {
                double a = 5 * a1 + 2 * Math.Pow(3, i) - 6 * Math.Pow(7, i) + 12;
                a1 = a;
            }
            Console.WriteLine($"Giá trị a{n} = {a1}");
            Console.ReadKey();
        }
    }
}