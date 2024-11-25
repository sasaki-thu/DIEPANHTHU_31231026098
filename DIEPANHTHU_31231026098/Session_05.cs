using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_05
    {
        public static int max(ref int a, ref int b, ref int c)
        {
            int m = 0;
            if (a > b) { if (a > c) m = a; }
            else { if (b > c) m = b; else m = c; }
            return m;

        }
        public static int giaithua(ref int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++) s = s * i;
            return s;
        }
        public static int ngto(ref int n)
        {
            if (n < 2) return 0;
            int dem = 0;
            for (int i = 2; i <= n / 2; i++)
            { if (n % i == 0) dem++; }
            if (dem == 0) return 1; else return 0;
        }
        public static void c4_1(ref int n)
        {
            Console.Write($"Cac so nguyen to truoc {n} la: ");
            for (int i = 2; i < n; i++)
                if (ngto(ref i) == 1) Console.Write(i + " ");
        }
        public static void c4_2(ref int n)
        {
            int x = 2;
            int dem = 0;
            Console.Write($"{n} so nguyen to dau tien la: ");
            while (dem < n)
            {
                if (ngto(ref x) == 1)
                {
                    Console.Write(x + " ");
                    dem++;
                }
                x++;
            }
            Console.WriteLine();
        }
        public static int shh(ref int n)
        {
            int s = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0) s = s + i;
            if (s == n) return 1; else return 0;
        }
        public static void shhduoi1000()
        {
            Console.Write("Tat ca cac so hoan hao duoi 1000 la: ");
            for (int i = 1; i < 1000; i++)
                if (shh(ref i) == 1) Console.Write(i + " ");
            Console.WriteLine();
        }

        /*public static void pangram(string x)
        {
            x = x.ToLower();
        }*/
        public static void IsPangram(string str)
        {
            int compteur = 26;
            for (int i = 0; i <= str.Length; i++)
            {
                if (('A' <= str[i] && str[i] <= 'Z') || ('a' <= str[i] && str[i] <= 'z'))
                {
                    for (int j = str[i + 1]; j <= str.Length; j++)
                    {
                        if (compteur != 0 && str[i] != str[j])
                        {
                            compteur = compteur - 1;
                        }
                    }
                }
                if (compteur == 0) Console.WriteLine("pangram");
                else Console.WriteLine("not pangram"); ;
            }
        }
        public static void Main5()
        {
            //c1-solonnhat
            Console.WriteLine("TIM SO LON NHAT TRONG 3 SO");
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());
            int m = max(ref a, ref b, ref c);
            Console.WriteLine($"Vay so lon nhat la: {m}");
            Console.WriteLine();

            //c2-giaithua
            Console.WriteLine("TINH GIAI THUA CUA 1 SO");
            Console.Write("Nhap 1 so: ");
            int n1 = int.Parse(Console.ReadLine());
            int gt = giaithua(ref n1);
            Console.WriteLine($"Giai thua cua {n1}: {n1}!={gt}");
            Console.WriteLine();

            //c3-so nguyen to
            Console.WriteLine("KIEM TRA SO NGUYEN TO");
            Console.Write("Nhap 1 so: ");
            int n2 = int.Parse(Console.ReadLine());
            if (ngto(ref n2) == 1) Console.WriteLine($"{n2} la so nguyen to.");
            else Console.WriteLine($"{n2} khong la so nguyen to.");
            Console.WriteLine();

            //c4-1.in cac so ngto truoc n-2.n so ngto dau tien
            Console.WriteLine("IN CAC SO NGUYEN TO");
            Console.Write("Nhap 1 so: ");
            int n3 = int.Parse(Console.ReadLine());
            c4_1(ref n3);
            Console.WriteLine();
            c4_2(ref n3);
            Console.WriteLine();

            //c5-ktra so hoan hao va in so hoan hao duoi 1000
            Console.WriteLine("SO HOAN HAO");
            Console.Write("Nhap 1 so: ");
            int n4 = int.Parse(Console.ReadLine());
            if (shh(ref n4) == 1) Console.WriteLine($"{n4} la so hoan hao.");
            else Console.WriteLine($"{n4} khong la so hoan hao.");
            shhduoi1000();
            Console.WriteLine();

            //string la pagram ko?
            Console.Write("Nhap gi do di: ");
            string str = Console.ReadLine();
            IsPangram(str);
        }
    }
}
