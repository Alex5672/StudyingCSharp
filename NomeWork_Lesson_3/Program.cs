using System;

namespace NomeWork_Lesson_3
{
    class Program
    {
        #region Работа со структурой
        struct Person //После слова struct идет название структуры и далее в фигурных скобках размещаются элементы структуры - поля, методы и т.д.
        {
            public string Name;
            public int Age;
            public void Print()
            {
                Console.WriteLine($"Name: {Name} Age: {Age}");
            }
            //определены две переменные - name и age для хранения соответственно имени и возраста человека
            //и метод Print для вывода информации о человеке на консоль.
        }
        #endregion
        static void Main(string[] args)
        {
            Person Tom = new();
            Tom.Name = "Tom"; // изменяем значение по умолчанию в поле name
            Tom.Age = 33; // изменяем значение по умолчанию в поле age
            Tom.Print(); // Имя: Tom  Возраст: 33

            #region Использование класса Random для генерации случайных чисел
            Random rnd = new Random(); //Создание объекта для генерации чисел
            int value = rnd.Next(); //Получить очередное (в данном случае - первое) случайное число
            int value1 = rnd.Next();
            int value2 = rnd.Next(1, 11); //Получить случайное число (в диапазоне от 1 до 11)
            Console.WriteLine(value); //Вывод полученного числа в консоль
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            #endregion
        }
    }
}
