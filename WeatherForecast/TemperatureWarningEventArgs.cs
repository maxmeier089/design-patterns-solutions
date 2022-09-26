namespace WeatherForecast
{
    public class TemperatureWarningEventArgs : EventArgs
    {

        public double Temperature { get; }

        public override string ToString()
        {
            return
                "TEMPERATURE WARNING!!!" +
                "\nTemperature will be " + string.Format("{0:0.00}", Temperature) + " °C";
        }

        public TemperatureWarningEventArgs(double temperature)
        {
            Temperature = temperature;
        }

    }
}
