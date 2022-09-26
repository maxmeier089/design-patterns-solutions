namespace PiratesVsNavy
{
    public class NavyArtillery : Artillery
    {
        public override double Accuracy => 0.25;

        public override double Attack => 80;

        public override double Defense => 8;

        public override double Speed => 8;

        public override double Range => 55;

        public override string ToString()
        {
            return "Navy " + base.ToString();
        }

    }
}
