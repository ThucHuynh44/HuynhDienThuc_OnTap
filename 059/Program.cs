using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            while (n > 0)
            {
                dem++;
                n = n / 10;
            }
            Console.WriteLine($"Số lượng chữ số của {n} là: {dem}");
            Console.ReadKey();
        }
    }
}