using System;

namespace HomeWork_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 Condition with three points
            int a, b, max;
            Console.WriteLine("Type two digits");
            Console.WriteLine("Type the first digit");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second digit");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
               max = a;
               Console.WriteLine("Max is " + max);
            }
            else
            {
             if (a < b)
                {
                    max = b;
                    Console.WriteLine("Max is " + max);
                }
             else
                {
                    Console.WriteLine("Digits are equal");
                }
            }
            #endregion
            
        }
    }
}
