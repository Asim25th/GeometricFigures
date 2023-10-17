namespace geometric_figures
{
    class Rectangle // прямоугольник
    {
        private double a;
        private double b;

        public void area()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА ПРЯМОУГОЛЬНИКА");
            Console.Write("\nВведите длину первой стороны прямоугольника: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите длину второй стороны прямоугольника: ");
            b = Convert.ToSingle(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("ОШИБКА: Длина не может быть меньше или равной нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.area();
            }

            else
            {
                double area = Math.Round(a * b, 3);
                Console.WriteLine($"\nПлощадь прямоугольника: {area}");
            }

        }

        public void perimeter()
        {
            double perimeter = Math.Round((a + b) * 2, 3);
            Console.WriteLine($"Периметр прямоугольника: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
