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
            if (a <= 0) { a = Checking(a); } // вызов проверки введенного значения
            Console.Write("Введите длину второй стороны прямоугольника: ");
            b = Convert.ToSingle(Console.ReadLine());
            if (b <= 0) { b = Checking(b); }
            Area();
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
    }
}