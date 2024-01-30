string input;
List<Shop> shops = new List<Shop>();
while ((input = Console.ReadLine()) != "Revision")
{
    var data = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = data[0];
    string productName = data[1];
    double productPrice = int.Parse(data[2]);

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