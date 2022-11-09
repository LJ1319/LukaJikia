using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    internal class Triangle
    {
        int _firstSide;
        int _secondSide;
        int _thirdSide;

        public int FirtSide
        {
            get { return _firstSide; }
            set
            {
                if (value > 0)
                    _firstSide = value;
            }
        }

        public int SecondSide
        {
            get { return _secondSide; }
            set
            {
                if (value > 0)
                    _secondSide = value;
            }
        }

        public int ThirdSide
        {
            get { return _thirdSide; }
            set
            {
                if (value > 0)
                    _thirdSide = value;
            }
        }

        public bool IsValidTriangle
        { get; set; }


        public int Perimeter()
        {
            if (IsValidTriangle)
            {
                return _firstSide + _secondSide + _thirdSide;
            }

            return 0;
        }

        public int Area()
        {
            if (IsValidTriangle)
            {
                return Perimeter() / 2;
            }

            return 0;
        }
    }
}
