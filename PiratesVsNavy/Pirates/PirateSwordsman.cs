namespace PiratesVsNavy
{
    public class PirateSwordsman : Swordsman
    {
        public override double Attack => 40;

        public override double Defense => 30;

        public override double Speed => 35;

        public override double Range => 5;

        public override string ToString()
        {
            return "Pirate " + base.ToString();
        }

    }
}
