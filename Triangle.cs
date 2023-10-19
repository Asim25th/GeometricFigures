namespace geometric_figures
{
    class Triangle // треугольник
    {
        private double a;
        private double b;
        private double c;

        public void input()
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
                Console.WriteLine("\nОШИБКА: Длина не может быть меньше или равной нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.input();
            }

            else
            {
                if (a + b > c && a + c > b && b + c > a) // проверка треугольника на существование
                {
                    this.area();
                }

                else
                {
                    Console.WriteLine("\nОШИБКА: Такой треугольник не существует. Нажмите Enter и попробуйте снова.");
                    Console.ReadKey();
                    Console.Clear();
                    this.input();
                }
            }
        }

        private void area()
        {
            double p = (a + b + c) / 2; // полупериметр
            double area = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
            perimeter(area);        
        }

        private void perimeter(double arae)
        {
            double perimeter = Math.Round(a + b + c, 3);
            output(arae, perimeter);
        }

        private void output(double area, double perimeter)
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

            Console.WriteLine($"\nПлощадь треугольника: {area}");
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
