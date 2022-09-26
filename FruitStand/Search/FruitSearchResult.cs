namespace FruitStand
{
    public class FruitSearchResult
    {

        public int ID { get; private set; }

        public string Name { get; private set; }

        public FruitSearchResult(int id, string name)
        {
            ID = id;
            Name = name;
        }

    }
}
