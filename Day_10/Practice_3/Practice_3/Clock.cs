using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    internal class Clock
    {
        int _seconds;
        int _minutes;
        int _hours;

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                    _seconds = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 && value <= 59)
                    _minutes = value;
            }
        }

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value >= 0 && value <= 23)
                    _hours = value;
            }
        }

        public void SecondBack()
        {
            _seconds -= 1;
            Validate();
        }

        public void SecondForward()
        {
            _seconds += 1;
            Validate();
        }

        public void MinuteBack()
        {
            _minutes -= 1;
            Validate();
        }

        public void MinuteForward()
        {
            _minutes += 1;
            Validate();
        }

        public void HourBack()
        {
            _hours -= 1;
            Validate();
        }

        public void HourForward()
        {
            _hours += 1;
            Validate();
        }

        public void Validate()
        {
            if (_seconds < 0)
            {
                _seconds = 59;
                _minutes -= 1;
            }

            if (_seconds > 59)
            {
                _seconds = 0;
                _minutes += 1;
            }

            if (_minutes < 0)
            {
                _minutes = 59;
                _hours -= 1;
            }

            if (_minutes > 59)
            {
                _minutes = 0;
                _hours += 1;
            }

            if (_hours < 0)
            {
                _hours = 23;
            }

            if (_hours >= 24)
            {
                _hours = 0;
            }
        }

        public void GetCurrentTime()
        {
            Console.WriteLine($"{_hours:00}:{_minutes:00}:{_seconds:00}");
        }
    }
}
