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

            #region Task 2 Тернарный оператор "?"
            int num;
            Console.WriteLine("Type digit ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digit " + num + ((num % 2 == 0) ? " even number" : " odd number"));
            #endregion
            
            #region Task 3 Оператор выбора "Switch"
            // Оператор switch предназначен для разветвления процесса выполнения программы
            int month;
            Console.WriteLine("Type number of month");
            month = Convert.ToInt32(Console.ReadLine());
            string s;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    s = "It is Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    s = "It is Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    s = "It is Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    s = "It is Autumn";
                    break;
                default:
                    s = "Nothing";
                    break;
            }
            Console.WriteLine(s);
            #endregion

            #region Цикл While
            int WhileDigit;
            Console.WriteLine("Type a digit with five symbols");
            WhileDigit = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (WhileDigit != 0)
            {
                count++;
                WhileDigit = WhileDigit / 10; //деление на 10 позволяет убрать один знак
            }
            Console.WriteLine("Amount of symbols " + count);
            #endregion
            #region Практика использования вложенного цикла
            /*for (int ii = 0; ii <= 10; ii++)
                for (int jj = 0; jj <= 5; jj++)
                {
                    Console.SetCursorPosition(ii, jj);
                    Console.Write("***");
                    System.Threading.Thread.Sleep(20);
                    Console.Title = "ii=" + ii + " jj=" + jj;
                }
            Console.ReadKey();*/
            #endregion
            #region Структура для работы со временем DateTime
            /*DateTime start = DateTime.Now;
            System.Threading.Thread.Sleep(200);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);*/
            #endregion

        }
    }
}