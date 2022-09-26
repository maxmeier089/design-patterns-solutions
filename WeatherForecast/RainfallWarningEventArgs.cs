namespace WeatherForecast
{
    public class RainfallWarningEventArgs
    {

        public double Rainfall { get; }

        public override string ToString()
        {
            return
                "RAIN WARNING!!!" +
                "\nRain will be " + string.Format("{0:0.00}", Rainfall) + " l/m²";
        }

        public RainfallWarningEventArgs(double rainfall)
        {
            Rainfall = rainfall;
        }

    }
}
