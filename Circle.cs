namespace geometric_figures
{
    class Circle : Figures // круг
    {
        private double R; // радиус круга

        public Circle(double a, double area, double perimeter) : base(a, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ И ПЕРИМЕТРА КРУГА");
            Console.Write("\nВведите радиус круга: ");
            R = Convert.ToSingle(Console.ReadLine());

            if (R <= 0)
            {
                Console.WriteLine("\nОШИБКА: Радиус не может быть меньше или равным нулю. Нажмите Enter и попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                this.Input();
            }

            else
            {
                Area();
            }
        }

        private void Area() // площадь
        {
            area = Math.Round(Math.PI + Math.Pow(R, 2), 3);
            Perimeter(area);
        }

        private void Perimeter(double area) // периметр
        {
            perimeter = Math.Round(2 * Math.PI * R, 3);
            Output(area, perimeter); // вызывается из род. класса по умолчанию
        }

        //private void Output(double area, double perimeter) // вывод
        //{
        //    Console.WriteLine($"\nПлощадь круга: {area}");
        //    Console.WriteLine($"Периметр круга: {perimeter}");
        //    Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
        //    Console.ReadKey();
        //}
    }
}