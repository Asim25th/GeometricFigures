namespace geometric_figures
{
    class PyramidQuadrilateral : Rectangle // четырехугольная пирамида
    {
        private double H; // высота конуса (отрезок от вершины конуса до центра его основания)
        //private double a; // ребро основания пирамиды
        //private double b; // боковое ребро пирамиды

        public PyramidQuadrilateral(double a, double b, double area, double perimeter) : base(a, b, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА ЧЕТЫРЕХУГОЛЬНОЙ ПИРАМИДЫ");
            Console.Write("\nВведите ребро основания пирамиды: ");
            a = Convert.ToSingle(Console.ReadLine());
            if (a <= 0) { a = Checking(a); } // вызов проверки введенного значения
            Console.Write("Введите боковое ребро пирамиды: ");
            b = Convert.ToSingle(Console.ReadLine());
            if (b <= 0) { b = Checking(b); }
            Console.Write("Введите высоту пирамиды (отрезок от вершины пирамиды до центра его основания): ");
            H = Convert.ToSingle(Console.ReadLine());
            if (H <= 0) { H = Checking(H); }
            Area();
        }

        private void Area() // площадь
        {
            area = Math.Round(Math.Pow(a, 2) + 2 * a * Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4), 3);
            Perimeter(area);
        }

        private void Perimeter(double area) // периметр
        {
            perimeter = Math.Round(4 * a + 4 * (a + b + b), 3);
            Volume(area, perimeter);
        }

        private void Volume(double area, double perimeter) // объем
        {
            double volume = Math.Round((Math.Pow(a, 2) * H) / 3, 3);
            Output(area, perimeter, volume);
        }

        private void Output(double area, double perimeter, double volume) // вывод
        {
            Console.Write($"\nОбъем фигуры: {volume}");
            base.Output(area, perimeter); // вызывается из род. класса по умолчанию
        }
    }
}