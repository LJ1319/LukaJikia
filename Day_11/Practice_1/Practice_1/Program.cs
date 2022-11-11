using System;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            persons[0] = person1;
            persons[1] = person2;
            persons[2] = person3;

            Home home1 = new Home();
            Home home2 = new Home();
            Home home3 = new Home();

            person1.Home = home1;
            person2.Home = home2;
            person3.Home = home3;
        }
    }
}
