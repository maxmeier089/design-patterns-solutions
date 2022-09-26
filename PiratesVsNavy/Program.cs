using PiratesVsNavy;

static void CreateUnits(AbstractBarracks barracks)
{
    Console.WriteLine(barracks + "\n");

    Swordsman swordsman = barracks.CreateSwordsman();
    Console.WriteLine(swordsman + "\n");

    Rifleman rifleman = barracks.CreateRifleman();
    Console.WriteLine(rifleman + "\n");

    Artillery artillery = barracks.CreateArtillery();
    Console.WriteLine(artillery + "\n\n");
}


CreateUnits(PirateBarracks.Instance);

CreateUnits(NavyBarracks.Instance);
