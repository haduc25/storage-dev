using System;

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 5");

            int dog, chicken;

            for(dog = 1; dog < 36; dog++)
            {
                for(chicken = 1; chicken < 36; chicken++)
                {
                    if((chicken+dog == 36) && (chicken*2+dog*4 == 100))
                    {
                        Console.WriteLine("So con ga: " + chicken);
                        Console.WriteLine("So con cho: " + dog);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}