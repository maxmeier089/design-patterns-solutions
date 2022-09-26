namespace WeatherForecast
{
    public class Forecast
    {

        public DateTime Date { get; }

        public double Temperature { get; }

        public double WindForce { get; }

        public double Rainfall { get; }

        public override string ToString()
        {
            return
                Date.ToShortDateString() +
                "\nTemperature: " + string.Format("{0:0.00}", Temperature) + " °C" +
                "\nWind Force: " + string.Format("{0:0.00}", WindForce) + " km/h" +
                "\nRainfall: " + string.Format("{0:0.00}", Rainfall) + " l/m²";

        }

        public Forecast(DateTime date, double temperature, double windForce, double rainfall)
        {
            Date = date;
            Temperature = temperature;
            WindForce = windForce;
            Rainfall = rainfall;
        }

    }
}
