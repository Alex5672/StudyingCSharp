using System;

namespace HomeWork_Lesson_1
{
    class Program
    {
        static double Operate_Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main()
        {
            #region Task 1 Questionnaire
            Console.WriteLine("Hello! We're going to full a questionnaire.");
            Console.WriteLine("Please, type your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please, type your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please, type your age");
            string age = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please, type your height in meters");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, type your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("--->" + name + " " + surname + " " + age + " " + height + " " + weight + "<---");
            Console.ReadLine();
            #endregion
            #region Task 2 Index mass of body
            double IMB = weight / (height * height);
            Console.WriteLine("Your IMB is " + IMB);
            #endregion
            #region Task 3 Count distance 
            /*(а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
            y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            используя спецификатор формата .2f(с двумя знаками после запятой))*/

            Console.WriteLine("Type - x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type - y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type - x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type - y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Distance between the points is " + "{0:F2}", distance);
            Console.ReadLine();

            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            Console.WriteLine("Сhecking working of the method " + "{0:F2}", Operate_Distance(x1, x2, y1, y2));
            #endregion
        }
    }
}
