using System;

namespace Lesson2_Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Аганесова Инна Львовна";
            int age = 42;
            string userEmail = "inna@inbox.ru";
            int mathPoint = 63;
            int programmingPoint = 100;
            int physicsPoint = 93;
            int summPoint = mathPoint + programmingPoint + physicsPoint;
            float averagePoint = (summPoint / 3f);

            Console.WriteLine($"" +
                $"ФИО: {fullName} " +
                $"\nВозраст: {age} " +
                $"\nАдрес эл.почты: {userEmail} " +
                $"\nМатематика баллы {mathPoint} " +
                $"\nПрограммирование баллы {programmingPoint} " +
                $"\nФизика баллы {physicsPoint}" +
                $"\n\nдля продолжения нажмите любую клавишу");
            Console.ReadKey();

            Console.WriteLine($"\nСумма всех баллов: {summPoint} \nСредний балл: {averagePoint:0.00}");
            Console.ReadKey();
        }
    }
}
