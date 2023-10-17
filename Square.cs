namespace geometric_figures
{
    class Square // квадрат
    {
        private double a; // сторона квадрата

        public void area()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КВАДРАТА");
            Console.Write("\nВведите длину стороны квадрата: ");
            a = Convert.ToSingle(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("ОШИБКА: Длина не может быть меньше или равной нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.area();
            }

            else
            {
                double area = Math.Round(Math.Pow(a, 2), 3);
                Console.WriteLine($"\nПлощадь квадрата: {area}");
            }
        }

        public void perimeter()
        {
            double perimeter = Math.Round(4 * a, 3);
            Console.WriteLine($"Периметр квадрата: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
