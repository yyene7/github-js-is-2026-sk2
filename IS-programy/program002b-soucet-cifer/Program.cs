using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("********** Součet a součin cifer - Jan Šindler **********");

        string again = "a";
        while (again.ToLower() == "a")
        {
            int cislo = ReadInt("zadejte cele cislo: ");

            // jiný způsob: převedeme číslo na text a projdeme jednotlivé znaky
            string text = Math.Abs((long)cislo).ToString();

            long soucet = 0;
            long soucin = 1;

            foreach (char znak in text)
            {
                int cifra = znak - '0';   // znak -> hodnota cifry
                soucet += cifra;
                soucin *= cifra;
            }

            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine($"cislo:  {cislo}");
            Console.WriteLine($"soucet cifer: {soucet}");
            Console.WriteLine($"soucin cifer: {soucin}");
            Console.WriteLine("==============");
            Console.WriteLine();

            Console.Write("chcete zadat dalsi cislo? (a = ano, cokoliv jineho = konec): ");
            again = Console.ReadLine() ?? "";
        }

        Console.WriteLine("konec programu.");
    }

    static int ReadInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("chyba: zadej platne cele cislo.");
        }
    }
}
