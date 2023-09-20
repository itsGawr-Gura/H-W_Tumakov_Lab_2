using System;

namespace H_W_Tumakov_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 2.1  - Приветствие
            Console.WriteLine("Д/З 2.1  - Приветствие");
            Console.Write("Введите ваше имя - ");
            string name = Console.ReadLine();
            Console.WriteLine($"Приветствую вас {name}");
            // Задание 2.2 - Деление двух целых чисел
            Console.WriteLine("Д/З 2.2 - Деление двух целых чисел");
            Console.Write("Введите числитель - ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель - ");
            double den = Convert.ToInt32(Console.ReadLine());
            if (den == 0)
            {
                Console.WriteLine("Деление на ноль невозможно, измените знаменатель");
                Console.Write("Введите знаменатель - ");
                double den0 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num / den0);
            }
            else
            {
                Console.WriteLine(num / den);
            }

            // Д/З 2.1 - Буква следующая за данной
            Console.WriteLine("Задание 2.1 - Буква следующая за данной");
            Console.Write("Введите строчную букву - ");
            string bukva = Console.ReadLine();
            if (bukva == "z")
                Console.WriteLine('a');
            else if (bukva == "я")
                Console.WriteLine('а');
            else
            foreach (char number in bukva)
                Console.WriteLine(Convert.ToChar(number + 1));
            // Д/З 2.2 - Решить квадратное уравнение
            Console.WriteLine("Задание 2.2 - Решить квадратное уравнение");
            int a;
            Console.Write("Введите коэфициэнт a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэфициэнт b= ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэфициэнт c= ");
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            int deskrim;
            deskrim = b * b - 4 * a * c;
            if (deskrim > 0)
            {
                int x1;
                int x2;
                double sqrtdeskrim = Math.Sqrt(deskrim);
                x1 = (int)((-b + sqrtdeskrim) / 2 * a);
                x2 = (int)((-b - sqrtdeskrim) / 2 * a);
                Console.WriteLine("Ваши корни = " + $"{x1}, {x2}");
            }
            else if (deskrim == 0)
            {
                int x1;
                x1 = -b / 2 * a;
                Console.WriteLine("Ваш корень = " + x1);
            }
            else
            {
                Console.WriteLine("Нет решений");
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
