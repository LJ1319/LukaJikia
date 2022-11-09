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
            if (_seconds < 0)
            {
                _seconds = 59;
                _minutes -= 1;
            }
        }

        public void SecondForward()
        {
            _seconds += 1;
            if (_seconds > 59)
            {
                _seconds = 0;
                _minutes += 1;
            }
        }

        public void MinuteBack()
        {
            _minutes -= 1;
            if (_minutes < 0)
            {
                _minutes = 59;
               HourBack();
            }
        }

        public void MinuteForward()
        {
            _minutes += 1;
            if (_minutes >= 59)
            {
                _minutes = 0;
                HourForward();
            }
        }

        public void HourBack()
        {
            _hours -= 1;
            if (_hours < 0)
            {
                _hours = 23;
            }
        }

        public void HourForward()
        {
            _hours += 1;
            if (_hours >= 24)
            {
                _hours = 0;
            }
        }

        public void GetCurrentTime()
        {
            Console.WriteLine($"{_hours}:{_minutes}:{_seconds}");
        }
    }
}
