class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance/_duration) * 60; // kph
    }

    public override double GetPace()
    {
        return _duration/_distance; // min per km
    }
}