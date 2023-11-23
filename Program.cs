using System.Net.Http.Headers;


{
    Produto mouse = new Produto(1, "mouse gamer", 299.97);
    Console.WriteLine(mouse.Id);
    Console.WriteLine(mouse.Nome);
    Console.WriteLine(mouse.Price);
}
struct Produto
{
    public Produto(int id, string nome, double price)
    {
        Id = id;
        Nome = nome;
        Price = price;
    }
    public int Id;
    public string Nome;
    public double Price;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}