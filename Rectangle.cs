namespace GeometricFigures
{
    class Rectangle : Figures // прямоугольник
    {
        //private double a; // первая сторона прямоугольника
        protected double b; // вторая сторона прямоугольника

        public Rectangle(double a, double b, double area, double perimeter) : base(a, area, perimeter) { this.b = b; } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА ПРЯМОУГОЛЬНИКА");
            Console.Write("\nВведите длину первой стороны прямоугольника: ");
            a = Convert.ToSingle(Console.ReadLine());
            if (a <= 0) { a = Checking(a); } // вызов проверки введенного значения
            Console.Write("Введите длину второй стороны прямоугольника: ");
            b = Convert.ToSingle(Console.ReadLine());
            if (b <= 0) { b = Checking(b); }
            Area();
            Perimeter();
            Output(area, perimeter); // вызывается из род. класса по умолчанию
        }

        private void Area() // площадь
        {           
            area = Math.Round(a * b, 3);
        }

        private void Perimeter() // периметр
        {
            perimeter = Math.Round((a + b) * 2, 3);
        }
    }
}