namespace geometric_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ПРОГРАММА ДЛЯ ВЫЧИСЛЕНИЯ ПЛОЩАДИ \nИ ПЕРИМЕТРА ГЕОМЕТРИЧЕСКИХ ФИГУР");
                Console.WriteLine("\n1. Квадрат\n2. Прямоугольник\n3. Круг\n4. Треугольник\n5. Конус\n6. Треугольная пирамида\n7. Четырехугольная пирамида");
                Console.WriteLine("\nДля завершения работы программы введите 0");
                Console.Write("\nВведите номер желаемой фигуры: ");
                int userChoice = (Convert.ToInt32(Console.ReadLine()));
                switch (userChoice)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Square square = new Square(0, 0, 0);
                        Console.Clear();
                        square.Input();
                        Console.Clear();
                        break;
                    case 2:
                        Rectangle rectangle = new Rectangle(0, 0, 0, 0);
                        Console.Clear();
                        rectangle.Input();
                        Console.Clear();
                        break;
                    case 3:
                        Circle circle = new Circle(0, 0, 0, 0);
                        Console.Clear();
                        circle.Input();
                        Console.Clear();
                        break;
                    case 4:
                        Triangle triangle = new Triangle(0, 0, 0, 0);
                        Console.Clear();
                        triangle.Input();
                        Console.Clear();
                        break;
                    case 5:
                        Cone cone = new Cone(0, 0, 0, 0);
                        Console.Clear();
                        cone.Input();
                        Console.Clear();
                        break;
                    case 6:
                        PyramidTriangular pyramid_triangular = new PyramidTriangular(0, 0, 0, 0);
                        Console.Clear();
                        pyramid_triangular.Input();
                        Console.Clear();
                        break;
                    case 7:
                        PyramidQuadrilateral pyramid_quadrilateral = new PyramidQuadrilateral(0, 0, 0, 0);
                        Console.Clear();
                        pyramid_quadrilateral.Input();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\nОШИБКА: Вы ввели неверное значение. Нажмите Enter и попробуйте снова.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}