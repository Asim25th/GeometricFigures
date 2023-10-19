namespace geometric_figures
{
    class Circle // круг
    {
        private double r;

        public void input()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КРУГА");
            Console.Write("\nВведите радиус круга: ");
            r = Convert.ToSingle(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("\nОШИБКА: Радиус не может быть меньше или равным нулю. Нажмите Enter и попробуйте снова.");
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
            double area = Math.Round(Math.PI + Math.Pow(r, 2), 3);
            perimeter(area);
        }

        private void perimeter(double area)
        {
            double perimeter = Math.Round(2 * Math.PI * r, 3);
            output(area, perimeter);
        }

        private void output(double area, double perimeter)
        {
            Console.WriteLine($"\nПлощадь круга: {area}");
            Console.WriteLine($"Периметр круга: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
