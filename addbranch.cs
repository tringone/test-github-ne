using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        //tao mot ham tu dinh nghia nhan hai tham so
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void Main()
        {
            Console.Write("\nTao ham tu dinh nghia de tinh tong hai so trong C#:\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Nhap so hang thu nhat: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so hang thu hai: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            //goi ham tu dinh nghia
            Console.WriteLine("\nTong hai so: {0} \n", Sum(n1, n2));

            Console.ReadKey();
        }   
    }
}