namespace geometric_figures
{
    class Pyramid // пирамида, конус
    {
        private double R; // радиус (основания) конуса
        private double l; // образующая конуса (отрезок от вершины конуса до границы его основания)
        private double H; // высота конуса (отрезок от вершины конуса до центра его основания)
        private double a; // ребро основания пирамиды
        private double b; // боковое ребро пирамиды

        public void input()
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА ПИРАМИДЫ И КОНУСА");
            Console.WriteLine("\n1. Конус\n2. Треугольная пирамида\n3. Четырехугольная пирамида");
            Console.Write("\nВведите номер желаемой фигуры: ");
            int userChoice = (Convert.ToInt32(Console.ReadLine()));

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА КОНУСА");
                    Console.Write("\nВведите радиус (основания) конуса: ");
                    R = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите образующую конуса (отрезок от вершины конуса до границы его основания): ");
                    l = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите высоту конуса (отрезок от вершины конуса до центра его основания): ");
                    H = Convert.ToSingle(Console.ReadLine());
                    area(userChoice);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА ТРЕУГОЛЬНОЙ ПИРАМИДЫ");
                    Console.Write("\nВведите ребро основания пирамиды: ");
                    a = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите боковое ребро пирамиды: ");
                    b = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите высоту пирамиды (отрезок от вершины пирамиды до центра его основания): ");
                    H = Convert.ToSingle(Console.ReadLine());
                    area(userChoice);
                    break;
                case 3:
                    
                    area(userChoice);
                    break;
                default:
                    Console.WriteLine("\nОШИБКА: Вы ввели неверное значение. Нажмите Enter и попробуйте снова.");
                    Console.ReadKey();
                    Console.Clear();
                    input();
                    break;
            }
        }

        private void area(int userChoice)
        {
            if (userChoice == 1) // конус
            {
                double area = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
                perimeter(userChoice, area);
            }

            else if (userChoice == 2) // треугольная пирамида
            {
                double area = Math.Round((Math.Pow(a, 2) * Math.Sqrt(3) + 6 * a * Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4)) / 4, 3);
                perimeter(userChoice, area);
            }

            else if (userChoice == 3) // четырехугольная пирамида
            {
                double area = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
                perimeter(userChoice, area);
            }
        }

        private void perimeter(int userChoice, double area)
        {
            if (userChoice == 1)
            {
                double perimeter = Math.Round(R * Math.PI + l * 2, 3);
                volume(userChoice, area, perimeter);
            }

            else if (userChoice == 2)
            {
                double perimeter = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
                volume(userChoice, area, perimeter);
            }

            else if (userChoice == 3)
            {
                double perimeter = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
                volume(userChoice, area, perimeter);
            }
        }

        private void volume(int userChoice, double area, double perimeter) // объем
        {
            if (userChoice == 1)
            {
                double volume = Math.Round((Math.PI * Math.Pow(R, 2) * H) / 3, 3);
                output(area, perimeter, volume);
            }

            else if (userChoice == 2)
            {
                //double volume = Math.Round(, 3);
                output(area, perimeter, volume);
            }

            else if (userChoice == 3)
            {
                double volume = Math.Round(Math.PI * R * l + Math.PI * Math.Pow(R, 2), 3);
                output(area, perimeter, volume);
            }
        }

        private void output(double area, double perimeter, double volume)
        {
            Console.WriteLine($"\nПлощадь фигуры: {area}");
            Console.WriteLine($"Периметр фигуры: {perimeter}");
            Console.WriteLine($"Объем фигуры: {volume}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}