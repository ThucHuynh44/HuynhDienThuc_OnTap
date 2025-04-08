using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011
{
    class Program
    {
        struct Diem
        {
            public double x;
            public double y;
        }

        static void NhapDiem(ref Diem d)
        {
            Console.WriteLine("Nhập tọa độ x: ");
            d.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tọa độ y: ");
            d.y = double.Parse(Console.ReadLine());
        }
        static void XuatDiem(Diem d)
        {
            Console.WriteLine($"Tọa độ điểm: ({d.x}, {d.y})");
        }
        static double TinhKhoangCach(Diem A, Diem B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }

        static double TinhDienTich(Diem A, Diem B, Diem C)
        {
            double a = TinhKhoangCach(A, B);
            double b = TinhKhoangCach(B, C);
            double c = TinhKhoangCach(C, A);
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Diem A = new Diem();
            Diem B = new Diem();
            Diem C = new Diem();

            Console.WriteLine("Nhập tọa độ điểm A");
            NhapDiem(ref A);
            Console.WriteLine("Nhập tọa độ điểm B");
            NhapDiem(ref B);
            Console.WriteLine("Nhập tọa độ điểm C");
            NhapDiem(ref C);

            double S = TinhDienTich(A, B, C);
            Console.WriteLine($"Diện tích tam giác ABC = {S}");
            Console.ReadKey();
        }
    }
}