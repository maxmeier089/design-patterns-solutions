namespace PiratesVsNavy
{
    public class PirateArtillery : Artillery
    {
        public override double Accuracy => 0.2;

        public override double Attack => 90;

        public override double Defense => 5;

        public override double Speed => 5;

        public override double Range => 45;

        public override string ToString()
        {
            return "Pirate " + base.ToString();
        }

    }
}
