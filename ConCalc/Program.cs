do
{
    Console.Clear();
    Console.WriteLine("Velkommen til ConCalc");
    Console.WriteLine("Vil du bruge lommeregner, regne din nettoløn, eller kørselsfradag?");
    Console.WriteLine("1. Lommeregner.");
    Console.WriteLine("2. Nettoløn.");
    Console.WriteLine("3. Kørselsfradrag.");
    string a = Console.ReadLine();
    if (a == "1")
    {
        Console.Clear();
        Console.WriteLine("Velkommen til ConCalc Lommeregneren");
        Console.WriteLine("---------------------");
        Console.WriteLine("1. Plus");
        Console.WriteLine("2. Træk fra");
        Console.WriteLine("3. Gange");
        Console.WriteLine("4. Dividere");
        Console.WriteLine("---------------------");
        Console.Write("Vælg funktion: ");
        string funktion = Console.ReadLine();
        Console.Write("Tal 1: ");
        string tal1 = Console.ReadLine();
        Console.Write("Tal 2: ");
        string tal2 = Console.ReadLine();
        double resultat = 0;
        if (funktion == "1")
        {
            resultat = Convert.ToDouble(tal1) + Convert.ToDouble(tal2);
        }
        else if (funktion == "2")
        {
            resultat = Convert.ToDouble(tal1) - Convert.ToDouble(tal2);
        }
        else if (funktion == "3")
        {
            resultat = Convert.ToDouble(tal1) * Convert.ToDouble(tal2);
        }
        else if (funktion == "4")
        {
            resultat = Convert.ToDouble(tal1) / Convert.ToDouble(tal2);
        }
        Console.WriteLine("---------------------");
        Console.Write("Resultat: ");
        Console.WriteLine(resultat);
        Console.WriteLine("---------------------");
    }
    else if (a == "2")
    {
        Console.Clear();
        Console.Write("Hvad er din bruttoløn: ");
        string brutto = Console.ReadLine();

        Console.Write("Hvad er din fradrag: ");
        string fradrag = Console.ReadLine();

        Console.Write("Hvad er dit trækprocent: ");
        string træk = Console.ReadLine();

        double result1 = (Convert.ToDouble(brutto) - Convert.ToDouble(fradrag));
        double result2 = (Convert.ToDouble(træk) / 100) * Convert.ToDouble(result1);
        double result3 = result2 + Convert.ToDouble(fradrag);
        Console.WriteLine($"Din nettoløn er {result3}");
    }
    else if (a == "3")
    {
        Console.Clear();
        Console.Write("Hvor mange dage arbejder du, i løbet af et år?: ");
        string dage = Console.ReadLine();

        Console.Write("Hvor mange kilometrer kører du til OG fra arbejde, hver dag?: ");
        string kiloM = Console.ReadLine();
        if (Convert.ToDouble(kiloM) <= 24) //Hvis de kører under 24 km hver dag.
        {
            Console.WriteLine("Du kører ikke langt nok hver dag, til at få kørselsfradrag.");
        }
        else if (Convert.ToDouble(kiloM) > 24) //Hvis de kører over 24 km hver dag.
        {
            double køreFradrag = Convert.ToDouble(kiloM) - 24; //Hvor meget de kører minus 24, pga du ikke får noget de første 24 km.
            double køre = køreFradrag * 1.98; //Hvor meget de har kørt (over 24 km), gange hvor meget de får for en km.
            Console.Write("Hvor mange dage har du arbejdet hjemme, eller ikke været på arbejde, dette år: ");
            string ikkeArb = Console.ReadLine(); //Hvor mange arbejdsdage de Ikke har været/kørt.
            double arbDag = Convert.ToDouble(dage) - Convert.ToDouble(ikkeArb); // Hvor mange dage har de arbejdet i år.
            double færdigtKør = køre * Convert.ToDouble(arbDag); // Dage de har arbejdet *  hvor meget de får per kilometer.
            Console.WriteLine($"Du kan få kr. {færdigtKør} i kørselsfradrag, om året.");
        }
    }
    Console.WriteLine("Tryk Escape for at lukke programmet, eller en anden tast for at genstarte programmet.");
} while (Console.ReadKey().Key != ConsoleKey.Escape);