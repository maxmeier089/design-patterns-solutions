namespace ProductBundles
{
    public abstract class ProductComponent
    {

        public abstract decimal Price { get; }

        public void Print()
        {
            Print("");
            Console.WriteLine();
        }

        internal abstract void Print(string prefix);

    }
}
