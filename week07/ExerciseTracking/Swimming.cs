class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps* 50/1000.0; //distance in km (50m per lap)
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_duration) * 60; // speed in kph
    }

    public override double GetPace()
    {
        return _duration/GetDistance(); // pace in min per km
    }
}