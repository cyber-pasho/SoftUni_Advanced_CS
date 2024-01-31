string input;
List<Shop> shops = new List<Shop>();
while ((input = Console.ReadLine()) != "Revision")
{
    var data = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = data[0];
    string productName = data[1];
    double productPrice = double.Parse(data[2]);
    if (!shops.Any(s => s.Name == shopName))
    {
        shops.Add(new Shop(shopName, new Dictionary<string, double> { { productName, productPrice } }));
    }
    else if (shops.Any(s => s.Name == shopName) && !shops.Any(s => s.Product.ContainsKey(productName)))
    {
        foreach (var shop in shops)
        {
            if (shop.Name == shopName)
            {
                shop.Product.Add(productName, productPrice);
            }
        }
    }
}
List<Shop> orderedShops = shops
        .OrderBy(s => s.Name)
        .ToList();
foreach (var shop in orderedShops)
{
    Console.WriteLine($"{shop.Name}->");
    foreach (var product in shop.Product)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}
public class Shop
{
    public Shop(string name, Dictionary<string, double> product)
    {
        Name = name;
        Product = product;
    }

    public string Name { get; set; }
    public Dictionary<string, double> Product { get; set; }
}