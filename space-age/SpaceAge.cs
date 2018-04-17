using System;

public class SpaceAge
{
    private double secondsOnChosenPlanet = 0;
    int SecondsOnEarth = 31557600;

    public SpaceAge(long seconds)
    {
        Seconds = seconds;
    }

    public long Seconds { get; set; }

    private double PlanetYear()
    {
        var numOfPlanetYears = Seconds / (secondsOnChosenPlanet * SecondsOnEarth);
        return Math.Round(numOfPlanetYears, 2);
    }

    public double OnEarth()
    {
        secondsOnChosenPlanet = 1;
        return PlanetYear();
    }

    public double OnMercury()
    {
        secondsOnChosenPlanet = 0.2408467;
        return PlanetYear();
    }

    public double OnVenus()
    {
        secondsOnChosenPlanet = 0.61519726;
        return PlanetYear();
    }

    public double OnMars()
    {
        secondsOnChosenPlanet = 1.8808158;
        return PlanetYear();
    }

    public double OnJupiter()
    {
        secondsOnChosenPlanet = 11.862615;
        return PlanetYear();
    }

    public double OnSaturn()
    {
        secondsOnChosenPlanet = 29.447498;
        return PlanetYear();
    }

    public double OnUranus()
    {
        secondsOnChosenPlanet = 84.016846;
        return PlanetYear();
    }

    public double OnNeptune()
    {
        secondsOnChosenPlanet = 164.79132;
        return PlanetYear();
    }
}
// http://exercism.io/submissions/65dba200fcb0482080a07b90014d93b0