using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_02
    {
        public static void Main2()
        {
            question_01();
            question_02();
            question_03();
            Console.ReadKey();
        }

        public static void question_01()
        {
            //surface and volume 
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double s = 4 * Math.PI * r * r;
            double v = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"Dien tich mat cau la: {s}");
            Console.WriteLine($"The tich hinh cau la: {v}");
        }

        public static void question_02()
        {
            //tinh tong, hieu, tich, thuong, so du
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int cong = a + b;
            int tru = a - b;
            int nhan = a * b;
            int chia = a / b;
            int du = a % b;
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} x {b} = {nhan}");
            Console.WriteLine($"{a} / {b} = {chia}");
            Console.WriteLine($"{a} mod {b} = {du}");
        }

        public static void question_03()
        {
            //chuyen do C -> do K, do F
            Console.Write("Nhap do C: ");
            int c = int.Parse(Console.ReadLine());
            int k = c + 273;
            double f = c * 18 / 10 + 32;
            Console.WriteLine($"{c} do C = {k} do K");
            Console.WriteLine($"{c} do C = {f} do F");
        }
    }
}
