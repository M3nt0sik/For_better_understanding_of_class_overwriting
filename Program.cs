using For_better_understanding_of_class_overwriting;

internal class Program
{
    private static void Main(string[] args)
    {
        SafeOwner owner = new SafeOwner();
        Safe safe = new Safe();
        JewelThief jewelThief = new JewelThief();
        jewelThief.OpenSafe(safe, owner);
        Console.ReadKey();
    }
}