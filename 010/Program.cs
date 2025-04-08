using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị x: ");
            double x = double.Parse(Console.ReadLine());
            double S = 0;
            int dau = 1;
            for (int i = 1; i <= n; i++)
            {
                S += (double)dau * (Math.Pow(x, i));
                dau *= -1;
            }
            Console.WriteLine($"Tổng S = {S}");
            Console.ReadKey();
        }
    }
}