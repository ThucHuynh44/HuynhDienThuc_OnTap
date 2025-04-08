using System;
using System.Threading;

class Program
{
    static bool isTVOn = false; // Trang thai cua tivi
    static int currentChannel = 1; // Kenh tivi hien tai

    static void Main(string[] args)
    {
        Console.WriteLine("Bat dau nau mi...");

        // Buoc 1: Lay goi mi va lay to
        LayGoiMi();
        LayTo();

        // Buoc 2: Bo mi vao to
        BoMiVaoTo();

        // Buoc 3: Dun nuoc soi
        Thread waterThread = new Thread(DeoNuocSoi);
        waterThread.Start();

        // Buoc 4: Chien trung va chuan bi gia vi trong luc doi nuoc soi
        Thread eggThread = new Thread(ChienTrung);
        eggThread.Start();
        Thread spiceThread = new Thread(ChuanBiGiaVi);
        spiceThread.Start();

        // Cho nuoc soi
        waterThread.Join();

        // Buoc 5: Do nuoc soi vao mi
        DoNuocSoiVaoMi();

        // Buoc 6: Doi mi chin
        WaitForMiChin();

        // Buoc 7: Thuong thuc mi
        ThuongThucMi();

        // Optional: Dieu khien tivi trong luc thuong thuc
        while (true)
        {
            Console.WriteLine("Bam T de tat tivi, B de bat tivi, Q de thoat");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.T)
            {
                TatTivi();
            }
            else if (key == ConsoleKey.B)
            {
                BatTivi();
            }
            else if (key == ConsoleKey.Q)
            {
                break;
            }
        }

        // Tat tivi khi ket thuc
        TatTivi();
    }

    static void LayGoiMi()
    {
        Console.WriteLine("Lay goi mi.");
    }

    static void LayTo()
    {
        Console.WriteLine("Lay to.");
    }

    static void BoMiVaoTo()
    {
        Console.WriteLine("Bo mi vao to.");
    }

    static void DeoNuocSoi()
    {
        Console.WriteLine("Dang dun nuoc soi...");
        Thread.Sleep(5000); // Mo phong viec dun nuoc trong 5 giay
        Console.WriteLine("Nuoc da soi.");
    }

    static void ChienTrung()
    {
        Console.WriteLine("Dang chien trung...");
        Thread.Sleep(3000); // Mo phong viec chien trung trong 3 giay
        Console.WriteLine("Trung chien xong.");
    }

    static void ChuanBiGiaVi()
    {
        Console.WriteLine("Dang chuan bi gia vi (rau, cu)...");
        Thread.Sleep(2000); // Mo phong viec chuan bi gia vi trong 2 giay
        Console.WriteLine("Gia vi chuan bi xong.");
    }

    static void DoNuocSoiVaoMi()
    {
        Console.WriteLine("Do nuoc soi vao mi.");
    }

    static void WaitForMiChin()
    {
        Console.WriteLine("Dang doi mi chin...");
        Thread.Sleep(5000); // Mo phong thoi gian mi chin trong 5 giay
        Console.WriteLine("Mi da chin.");
    }

    static void ThuongThucMi()
    {
        Console.WriteLine("Mi da san sang! Thuong thuc mi nao!");
    }

    // Optional: Tat tivi
    static void TatTivi()
    {
        if (isTVOn)
        {
            Console.WriteLine("Tivi tat.");
            isTVOn = false;
        }
        else
        {
            Console.WriteLine("Tivi da tat roi!");
        }
    }

    static void BatTivi()
    {
        if (!isTVOn)
        {
            Console.WriteLine("Tivi bat.");
            isTVOn = true;
            Console.WriteLine($"Tivi chuyen sang kenh {currentChannel}");
        }
        else
        {
            currentChannel++;
            Console.WriteLine($"Chuyen qua kenh {currentChannel}");
        }
    }
}
