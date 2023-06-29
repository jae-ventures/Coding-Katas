// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args) {
        helloWorld((args.Length > 0) ? args[0] : "World");
    }


    public static void helloWorld(string subject) {
        Console.WriteLine($"Hello {subject}!");
    }
}