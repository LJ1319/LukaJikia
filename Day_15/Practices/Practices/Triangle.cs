namespace Practices
{
    internal partial class Program
    {
        public class Triangle
        {
            public double SideA { get; set; }
            public double SideB { get; set; }
            public double SideC { get; set; }

            private double _perimeter;
            private double _area;

            public Triangle(double a, double b, double c)
            {
                if (Validate(a, b, c))
                {
                    SideA = a;
                    SideB = b;
                    SideC = c;
                }
                else
                {
                    Console.WriteLine("Not a valid triangle");
                    return;
                }
            }

            public double Perimeter()
            {
                _perimeter = SideA + SideB + SideC;
                return _perimeter;
            }

            public double Area()
            {
                _area = _perimeter / 2;
                return _area;
            }

            private static bool Validate(double a, double b, double c)
            {
                if (a <= 0 || b <= 0 || c <= 0)
                    return false;

                if (a + b > c && c + b > a && a + c > b)
                    return true;

                return false;
            }

            public static bool operator ==(Triangle tr1, Triangle tr2)
            {
                return tr1._area == tr2._area;
            }
            
            public static bool operator !=(Triangle tr1, Triangle tr2)
            {
                return tr1._area != tr2._area;
            }

            public static bool operator >(Triangle tr1, Triangle tr2)
            {
                return tr1._area > tr2._area;
            }

            public static bool operator <(Triangle tr1, Triangle tr2)
            {
                return tr1._area < tr2._area;
            }
            
            public static Triangle operator +(Triangle tr1, Triangle tr2)
            {
                return new Triangle((tr1._area + tr2._area) / 3, (tr1._area + tr2._area) / 3, (tr1._area + tr2._area) / 3);
            }

            public static explicit operator Triangle(double a)
            {
                return new Triangle(a, a, a);
            }
        }
    }
}