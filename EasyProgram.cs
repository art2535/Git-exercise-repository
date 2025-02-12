// Код простой программы на языке программирования С#

using System;

namespace GitExerciseRepository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Спасибо, {name}! Ваш возраст - {age} лет.");
        }
    }
}
