using System;
namespace PHUONGTHUC
{
    class ChuongTrinhChuyenDoiNhietDo
    {
        static void Main(string[] args)
        {
            int luachon = 0;
            do
            {
                Console.WriteLine("1. Fahrenheit to Celsius\n2. Celsius to Fahrenheit\n0. Exit");
                luachon = Convert.ToInt16(Console.ReadLine());
                if(luachon==1)
                {
                    Console.WriteLine("Nhap do F:");
                    double doF = Convert.ToDouble(Console.ReadLine());
                    double doC = fahrenheitToCelsius(doF);
                    Console.WriteLine($"{doF} do F bang {doC} do C");
                }
                else if (luachon==2)
                {
                    Console.WriteLine("Nhap do C:");
                    double doC = Convert.ToDouble(Console.ReadLine());
                    double doF = celsiusToFahrenheit(doC);
                    Console.WriteLine($"{doC} do C bang {doF} do F");
                }
                else if (luachon>2||luachon<0)
                {
                    Console.WriteLine("Lua chon khong hop le");
                }
            }
            while (luachon!=0);

        }
        public static double celsiusToFahrenheit(double celsius)
        {
            double doF = (celsius*9/5.0)+32;
            return doF;
        }
        public static double fahrenheitToCelsius(double fahrenheit)
        {
            double doC = (5.0/9) * (fahrenheit - 32);
            return doC;
        }
    }
}