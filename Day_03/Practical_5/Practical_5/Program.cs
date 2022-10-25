using System;

namespace Practical_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your day of birth: ");
            int birthDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your month of birth");
            string birthMonth = Console.ReadLine();

            string zodiacSign = "";
            switch (birthMonth)
            {
                case "January":
                    if (birthDay < 20)
                        zodiacSign = "Capricorn";
                    else
                        zodiacSign = "Aquarius";
                    break;
                case "February":
                    if (birthDay < 19)
                        zodiacSign = "Aquarius";
                    else
                        zodiacSign = "Pisces";
                    break;
                case "March":
                    if (birthDay < 21)
                        zodiacSign = "Pisces";
                    else
                        zodiacSign = "Aries";
                    break;
                case "April":
                    if (birthDay < 20)
                        zodiacSign = "Aries";
                    else
                        zodiacSign = "Taurus";
                    break;
                case "May":
                    if (birthDay < 21)
                        zodiacSign = "Taurus";
                    else
                        zodiacSign = "Gemini";
                    break;
                case "June":
                    if (birthDay < 21)
                        zodiacSign = "Gemini";
                    else
                        zodiacSign = "Cancer";
                    break;
                case "July":
                    if (birthDay < 23)
                        zodiacSign = "Cancer";
                    else
                        zodiacSign = "Leo";
                    break;
                case "August":
                    if (birthDay < 23)
                        zodiacSign = "Leo";
                    else
                        zodiacSign = "Virgo";
                    break;
                case "September":
                    if (birthDay < 23)
                        zodiacSign = "Virgo";
                    else
                        zodiacSign = "Libra";
                    break;
                case "October":
                    if (birthDay < 23)
                        zodiacSign = "Libra";
                    else
                        zodiacSign = "Scorpio";
                    break;
                case "November":
                    if (birthDay < 22)
                        zodiacSign = "Scorpio";
                    else
                        zodiacSign = "Sagitarius";
                    break;
                case "December":
                    if (birthDay < 22)
                        zodiacSign = "Sagitarius";
                    else
                        zodiacSign = "Capricorn";
                    break;
            }

            Console.WriteLine($"{birthDay} {birthMonth} is {zodiacSign}");
        }
    }
}
