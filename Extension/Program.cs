using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "A'zamjon";
        name.Hi();
    }
}

static class NewMethodClass
{
    public static void Hi(this string e)
    {
        Console.WriteLine("Assalomu alaykum");
    }
}