namespace PiratesVsNavy
{
    public class NavyRifleman : Rifleman
    {
        public override double Accuracy => 0.5;

        public override double Attack => 45;

        public override double Defense => 15;

        public override double Speed => 20;

        public override double Range => 35;

        public override string ToString()
        {
            return "Navy " + base.ToString();
        }

    }
}
