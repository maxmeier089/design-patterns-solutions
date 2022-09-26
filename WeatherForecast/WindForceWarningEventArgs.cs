namespace WeatherForecast
{
    public class WindForceWarningEventArgs : EventArgs
    {

        public double WindForce { get; }

        public override string ToString()
        {
            return
                "WIND WARNING!!!" +
                "\nWind Force will be " + string.Format("{0:0.00}", WindForce) + " km/h";
        }

        public WindForceWarningEventArgs(double windForce)
        {
            WindForce = windForce;
        }

    }
}
