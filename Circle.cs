namespace GeometricFigures
{
    class Circle : Figures // круг
    {
        protected double R; // радиус круга

        public Circle(double a, double R, double area, double perimeter) : base(a, area, perimeter) { this.R = R; } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КРУГА");
            Console.Write("\nВведите радиус круга: ");
            R = Convert.ToSingle(Console.ReadLine());
            if (R <= 0) { R = Checking(R); } // вызов проверки введенного значения
            Area();
            Perimeter();
            Output(area, perimeter); // вызывается из род. класса по умолчанию
        }

        protected double Area() // площадь; используется protected double для реализации наследования формулы в класс Конус
        {
            area = Math.Round(Math.PI * Math.Pow(R, 2), 3);
            return area;
        }

        protected double Perimeter() // периметр; используется protected double для реализации наследования формулы в класс Конус
        {
            perimeter = Math.Round(2 * Math.PI * R, 3);
            return perimeter;
        }
    }
}