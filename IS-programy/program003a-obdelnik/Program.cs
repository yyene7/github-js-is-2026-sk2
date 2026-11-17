using System;
using System.Threading;

class Program
{
    const int ZPOZDENI_MS = 5;

    const char OBVOD = '#';
    const char VYPLN = '*';

    const string BARVA_RUZOVA = "\u001b[38;2;244;143;177m";
    const string BARVA_RUZOVA_SVETLA = "\u001b[38;2;248;187;208m";
    const string BARVA_FIALOVA = "\u001b[38;2;123;31;162m";
    const string BARVA_FIALOVA_SVETLA = "\u001b[38;2;156;39;176m";
    const string BARVA_RESET = "\u001b[0m";

    static readonly Random nahoda = new Random();

    static void Main()
    {
        Console.WriteLine("********** Obdélník - Jan Šindler **********");

        string again = "y";
        while (again.ToLower() == "y")
        {
            int sirka = ReadNatural("zadejte delku strany a (sirka): ");
            int vyska = ReadNatural("zadejte delku strany b (vyska): ");

            Console.WriteLine();

            for (int radek = 1; radek <= vyska; radek++)
            {
                for (int sloupec = 1; sloupec <= sirka; sloupec++)
                {
                    bool naObvodu = radek == 1 || radek == vyska
                                 || sloupec == 1 || sloupec == sirka;

                    bool svetlejsi = nahoda.Next(2) == 0;
                    string barva = radek % 2 == 0
                        ? (svetlejsi ? BARVA_FIALOVA_SVETLA : BARVA_FIALOVA)
                        : (svetlejsi ? BARVA_RUZOVA_SVETLA : BARVA_RUZOVA);

                    Console.Write(barva);
                    Console.Write(naObvodu ? OBVOD : VYPLN);
                    Thread.Sleep(ZPOZDENI_MS);
                }
                Console.WriteLine();
            }

            Console.Write(BARVA_RESET);

            Console.WriteLine();
            Console.Write("pokracovat y / terminate n: ");
            again = Console.ReadLine() ?? "";
        }

        Console.WriteLine("konec programu.");
    }

    static int ReadNatural(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("chyba: zadej prirozene cislo (vetsi nez 0).");
        }
    }
}
