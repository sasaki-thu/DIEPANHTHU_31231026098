using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_01
    {
        public static void Main1()
        { question_01();
          question_02();
          question_03();
          question_04();
          question_05();
          question_06();
          question_07();
          question_08();
          question_09();
          question_10();
            Console.ReadKey();
        }
        public static void question_01()
        {
            //cộng 2 số
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
        }
        public static void question_02()
        {
            //đổi chỗ 2 giá trị
            Console.Write("Nhap gia tri x: ");
            string x = Console.ReadLine();
            Console.Write("Nhap gia tri y: ");
            string y = Console.ReadLine();
            string z;
            z = x; x = y; y = z;
            Console.WriteLine($"Gia tri x sau khi swap la: {x}");
            Console.WriteLine($"Gia tri y sau khi swap la: {y}");
        }
        public static void question_03()
        {
            //nhân 2 số
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"{a}*{b}={c}");
        }
        public static void question_04()
        {
            //feet -&gt; meter
            Console.Write("Nhap Feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet / 3.281;
            Console.WriteLine($"Chuyen Feet sang Meter: {meter}");
        }
        public static void question_05()
        {
            //độ c sang độ f và ngược lại
            Console.Write("Nhap do C: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine($"{c}°C se bang {f}°F");
            Console.Write("Nhap do F: ");
            double F = double.Parse(Console.ReadLine());
            double C = (F - 32) * 5 / 9;
            Console.WriteLine($"{F}°F se bang {C}°C");
        }
        public static void question_06()
        {
            //kích thước của kiểu dữ liệu
            Console.WriteLine("Kich thuoc cua kieu du lieu int la: " + sizeof(int));
            Console.WriteLine("Kich thuoc cua kieu du lieu char la: " + sizeof(char));
            Console.WriteLine("Kich thuoc cua kieu du lieu double la: " + sizeof(double));
            Console.WriteLine("Kich thuoc cua kieu du lieu float la: " + sizeof(float));
        }
        public static void question_07()
        {
            //character to asciii
            Console.Write("Nhap gi do di: ");
            string x = Console.ReadLine();
            Console.Write($"{x} in ASCII = ");
            foreach (char c in x)
            { Console.Write((int)c + " "); }
            //char x = 'a';
            //int num = x;
            //Console.WriteLine($"{x} in ASCII = {num}");
            Console.WriteLine();
        }
        public static void question_08()
        {
            //tinh dien tich hinh tron
            Console.Write("Nhap ban kinh hinh tron: ");
            float x = float.Parse(Console.ReadLine());
            double S = x * x * 3.14;
            Console.WriteLine($"Dien tich hinh tron la: {S}");
        }
        public static void question_09()
        {
            //tinh dien tich hinh vuong
            Console.Write("Nhap canh hinh vuong: ");
            float x = float.Parse(Console.ReadLine());
            double S = x * x;
            Console.WriteLine($"Dien tich hinh vuong la: {S}");
        }
        public static void question_10()
        {
            //days to years, weeks and days
            Console.Write("Nhap so ngay: ");
            int d = int.Parse(Console.ReadLine());
            int y = d / 365;
            int w = (d - y * 365) / 7;
            int d2 = d - y * 365 - w * 7;
            Console.WriteLine($"{d} days = {y} years, {w} weeks, {d2} days");
        }
    }
}
