using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_07
    {
        public static void nhapmang(int[,] a, int d, int c)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void nhaprand(int[,] a, int d, int c)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(0, 100);
                }
        }
        public static void xuatmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static int max(int[,] a)
        {
            int ma = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > ma) ma = a[i, j];
            }
            return ma;
        }

        public static void dongthui(int[,] a, int dong)
        {
            if (dong < 0 || dong > a.GetLength(0))
            {
                Console.WriteLine("Dong khong hop le.");
            }
            Console.WriteLine($"Dong thu {dong}: ");
            int min = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"{a[dong, j]}" + "\t");
                min = a[dong, j];
            }
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[dong, j] < min) min = a[dong, j];
            }
            Console.WriteLine();
            Console.WriteLine($"Min value cua dong {dong} la: {min}");
            Console.WriteLine();
        }
        public static void cotthuj(int[,] a, int cot)
        {
            if (cot < 0 || cot > a.GetLength(1))
            {
                Console.WriteLine("Cot khong hop le.");
            }
            int min = 0;
            Console.WriteLine($"Cot thu {cot}: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i, cot]}" + "\t");
                min = a[i, cot];
            }
            for (int i = 0; i < a.GetLength(0); i++)
                if (a[i, cot] < min) min = a[i, cot];
            Console.WriteLine();
            Console.WriteLine($"Min value cua cot {cot} la: {min}");
            Console.WriteLine();
        }

        public static void tim(int[,] a, int val)
        {

            int dem = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (val == a[i, j])
                    {
                        Console.WriteLine($"{val} xuat hien o [{i},{j}].");
                        dem++;
                    }
                }
            }
            if (dem == 0) Console.WriteLine($"{val} khong nam trong mang.");
        }

        public static void chuyenvi(int[,] a, int d, int c)
        {
            int[,] b;
            b = new int[c, d];
            Console.WriteLine("Ma tran chuyen vi la: ");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    b[i, j] = a[j, i];
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void matranvuong(int[,] a, int n)
        {
            Console.WriteLine("Duong cheo chinh cua ma tran vuong la: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i, i] + "\t");
            Console.WriteLine();
            Console.WriteLine("Duong cheo phu cua ma tran vuong la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i, n - i - 1] + "\t");
            }
        }
        public static void Main7()
        {
            int[,] a;
            Console.Write("Nhap so dong: ");
            int d=int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int c=int.Parse(Console.ReadLine());
            //tao mang 2 chieu
            a = new int[d, c];
            //nhapmang(a, d, c);
            nhaprand(a, d, c);
            xuatmang(a);
            Console.WriteLine();

            //Tim gia tri da nhap trong mang
            Console.Write("Nhap 1 so: ");
            int val=int.Parse(Console.ReadLine());
            tim(a, val);
            Console.WriteLine();

            //tim max
            int ma=max(a);
            Console.WriteLine($"So lon nhat trong mang la: {ma}");
            Console.WriteLine();

            //in dong thu i
            Console.Write("Nhap dong muon in: ");
            int dong=int.Parse(Console.ReadLine());
            dongthui(a, dong);


            //in cot thu j
            Console.Write("Nhap cot muon in: ");
            int cot = int.Parse(Console.ReadLine());    
            cotthuj(a, cot);

            //chuyenvimatran
            chuyenvi(a, d, c);

            //in duong cheo chinh, duong cheo phu
            int[,] v;
            Console.Write("Nhap bac cua ma tran vuong: ");
            int n = int.Parse(Console.ReadLine());
            v = new int[n, n];
            nhaprand(v, n, n);
            xuatmang(v);
            matranvuong(v, n);
            Console.ReadKey();

        }
    }
}
