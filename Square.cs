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
            if (a <= 0) { a = checking(a); } // вызов проверки введенного значения
            Area();
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
    }
}