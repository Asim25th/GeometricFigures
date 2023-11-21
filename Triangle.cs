namespace geometric_figures
{
    class Triangle : Figures // треугольник
    {
        //private double a; // первая сторона треугольника
        protected double b; // вторая сторая сторона треугольника
        private double c; // третья сторона треугольника

        public Triangle(double a, double b, double area, double perimeter) : base(a, area, perimeter) { this.b = b; } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА ТРЕУГОЛЬНИКА");
            Console.Write("\nВведите длину первой стороны треугольника: ");
            a = Convert.ToSingle(Console.ReadLine());
            if (a <= 0) { a = Checking(a); } // вызов проверки введенного значения
            Console.Write("Введите длину второй стороны треугольника: ");
            b = Convert.ToSingle(Console.ReadLine());
            if (b <= 0) { b = Checking(b); }
            Console.Write("Введите длину третьей стороны треугольника: ");
            c = Convert.ToSingle(Console.ReadLine());
            if (c <= 0) { c = Checking(c); }

            if (a + b > c && a + c > b && b + c > a) { this.Area(); } // проверка треугольника на существование
            else
            {
                Console.WriteLine("\nОШИБКА: Такой треугольник не существует. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.Input();
            }
        }

        private void Area() // площадь
        {
            double p = (a + b + c) / 2; // полупериметр
            double area = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
            Perimeter(area);        
        }

        private void Perimeter(double area) // периметр
        {
            double perimeter = Math.Round(a + b + c, 3);
            Output(area, perimeter);
        }

        private new void Output(double area, double perimeter) // вывод измненный через override
        {
            if (a != b && a != c && b != c) // разносторонний ли треугольник
            {
                Console.WriteLine("\nВид треугольника по сторонам: разносторонний");
            }
            else if (a == b && a == c && b == c) // равносторонний ли треугольник
            {
                Console.WriteLine("\nВид треугольника по сторонам: равносторонний");
            }
            else if (a == b || a == c || b == c) // равнобедренный ли треугольник
            {
                Console.WriteLine("\nВид треугольника по сторонам: равнобедренный");
            }
            base.Output(area, perimeter); // вызывается из род. класса по умолчанию
        }
    }
}