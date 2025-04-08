namespace CPhanSo
{
    public class PhanSo
    {
        private int TuSo { get; set; }
        private int MauSo { get; set; }
        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0");
            }
            TuSo = tuSo;
            MauSo = mauSo;
            RutGon();
        }

        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.WriteLine("Mau so khong the bang 0");
                MauSo = 1;
            }
            RutGon();
        }
        public void Xuat()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }
        private void RutGon()
        {
            int ucln = UCLN(TuSo, MauSo);
            TuSo /= ucln;
            MauSo /= ucln;
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            int tu = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            int mau = ps1.MauSo * ps2.MauSo;
            return new PhanSo(tu, mau);
        }
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            int tu = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo;
            int mau = ps1.MauSo * ps2.MauSo;
            return new PhanSo(tu, mau);
        }
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            int tu = ps1.TuSo * ps2.TuSo;
            int mau = ps1.MauSo * ps2.MauSo;
            return new PhanSo(tu, mau);
        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            if (ps2.TuSo == 0)
            {
                throw new DivideByZeroException("Khong the chia cho phan so co tu so bang 0");
            }
            int tu = ps1.TuSo * ps2.MauSo;
            int mau = ps1.MauSo * ps2.TuSo;
            return new PhanSo(tu, mau);
        }
        public static bool operator >(PhanSo ps1, PhanSo ps2)
        {
            return ps1.TuSo * ps2.MauSo > ps2.TuSo * ps1.MauSo;
        }

        public static bool operator <(PhanSo ps1, PhanSo ps2)
        {
            return ps1.TuSo * ps2.MauSo < ps2.TuSo * ps1.MauSo;
        }
        public static void SapXepTangDan(PhanSo[] psArr)
        {
            Array.Sort(psArr, (x, y) => (x.TuSo * y.MauSo).CompareTo(y.TuSo * x.MauSo));
        }
        public static void SapXepGiamDan(PhanSo[] psArr)
        {
            Array.Sort(psArr, (x, y) => (y.TuSo * x.MauSo).CompareTo(x.TuSo * y.MauSo));
        }
    }
}
