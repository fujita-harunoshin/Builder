namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        builder.BuildPartA();
        builder.BuildPartC();
        Console.WriteLine(builder.GetProduct().ListParts());
    }
}
