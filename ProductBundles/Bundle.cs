namespace ProductBundles
{
    public class Bundle : ProductComponent
    {

        public List<ProductComponent> Children { get; }

        public override decimal Price => Math.Round(Children.Sum(c => c.Price) * 0.95m, 2);

        internal override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Bundle " + Price.ToString("C2"));

            foreach (ProductComponent component in Children)
            {
                component.Print(prefix + "    ");
            }
        }

        public Bundle(List<ProductComponent> children)
        {
            Children = children;
        }

    }
}
