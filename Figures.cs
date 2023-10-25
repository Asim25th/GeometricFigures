namespace geometric_figures
{
    class Figures // родительский класс
    {
        protected double a; // сторона фигуры
        protected double area; // площадь
        protected double perimeter; // периметр

        public Figures(double a, double area, double perimeter)
        {
            this.a = a;
            this.area = area;
            this.perimeter = perimeter; 
        }

        public virtual void Output(double area, double perimeter) // по умолчанию
        {
            Console.WriteLine($"\nПлощадь фигуры: {area}");
            Console.WriteLine($"Периметр фигуры: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
    }
}