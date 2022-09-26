namespace WeatherForecast
{
    public class WeatherForecastGenerator
    {

        public event EventHandler<TemperatureWarningEventArgs>? TemperatureWarningEvent;

        public event EventHandler<WindForceWarningEventArgs>? WindWarningEvent;

        public event EventHandler<RainfallWarningEventArgs>? RainWarningEvent;


        DateTime date = DateTime.Now.Date;

        readonly Random random = new();

        double temperature = 20.0;
        double windForce = 40.0;
        double rainfall = 20.0;

        private void GenerateNewValue(ref double value, double range, double min, double max)
        {
            double newValue = value + (random.NextDouble() - 0.5) * range;
            newValue = Math.Max(min, newValue);
            newValue = Math.Min(max, newValue);
            value = newValue;
        }

        public Forecast GenerateForecast()
        {
            date = date.AddDays(1);


            GenerateNewValue(value: ref temperature, range: 10.0, min: -20.0, max: 45.0);

            if (temperature > 30.0)
            {
                TemperatureWarningEvent?.Invoke(this, new TemperatureWarningEventArgs(temperature));
            }


            GenerateNewValue(value: ref windForce, range: 10.0, min: 0.0, max: 150.0);

            if (windForce > 60.0)
            {
                WindWarningEvent?.Invoke(this, new WindForceWarningEventArgs(windForce));
            }


            GenerateNewValue(value: ref rainfall, range: 10.0, min: 0.0, max: 100.0);

            if (rainfall > 40.0)
            {
                RainWarningEvent?.Invoke(this, new RainfallWarningEventArgs(rainfall));
            }


            return new Forecast(date, temperature, windForce, rainfall);
        }

    }
}
