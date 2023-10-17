namespace geometric_figures
{
    class Circle // круг
    {
        private double r;

        public void area()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КРУГА");
            Console.Write("\nВведите радиус круга: ");
            r = Convert.ToSingle(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("ОШИБКА: Радиус не может быть меньше или равным нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.area();
            }

            else
            {
                double area = Math.Round(Math.PI + Math.Pow(r, 2), 3);
                Console.WriteLine($"\nПлощадь круга: {area}");
            }
        }

        public void perimeter()
        {
            double perimeter = Math.Round(2 * Math.PI * r, 3);
            Console.WriteLine($"Периметр круга: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
