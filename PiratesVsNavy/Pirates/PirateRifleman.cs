namespace PiratesVsNavy
{
    public class PirateRifleman : Rifleman
    {
        public override double Accuracy => 0.4;

        public override double Attack => 50;

        public override double Defense => 10;

        public override double Speed => 25;

        public override double Range => 30;

        public override string ToString()
        {
            return "Pirate " + base.ToString();
        }

    }
}
