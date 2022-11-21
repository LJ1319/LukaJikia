namespace Practice_1
{
    public class Triangle : Shape
    {
        public Point A { get; set; } = new Point();
        public Point B { get; set; } = new Point();
        public Point C { get; set; } = new Point();

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        private double _perimeter;
        private double _area;

        public Triangle(int aX, int aY, int bX, int bY, int cX, int cY)
        {
            A.X = aX;
            A.Y = aY;
            B.X = bX;
            B.Y = bY;
            C.X = cX;
            C.Y = cY;

            SideA = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            SideB = Math.Sqrt(Math.Pow(B.X - C.X, 2) + Math.Pow(B.Y - C.Y, 2));
            SideC = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
        }

        public override double Perimeter()
        {
            _perimeter = SideA + SideB + SideC;
            return _perimeter;
        }

        public override double Area()
        {
            _area = _perimeter / 2;
            return _area;
        }

    }
}