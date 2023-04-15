using System;
namespace project
{
    class test1
    {
        public static void Main()
        {
            int X=Convert.ToInt32(Console.ReadLine());
            int Y=Convert.ToInt32(Console.ReadLine());
            double show= Calc(X, Y);
            if (show>=10)
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("failed");
            }
        }
        private static double Calc (int X, int Y)
        {
            double result = X * 0.35 + Y * 0.65;
            return result;
        }
    }
}