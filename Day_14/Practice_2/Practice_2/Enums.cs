using System.Diagnostics.Metrics;

namespace Practice_2
{
    public enum Vehicle
    {
        Army = 1,
        Consumer,
        Public,
        Sports,
    }

    public enum Army
    {
        Tank = 1,
        BTR,
        Hummer,
    }

    public enum Consumer
    {
        Sedan = 1,
        Hatchback,
        SUV,
    }

    public enum Public
    {
        Bus = 1,
        Metro,
        Taxi,
    }

    public enum Sports
    {
        F1 = 1,
        Rally,
        OffRoad,
    }
}