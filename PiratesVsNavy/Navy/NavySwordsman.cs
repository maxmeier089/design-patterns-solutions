namespace PiratesVsNavy
{
    public class NavySwordsman : Swordsman
    {
        public override double Attack => 30;

        public override double Defense => 35;

        public override double Speed => 30;

        public override double Range => 7;

        public override string ToString()
        {
            return "Navy " + base.ToString();
        }

    }
}
