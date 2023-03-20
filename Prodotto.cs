public class Prodotto
{
    public int code;
    public string name;
    public string fullname;
    public string description;
    public double price;
    public int iva;

    public Prodotto(string name, string description, double price, int iva)
    {
        this.code = GenerateRandomCode();
        this.name = name;
        this.fullname = FullName(this.code, name);
        this.description = description;
        this.price = price;
        this.iva = FullPrice(price, iva);
    }

    private int GenerateRandomCode()
    {
        Random random = new Random(42);
        return random.Next(1, 99999);
    }

    private int FullPrice(double price, int iva)
    {
        double ivaAmount = price * iva / 100;
        int result = (int)(price + ivaAmount);
        return result;
    }

    private string FullName(int code, string name)
    {
        string result = code.ToString() + " " + name;
        return result;
    }
}
