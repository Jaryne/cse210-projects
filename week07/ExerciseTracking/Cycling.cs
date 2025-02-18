class Cycling : Activity
{
    private double _speed; //kph

    public Cycling(DateTime date, int duration, double speed) : base (date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _duration)/60; // distance in km
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/_speed; // pace in min per km
    }
}