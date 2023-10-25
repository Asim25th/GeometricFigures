namespace geometric_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРОГРАММА ДЛЯ ВЫЧИСЛЕНИЯ ПЛОЩАДИ \nИ ПЕРИМЕТРА ГЕОМЕТРИЧЕСКИХ ФИГУР");
            Console.WriteLine("\n1. Квадрат\n2. Прямоугольник\n3. Круг\n4. Треугольник\n5. Пирамида / Конус");
            Console.Write("\nВведите номер желаемой фигуры: ");
            int userChoice = (Convert.ToInt32(Console.ReadLine()));

            switch (userChoice)
            {
                case 1:
                    Square square = new Square(0, 0, 0);
                    Console.Clear();
                    square.Input();
                    Console.Clear();
                    Main(args);
                    break;
                case 2:
                    Rectangle rectangle = new Rectangle(0, 0, 0);
                    Console.Clear();
                    rectangle.Input();
                    Console.Clear();
                    Main(args);
                    break;
                case 3:
                    Circle circle = new Circle(0, 0, 0);
                    Console.Clear();
                    circle.Input();
                    Console.Clear();
                    Main(args);
                    break;
                case 4:
                    Triangle triangle = new Triangle(0, 0, 0);
                    Console.Clear();
                    triangle.Input();
                    Console.Clear();
                    Main(args);
                    break;
                case 5:
                    Pyramid pyramid = new Pyramid(0, 0, 0);
                    Console.Clear();
                    pyramid.Input();
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