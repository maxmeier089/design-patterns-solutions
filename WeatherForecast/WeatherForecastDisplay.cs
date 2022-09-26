namespace WeatherForecast
{
    public class WeatherForecastDisplay
    {

        private readonly WeatherForecastGenerator generator;

        private void Generator_TemperatureWarningEvent(object? sender, TemperatureWarningEventArgs e)
        {
            Console.WriteLine(e + "\n");
        }

        private void Generator_WindWarningEvent(object? sender, WindForceWarningEventArgs e)
        {
            Console.WriteLine(e + "\n");
        }

        private void Generator_RainWarningEvent(object? sender, RainfallWarningEventArgs e)
        {
            Console.WriteLine(e + "\n");
        }

        public void Run()
        {
            while (true)
            {
                Forecast forecast = generator.GenerateForecast();

                Console.WriteLine(forecast + "\n");

                Thread.Sleep(500);
            }
        }

        public WeatherForecastDisplay(WeatherForecastGenerator generator)
        {
            this.generator = generator;
            this.generator.TemperatureWarningEvent += Generator_TemperatureWarningEvent;
            this.generator.WindWarningEvent += Generator_WindWarningEvent;
            this.generator.RainWarningEvent += Generator_RainWarningEvent;
        }

    }
}
