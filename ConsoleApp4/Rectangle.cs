namespace ConsoleApp4
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return Length * Width;
        }
    }
}