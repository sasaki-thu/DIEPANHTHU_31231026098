using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_06
    {
        public static void add(ref int[] a)
        {
            Console.WriteLine("Sau khi cong 2: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i] + 2}");
            }
        }
        public static decimal average(ref int[] a, ref int n)
        {
            int tb = 0;
            for (int i = 0; i < a.Length; i++)
                tb = tb + a[i];
            return (decimal)tb / n;
        }
        public static void value(ref int[] a, ref int val)
        {

            for (int i = 0; i < a.Length; i++)
                if (a[i] == val)
                {
                    Console.WriteLine($"So {val} co nam trong mang.");
                    Console.WriteLine($"So {val} nam o vi tri [{i}].");
                }
            Console.WriteLine();
            Console.WriteLine($"Mang sau khi xoa so {val} la: ");
            for (int i = 0; i < a.Length; i++)
                if (a[i] != val) Console.Write(a[i] + "\t");
            Console.WriteLine();
        }
        public static int max(ref int[] a)
        {
            int ma = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > ma) ma = a[i];
            return ma;
        }
        public static int min(ref int[] a)
        {
            int mi = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] < mi) mi = a[i];
            return mi;
        }
        public static void reverse(ref int[] a)
        {
            //int temp = a[a.Length-1];
            Array.Reverse(a);
            Console.WriteLine("Dao nguoc mang: ");
            for (int i = 0; a.Length > i; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }

        public static void laplai(ref int[] a)
        {
            Array.Sort(a);
            int temp = 0;
            Console.WriteLine("Cac phan tu bi lap lai la: ");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] != temp) if (a[j] == a[i])
                        {
                            Console.Write(a[i] + "\t");
                        }
                    break;
                }
                temp = a[i];
            }
            Console.WriteLine();
        }
        public static void xoalaplai(ref int[] a)
        {
            int[] xll = a.Distinct().ToArray(); //ham co san xoa phan tu lap lai
            Console.WriteLine("Mang sau khi xoa cac phan tu lap: ");
            for (int i = 0; i < xll.Length; i++)
                Console.Write(xll[i] + "\t");
        }
        public static void Main6()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                //a[i] = int.Parse(Console.ReadLine());
                a[i] = rand.Next(1, 10);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();

            //them 2 vao moi ptu
            add(ref a);
            Console.WriteLine();

            //1. tinh tbc cac ptu
            decimal tb = average(ref a, ref n);
            Console.WriteLine($"Trung binh cac phan tu: {tb}");
            Console.WriteLine();

            //2. ki tu nhap vao co trong mang ko?
            //3. ki tu nhap vao o vi tri nao?
            //4. bo ki tu nhap vao khoi mang
            Console.Write("Nhap 1 so di: ");
            int val = int.Parse(Console.ReadLine());
            value(ref a, ref val);
            Console.WriteLine();

            //5. min, max cua mang
            int ma = max(ref a);
            int mi = min(ref a);
            Console.WriteLine($"So lon nhat cua mang la: {ma}");
            Console.WriteLine($"So nho nhat cua mang la: {mi}");
            Console.WriteLine();

            //6. reverse mang
            reverse(ref a);
            Console.WriteLine();

            //7. tim so lap lai
            laplai(ref a);
            Console.WriteLine();

            //8. xoa so lap lai
            xoalaplai(ref a);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
