namespace geometric_figures
{
    class Rectangle : Figures // прямоугольник
    {
        //private double a; // первая сторона прямоугольника
        private double b; // вторая сторона прямоугольника

        public Rectangle(double a, double area, double perimeter) : base(a, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
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
                this.Input();
            }

            else
            {
                Area();
            }
        }

        private void Area() // площадь
        {           
            area = Math.Round(a * b, 3);
            Perimeter(area);
        }

        private void Perimeter(double area) // периметр
        {
            perimeter = Math.Round((a + b) * 2, 3);
            Output(area, perimeter); // вызывается из род. класса по умолчанию
        }

        //private void Output(double area, double perimeter) // вывод
        //{
        //    Console.WriteLine($"\nПлощадь прямоугольника: {area}");
        //    Console.WriteLine($"Периметр прямоугольника: {perimeter}");
        //    Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
        //    Console.ReadKey();
        //}
    }
}