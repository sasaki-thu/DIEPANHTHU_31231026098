using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_04
    {
        public static void Main4()
        {
            //question_01();
            //question_02();
            //question_03();
            //question_001();
            //question_002();
            //question_003();
            question_004_5();
            //question_006();
            //question_007();
            //question_008();
            Console.ReadKey();
        }
        public static void question_01()
        {
            //kiem tra so chan hay le
            Console.Write("Nhap 1 so di: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) { Console.Write($"{n} la so chan."); }
            else Console.WriteLine($"{n} la so le.");
        }

        public static void question_02()
        {
            //tim so lon nhat trong 3 so
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nha[ so c: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b) { if (a > c) Console.Write($"{a} lon nhat."); }
            else if (b > c) Console.Write($"{b} lon nhat");
            else Console.WriteLine($"{c} lon nhat.");
        }

        public static void question_03()
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                    Console.Write($"Diem ({x},{y}) nam o goc phan tu thu nhat.");
                else Console.Write($"Diem ({x},{y}) nam o goc phan tu thu tu.");
            }
            else
            {
                if (y > 0) Console.Write($"Diem ({x},{y}) nam o goc phan tu thu hai.");
                else Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu thu ba.");
            }
        }

        public static void question_001()
        {
            //ktra xem tam giac la deu, can hay co 3 canh ko bang nhau
            Console.Write("Nhap canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            int c = int.Parse(Console.ReadLine());
            if (a + b >= c && a + c >= b && b + c >= a)
            {
                Console.Write("Day la 1 tam giac ");
                if (a == b && b == c && c == a) { Console.Write("deu."); }
                else if (a == b || b == c || a == c) { Console.Write("can."); }
                else Console.WriteLine("co 3 canh ko bang nhau.");
            }
            else Console.WriteLine("Day khong la tam giac.");

        }
        public static void question_002()
        {
            //nhap 10 so va tim sum, average
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write($"Phan tu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int S = 0;
            for (i = 0; i < n; i++) S = S + a[i];
            Console.WriteLine($"Tong cua cac phan tu la: {S}.");
            int tb = S / n;
            Console.WriteLine($"Trung binh cac phan tu la: {tb}");
        }
        public static void question_003()
        {
            //lap bang cuu chuong cua 1 so
            Console.Write("Nhap 1 so: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong cua {n}: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i} ");
            }
        }

        public static void question_004_5()
        {
            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hoa tiet tam giac vuong so lap lai: ");
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++) Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Hoa tiet tam giac vuong so lien tuc: ");
            int num = 1;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Hoa tiet tam giac can so lien tuc: ");
            int num2 = 1;
            for (i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                    Console.Write(" ");

                for (j = 1; j <= i; j++)
                {
                    Console.Write(num2 + " ");
                    num2++;
                }

                Console.WriteLine();
            }
        }

        public static void question_006()
        {
            //nhap n so va tinh tong 1+1/2+1/3+...+1/n
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            double S = 1;
            for (i = 2; i <= n; i++) S = S + 1f / i;
            Console.WriteLine($"1+1/2+1/3+...+1/{n} = {S}.");
        }
        public static void question_007()
        {
            //so hoan hao (so co cac uoc cong lai = chinh no)
            Console.Write("Nhap 1 so: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            for (int i = 1; i < n; i++) if (n % i == 0) S = S + i;
            Console.WriteLine($"Tong cac uoc cua {n} = {S}");
            if (S == n) Console.WriteLine($"{n} la so hoan hao.");
            else Console.WriteLine($"{n} khong la so hoan hao.");

        }
        public static void question_008()
        {
            //so nguyen to
            Console.Write("Nhap 1 so: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            for (int i = 1; i <= n; i++) if (n % i == 0) S++;
            if (S == 2) Console.WriteLine($"{n} la so nguyen to.");
            else Console.WriteLine($"{n} khong la so nguyen to.");
        }
    }
}
