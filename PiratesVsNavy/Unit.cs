namespace PiratesVsNavy
{
    public abstract class Unit
    {

        public abstract double Attack { get; }

        public abstract double Defense { get; }

        public abstract double Speed { get; }

        public abstract double Range { get; }

        public override string ToString()
        {
            return
                "\nAttack: " + Attack +
                "\nDefense: " + Defense +
                "\nSpeed: " + Speed +
                "\nRange: " + Range;
        }

    }
}
