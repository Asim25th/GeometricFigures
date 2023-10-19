namespace geometric_figures
{
    class Square // квадрат
    {
        private double a; // сторона квадрата

        public void input()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КВАДРАТА");
            Console.Write("\nВведите длину стороны квадрата: ");
            a = Convert.ToSingle(Console.ReadLine());

            if (a <= 0)
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
            double area = Math.Round(Math.Pow(a, 2), 3);
            perimeter(area);
        }

        private void perimeter(double area)
        {
            double perimeter = Math.Round(4 * a, 3);
            output(area, perimeter);
        }

        private void output(double area, double perimeter)
        {
            Console.WriteLine($"\nПлощадь квадрата: {area}");
            Console.WriteLine($"Периметр квадрата: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}
