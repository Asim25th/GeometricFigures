﻿namespace geometric_figures
{
    class Triangle // треугольник
    {
        private double a;
        private double b;
        private double c;

        public void area()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА ТРЕУГОЛЬНИКА");
            Console.Write("\nВведите длину первой стороны треугольника: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите длину второй стороны треугольника: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите длину третьей стороны треугольника: ");
            c = Convert.ToSingle(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("ОШИБКА: Длина не может быть меньше или равной нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.area();
            }

            else
            {
                if (a + b > c && a + c > b && b + c > a) // проверка треугольника на существование
                {
                    if (a != b && a != c && b != c) // разносторонний ли треугольник
                    {
                        Console.WriteLine("\nВид треугольника по сторонам: разносторонний");
                    }
                    else if (a == b && a == c && b == c) // равносторонний ли треугольник
                    {
                        Console.WriteLine("\nВид треугольника по сторонам: равносторонний");
                    }
                    else if (a == b || a == c || b == c) // равнобедренный ли треугольник
                    {
                        Console.WriteLine("\nВид треугольника по сторонам: равнобедренный");
                    }

                    double p = (a + b + c) / 2; // полупериметр
                    double area = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
                    Console.WriteLine($"\nПлощадь треугольника: {area}");
                }

                else
                {
                    Console.WriteLine("\nОШИБКА: Такой треугольник не существует. Нажмите Enter и попробуйте снова.");
                    Console.ReadKey();
                    Console.Clear();
                    this.area();
                }
            }
        }

        public void perimeter()
        {
            double perimeter = Math.Round(a + b + c, 3);
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}