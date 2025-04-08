using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _083
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị x: ");
            double x = double.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 1; i <= n; i++)
                S += Math.Sin(Math.Pow(x, i));
            Console.WriteLine($"Tổng S = {S}");
            Console.ReadKey();
        }
    }
}