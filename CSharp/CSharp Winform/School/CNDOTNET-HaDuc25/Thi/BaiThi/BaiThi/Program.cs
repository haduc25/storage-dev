using System;

namespace BaiThi
{
    class Program
    {
        static void Main(string[] args)
        {        
            int n = 0;
           
            do
            {
                Console.Write("Nhap so nguyen bat ky: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 2 || n > 100)
                {
                    Console.WriteLine("So nguyen phai >= 2 va <= 100, vui long nhap lai !");
                }
                else
                {
                    if (isSoNguyenTo(n))
                    {
                        Console.WriteLine(n + " la so nguyen to");
                    }
                    else { Console.WriteLine(n + " khong phai la so nguyen to"); }

                    Console.WriteLine("Cac snt nho hon " + n);
                    for (int num = 1; num < n; ++num)
                    {
                        int count = 0;
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                count++;
                            }
                        }
                        if (count == 0 && num > 1)
                        {
                            Console.WriteLine("\t" + num);
                        }
                    }

                    break;

                }
            } while (n <= 2 || n>=100);
            

            //so nguyen to
            static Boolean isSoNguyenTo(int length)
            {
                bool check = true;
                for (int i = 2; i < length; i++)
                    if (length % i == 0) check = false;
                if (check) return true;
                else return false;
            }

            Console.ReadKey();
        }
    }
}
