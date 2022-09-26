namespace PiratesVsNavy
{
    public abstract class RangedUnit : Unit
    {

        public abstract double Accuracy { get; }

        public override string ToString()
        {
            return
                "\nAccuracy: " + Accuracy +
                base.ToString();
        }

    }
}
