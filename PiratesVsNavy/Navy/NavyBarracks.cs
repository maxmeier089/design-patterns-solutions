namespace PiratesVsNavy
{
    public class NavyBarracks : AbstractBarracks
    {

        public static NavyBarracks Instance { get; }

        public override Swordsman CreateSwordsman()
        {
            return new NavySwordsman();
        }

        public override Rifleman CreateRifleman()
        {
            return new NavyRifleman();
        }

        public override Artillery CreateArtillery()
        {
            return new NavyArtillery();
        }

        public override string ToString()
        {
            return "Navy Barracks";
        }

        private NavyBarracks()
        {
        }

        static NavyBarracks()
        {
            Instance = new NavyBarracks();
        }

    }
}

