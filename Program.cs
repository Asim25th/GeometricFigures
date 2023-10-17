namespace geometric_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРОГРАММА ДЛЯ ВЫЧИСЛЕНИЯ ПЛОЩАДИ \nИ ПЕРИМЕТРА ГЕОМЕТРИЧЕСКИХ ФИГУР");
            Console.WriteLine("\n1. Квадрат\n2. Прямоугольник\n3. Круг\n4. Треугольник");
            Console.Write("\nВведите номер желаемой фигуры: ");
            int userChoice = (Convert.ToInt32(Console.ReadLine()));

            switch (userChoice)
            {
                case 1:
                    Square square = new Square();
                    Console.Clear();
                    square.area();
                    square.perimeter();
                    Console.Clear();
                    Main(args);
                    break;
                case 2:
                    Rectangle rectangle = new Rectangle();
                    Console.Clear();
                    rectangle.area();
                    rectangle.perimeter();
                    Console.Clear();
                    Main(args);
                    break;
                case 3:
                    Circle circle = new Circle();
                    Console.Clear();
                    circle.area();
                    circle.perimeter();
                    Console.Clear();
                    Main(args);
                    break;
                case 4:
                    Triangle triangle = new Triangle();
                    Console.Clear();
                    triangle.area();
                    triangle.perimeter();
                    Console.Clear();
                    Main(args);
                    break;
                default:
                    Console.WriteLine("\nОШИБКА: Вы ввели неверное значение. Нажмите Enter и попробуйте снова.");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
    }
}