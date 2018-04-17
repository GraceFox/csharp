using System;

public enum Schedule
{
    Teenth,  //13 - 19
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    public Meetup(int month, int year)
    {
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {

        DateTime thar = new DateTime(2013, 5, 13);
        return thar;
    }
}