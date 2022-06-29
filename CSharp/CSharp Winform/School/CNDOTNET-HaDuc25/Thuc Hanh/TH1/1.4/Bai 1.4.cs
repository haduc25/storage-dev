using System;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 4");

            int numb;
            Console.Write("Nhap 1 so: ");
            numb = Convert.ToInt32(Console.ReadLine());

            if (kt(numb))
                Console.WriteLine("{0} La so chinh phuong", numb);
            else
                Console.WriteLine("{0} Khong phai so chinh phuong", numb);
            Console.ReadKey();
        }

        static bool kt(int numb)
        {
            int i = 0;
           while(i* i <= numb)
            {
                if(i* i == numb) 
                {
                    return true;
                }
                ++i;
            }
            return false;
        }
    }
}