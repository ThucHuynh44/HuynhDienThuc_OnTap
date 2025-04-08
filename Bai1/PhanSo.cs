using System;
using CPhanSo;

class Program
{
    static void Main(string[] args)
    {
        PhanSo ps1 = new PhanSo(1, 2);
        PhanSo ps2 = new PhanSo(2, 3);


        PhanSo ps3 = new PhanSo();
        ps3.Nhap();

        ps1.Xuat();
        ps2.Xuat();
        ps3.Xuat();

        PhanSo psTong = ps1 + ps2;
        PhanSo psHieu = ps1 - ps2;
        PhanSo psTich = ps1 * ps2;
        PhanSo psThuong = ps1 / ps2;

        Console.WriteLine("Tong: ");
        psTong.Xuat();
        Console.WriteLine("Hieu: ");
        psHieu.Xuat();
        Console.WriteLine("Tich: ");
        psTich.Xuat();
        Console.WriteLine("Thuong: ");
        psThuong.Xuat();

        Console.WriteLine("ps1 > ps2: " + (ps1 > ps2));
        Console.WriteLine("ps1 < ps2: " + (ps1 < ps2));

        PhanSo[] psArr = { new PhanSo(3, 4), new PhanSo(1, 2), new PhanSo(5, 6) };
        Console.WriteLine("Phan so truoc khi sap xep: ");
        foreach (var ps in psArr)
        {
            ps.Xuat();
        }

        PhanSo.SapXepTangDan(psArr);
        Console.WriteLine("Phan so sau khi sap xep tang dan: ");
        foreach (var ps in psArr)
        {
            ps.Xuat();
        }

        PhanSo.SapXepGiamDan(psArr);
        Console.WriteLine("Phan so sau khi sap xep giam dan: ");
        foreach (var ps in psArr)
        {
            ps.Xuat();
        }
    }
}
