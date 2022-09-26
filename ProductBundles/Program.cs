using ProductBundles;

Console.OutputEncoding = System.Text.Encoding.UTF8;


ProductComponent consoleBundle = new Bundle(new List<ProductComponent>()
{
    new Product("Gaming Console", 299.0m),
    new Product("Controller", 39.0m),
    new Product("Game", 59.0m)
});

consoleBundle.Print();


ProductComponent sportsBundle = new Bundle(new List<ProductComponent>()
{
    new Product("Running Shoes", 149.0m),
    new Product("Super tight trousers", 99.0m),
    new Product("Fitness tracker", 249.0m)
});

sportsBundle.Print();


ProductComponent bundleOfBundles = new Bundle(new List<ProductComponent>()
{
    consoleBundle,
    sportsBundle
});

bundleOfBundles.Print();
