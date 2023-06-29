// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args) {
        // TEST method
        // helloWorld((args.Length > 0) ? args[0] : "World");
        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);
        Console.WriteLine(timeSpan1.Hours + " " + timeSpan2.Hours);

        // Console.WriteLine("");
    }

    #region: Kata 1
    /*
    * Convert a decimal number to a binary number and vice versa using math.
    * Each method should accept a string with only valid digits to be converted.
    */
    public static void BinToDec() {
        throw new NotImplementedException("Not yet implemented");
    }

    public static void DecToBin() {
        throw new NotImplementedException("Not yet implemented");
    }
    #endregion

    #region: Kata 2
    /*
    * Steps to create a doubly linked list
    *  1. Create a Node class
    *  2. Create a LinkedList class
    *  3. Create methods to add and remove nodes from LinkedList
    */
    #endregion


    /// <summary>
    /// Test method just to make sure everything is running
    /// </summary>
    /// <param name="subject">Person or object to say hello to.</param>
    public static void helloWorld(string subject) {
        Console.WriteLine($"Hello {subject}!");
    }
}