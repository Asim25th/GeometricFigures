namespace geometric_figures
{
    class Square : Figures // квадрат
    {
        //private double a; // сторона квадрата

        public Square(double a, double area, double perimeter) : base(a, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КВАДРАТА");
            Console.Write("\nВведите длину стороны квадрата: ");
            a = Convert.ToSingle(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("\nОШИБКА: Длина не может быть меньше или равной нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.Input();
            }

            else
            {
                Area();
            }
        }
        
        private void Area() // площадь
        {
            area = Math.Round(Math.Pow(a, 2), 3);
            Perimeter(area);
        }

        private void Perimeter(double area) // периметр
        {
            perimeter = Math.Round(4 * a, 3);
            Output(area, perimeter); // вызывается из род. класса по умолчанию
        }

        //private void Output(double area, double perimeter) // вывод
        //{
        //    Console.WriteLine($"\nПлощадь квадрата: {area}");
        //    Console.WriteLine($"Периметр квадрата: {perimeter}");
        //    Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
        //    Console.ReadKey();
        //}
    }
}