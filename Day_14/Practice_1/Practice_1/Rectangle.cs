namespace Practice_1
{
    class Rectangle : Shape
    {
        public Point A { get; set; } = new Point();
        public Point B { get; set; } = new Point();
        public Point C { get; set; } = new Point();
        public Point D { get; set; } = new Point();

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        private double _perimeter;
        private double _area;

        public Rectangle(int aX, int aY, int bX, int bY, int cX, int cY, int dX, int dY)
        {
            A.X = aX;
            A.Y = aY;
            B.X = bX;
            B.Y = bY;
            C.X = cX;
            C.Y = cY;
            D.X = dX;
            D.Y = dY;

            SideA = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            SideB = Math.Sqrt(Math.Pow(B.X - C.X, 2) + Math.Pow(B.Y - C.Y, 2));
            SideC = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            SideD = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
        }

        public override double Perimeter()
        {
            _perimeter = SideA + SideB + SideC + SideD;
            return _perimeter;
        }

        public override double Area()
        {

            _area = SideA * SideB;
            return _area;
        }
    }
}