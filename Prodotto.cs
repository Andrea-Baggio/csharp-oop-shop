public class Prodotto
{
    public int code;
    public string name;
    public string description;
    public double price;
    public long iva;

    public Prodotto(string name, string description, double price, long iva)
    {
        this.code = GenerateRandomCode();
        this.name = name;
        this.description = description;
        this.price = price;
        this.iva = iva;
    }

    private int GenerateRandomCode()
    {
        Random random = new Random();
        return random.Next(1, 999999);
    }
}




//Random rnd = new Random();

//for (int i = 0; i < n; i++)
//{
//    int[] myArray = new int[10];

//    for (int j = 0; j < myArray.Length; j++)
//    {
//        myArray[j] = rnd.Next(1, 101);
//    }

//    Console.WriteLine(string.Join(", ", myArray));
//}
