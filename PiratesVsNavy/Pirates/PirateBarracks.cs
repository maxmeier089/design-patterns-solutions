namespace PiratesVsNavy
{
    public class PirateBarracks : AbstractBarracks
    {

        public static PirateBarracks Instance { get; }

        public override Swordsman CreateSwordsman()
        {
            return new PirateSwordsman();
        }

        public override Rifleman CreateRifleman()
        {
            return new PirateRifleman();
        }

        public override Artillery CreateArtillery()
        {
            return new PirateArtillery();
        }

        public override string ToString()
        {
            return "Pirate Barracks";
        }

        private PirateBarracks()
        {
        }

        static PirateBarracks()
        {
            Instance = new PirateBarracks();
        }

    }
}
