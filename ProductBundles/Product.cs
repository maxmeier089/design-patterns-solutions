namespace ProductBundles
{
    public class Product : ProductComponent
    {

        public string Name { get; }

        public override decimal Price { get; }

        internal override void Print(string prefix)
        {
            Console.WriteLine(prefix + Name + " " + Price.ToString("C2"));
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
