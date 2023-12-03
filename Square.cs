namespace GeometricFigures
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
            if (a <= 0) { a = Checking(a); } // вызов проверки введенного значения
            Area();
            Perimeter();
            Output(area, perimeter); // вызывается из род. класса по умолчанию
        }

        private void Area() // площадь
        {
            area = Math.Round(Math.Pow(a, 2), 3);
        }

        private void Perimeter() // периметр
        {
            perimeter = Math.Round(4 * a, 3);
        }
    }
}