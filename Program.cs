namespace Lab2Problema1EliseiRadu;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scrie numele tau: ");
        var name = Console.ReadLine();
        Console.WriteLine("Scrie varsta ta: ");
        try
        {
            int varsta = int.Parse(Console.ReadLine());
            if (varsta < 18)
            {
                Console.WriteLine(name + ", nu ai varsta necesara pentru a vota.");
            }
            else
            {
                Console.WriteLine("Poti vota, " + name + ".");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Inputul nu este un numar natural.");
        }

    }
}