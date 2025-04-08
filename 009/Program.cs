using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập bán kính r: ");
            double r = double.Parse(Console.ReadLine());
            double S = ((double)n * Math.Pow(r, 2) * Math.Sin(2 * Math.PI / (double)n)) / 2;
            Console.WriteLine($"Diện tích đa giác đều có {n} cạnh là: {S}");
            Console.ReadKey();
        }
    }
}