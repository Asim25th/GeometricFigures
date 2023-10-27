namespace geometric_figures
{
    class Pyramid : Figures // пирамида, конус
    {
        private double R; // радиус (основания) конуса
        private double l; // образующая конуса (отрезок от вершины конуса до границы его основания)
        private double H; // высота конуса (отрезок от вершины конуса до центра его основания)
        //private double a; // ребро основания пирамиды
        private double b; // боковое ребро пирамиды

        public Pyramid(double a, double area, double perimeter) : base(a, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА ПИРАМИДЫ И КОНУСА");
            Console.WriteLine("\n1. Конус\n2. Треугольная пирамида\n3. Четырехугольная пирамида");
            Console.WriteLine("\nДля возвращения в главное меню программы введите 0");
            Console.Write("\nВведите номер желаемой фигуры: ");
            int userChoice = (Convert.ToInt32(Console.ReadLine()));
            switch (userChoice)
            {
                case 0:
                    break; // возвращает пользователя обратно в главное меню
                case 1:
                    Console.Clear();
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
                    Area(userChoice);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА ТРЕУГОЛЬНОЙ ПИРАМИДЫ");
                    Console.Write("\nВведите ребро основания пирамиды: ");
                    a = Convert.ToSingle(Console.ReadLine());
                    if (a <= 0) { a = Checking(a); } // вызов проверки введенного значения
                    Console.Write("Введите боковое ребро пирамиды: ");
                    b = Convert.ToSingle(Console.ReadLine());
                    if (b <= 0) { b = Checking(b); }
                    Console.Write("Введите высоту пирамиды (отрезок от вершины пирамиды до центра его основания): ");
                    H = Convert.ToSingle(Console.ReadLine());
                    if (H <= 0) { H = Checking(H); }
                    Area(userChoice);                   
                    break;
                case 3:
                    Console.Clear();
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
                    Area(userChoice);                    
                    break;
                default:
                    Console.WriteLine("\nОШИБКА: Вы ввели неверное значение. Нажмите Enter и попробуйте снова.");
                    Console.ReadKey();
                    Console.Clear();
                    Input();
                    break;
            }
        }

        private void Area(int userChoice) // площадь
        {
            if (userChoice == 1) // конус
            {
                area = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
                Perimeter(userChoice, area);
            }
            else if (userChoice == 2) // треугольная пирамида
            {
                area = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(a, 2) + 3 / 2 * a * Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4), 3);
                Perimeter(userChoice, area);
            }
            else if (userChoice == 3) // четырехугольная пирамида
            {
                area = Math.Round(Math.Pow(a, 2) + 2 * a * Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4), 3);
                Perimeter(userChoice, area);
            }
        }

        private void Perimeter(int userChoice, double area) // периметр
        {
            if (userChoice == 1) // конус
            {
                perimeter = Math.Round(R * Math.PI + l * 2, 3);
                Volume(userChoice, area, perimeter);
            }
            else if (userChoice == 2) // треугольная пирамида
            {
                perimeter = Math.Round(3 * a + 3 * (a + b + b), 3);
                Volume(userChoice, area, perimeter);
            }
            else if (userChoice == 3) // четырехугольная пирамида
            {
                perimeter = Math.Round(4 * a + 4 * (a + b + b), 3);
                Volume(userChoice, area, perimeter);
            }
        }

        private void Volume(int userChoice, double area, double perimeter) // объем
        {
            if (userChoice == 1) // конус
            {
                double volume = Math.Round((Math.PI * Math.Pow(R, 2) * H) / 3, 3);
                Output(area, perimeter, volume);
            }
            else if (userChoice == 2) // треугольная пирамида
            {
                double volume = Math.Round(((Math.Pow(a, 2) * Math.Sqrt(3)) / 4 * H) / 3, 3);
                Output(area, perimeter, volume);
            }
            else if (userChoice == 3) // четырехугольная пирамида
            {
                double volume = Math.Round((Math.Pow(a, 2) * H) / 3, 3);
                Output(area, perimeter, volume);
            }
        }

        private void Output(double area, double perimeter, double volume) // вывод
        {
            Console.Write($"\nОбъем фигуры: {volume}");
            base.Output(area, perimeter); // вызывается из род. класса по умолчанию
        }
    }
}