using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEPANHTHU_31231026098
{
    internal class Session_03
    {
        public static void Main3()
        {
            //question_02();
            //question_03();
            question_05();
            Console.ReadKey();
        }
        public static void question_02()
        {
            //x=y^2+2y+1
            Console.Write("Nhap y (tu -5 den 5): ");
            int y = int.Parse(Console.ReadLine());
            while ((y < -5) || (y > 5))
            {
                Console.Write("Nhap lai y (tu -5 den 5): ");
                y = int.Parse(Console.ReadLine());
            }
            int x = y * y + 2 * y + 1;
            Console.Write($"x = y^2 + 2y + 1 = ({y})^2 + 2*({y}) + 1 = {x}");
        }
        public static void question_03()
        {
            //distance (km), time (h,m,s) -> speed in km/h, miles/h
            Console.Write("Nhap distance: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Nhap gio: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            int s = int.Parse(Console.ReadLine());
            double kmh = d / (h + m / 60f + s / 3600f);
            double milesh = kmh / 1.609344;
            Console.WriteLine($"Toc do km/h la: {kmh}");
            Console.Write($"Toc do miles/h la: {milesh}");
        }
        public static void question_05()
        {
            Console.Write("Nhap 1 ki tu: ");
            char x = char.Parse(Console.ReadLine());
            if (x == 'u' || x == 'e' || x == 'o' || x == 'a' || x == 'i'
                || x == 'U' || x == 'E' || x == 'O' || x == 'A' || x == 'I')
            { Console.WriteLine("Ky tu la ky tu nguyen am."); }
            else if (x >= '0' && x <= '9')
            { Console.WriteLine("Ky tu la ky tu so."); }
            else
            {
                Console.WriteLine("Ky tu la ky tu khac.");
            }

        }
    }
}
