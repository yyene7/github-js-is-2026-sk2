using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Výpis řady Jan Šindler");

        int first = ReadInt("zadejte prvni cislo rady (cele cislo): ");
        int last = ReadInt("zadejte posledni cislo rady (cele cislo): ");
        int step = ReadPositiveInt("zadejte diferenci (kladne cele cislo): ");

        Console.WriteLine();

        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }

    static int ReadInt(string prompt)
    {
        int value;s
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("cchyba: zadej platne cele cislo.");
        }
    }

    static int ReadPositiveInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("diference musi byt kladne cele cislo vetsi nez 0.");
        }
    }
}