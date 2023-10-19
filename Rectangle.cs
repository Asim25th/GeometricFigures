namespace geometric_figures
{
    class Rectangle // прямоугольник
    {
        private double a;
        private double b;

        public void input() 
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА ПРЯМОУГОЛЬНИКА");
            Console.Write("\nВведите длину первой стороны прямоугольника: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите длину второй стороны прямоугольника: ");
            b = Convert.ToSingle(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("\nОШИБКА: Длина не может быть меньше или равной нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.input();
            }

            else
            {
                area();
            }
        }

        private void area()
        {           
            double area = Math.Round(a * b, 3);
            perimeter(area);
        }

        private void perimeter(double area)
        {
            double perimeter = Math.Round((a + b) * 2, 3);
            output(area, perimeter);
        }

        private void output(double area, double perimeter)
        {
            Console.WriteLine($"\nПлощадь прямоугольника: {area}");
            Console.WriteLine($"Периметр прямоугольника: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
