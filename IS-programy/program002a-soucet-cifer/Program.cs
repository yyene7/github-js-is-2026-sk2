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

            // pracujeme s absolutní hodnotou, znaménko nás nezajímá
            long n = Math.Abs((long)cislo);

            long soucet = 0;
            long soucin = 1;

            // prubeh rozkladu cisla na jednotlive cislice z prava doleva
            // cistě matematicky: cifry získáváme dělením 10 a zbytkem po dělení 10
            do
            {
                int cifra = (int)(n % 10);   // poslední cifra (modulo)
                soucet += cifra;
                soucin *= cifra;
                n /= 10;                     // odstranění poslední cifry (celočíselné dělení)
            } while (n > 0);

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
