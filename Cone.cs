namespace geometric_figures
{
    class Cone : Circle // конус
    {
        //private double R; // радиус (основания) конуса
        private double l; // образующая конуса (отрезок от вершины конуса до границы его основания)
        private double H; // высота конуса (отрезок от вершины конуса до центра его основания)

        public Cone(double a, double R, double area, double perimeter) : base(a, R, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА КОНУСА");
            Console.Write("\nВведите радиус (основания) конуса: ");
            R = Convert.ToSingle(Console.ReadLine());
            if (R <= 0) { R = Checking(R); } // вызов проверки введенного значения
            Console.Write("Введите образующую конуса (отрезок от вершины конуса до границы его основания): ");
            l = Convert.ToSingle(Console.ReadLine());
            if (l <= 0) { l = Checking(l); }
            Console.Write("Введите высоту конуса (отрезок от вершины конуса до центра его основания): ");
            H = Convert.ToSingle(Console.ReadLine());
            if (H <= 0) { H = Checking(H); }
            Area();                    
        }

        private void Area() // площадь
        {
            area = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
            Perimeter(area);
        }

        private void Perimeter(double area) // периметр
        {
            perimeter = Math.Round(R * Math.PI + l * 2, 3);
            Volume(area, perimeter);
        }

        private void Volume(double area, double perimeter) // объем
        {
            double volume = Math.Round((Math.PI * Math.Pow(R, 2) * H) / 3, 3);
            Output(area, perimeter, volume);
        }

        private void Output(double area, double perimeter, double volume) // вывод
        {
            Console.Write($"\nОбъем фигуры: {volume}");
            base.Output(area, perimeter); // вызывается из род. класса по умолчанию
        }
    }
}