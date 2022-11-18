namespace Practice_1
{
    class Circle : Shape
    {
        public Point Center { get; set; } = new Point();
        public Point CirclePoint { get; set; } = new Point();

        public double Radius { get; set; }

        private double _perimeter;
        private double _area;

        public Circle(int centerPointX, int centerPointY, int circlePointX, int circlePointY)
        {
            Center.X = centerPointX;
            Center.Y = centerPointY;
            CirclePoint.X = circlePointX;
            CirclePoint.Y = circlePointY;

            Radius = Math.Sqrt(Math.Pow(Center.X - CirclePoint.X, 2) + Math.Pow(Center.Y - CirclePoint.Y, 2));
        }

        public override double Perimeter()
        {
            _perimeter = 2 * Math.PI * Radius;
            return _perimeter;
        }

        public override double Area()
        {
            _area = Math.PI * Radius * Radius;
            return _area;
        }
    }
}