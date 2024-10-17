using System;

using System.Collections.Generic;

class Program
{
    static List<string> inventory = new List<string>();
    
    static void Main(string[] args)

    {
        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");
        inventory.Add("Truck");
        inventory.Add("Monster-Truck");
        inventory.Add("Tuc-Tuc");
        while (true)
        {
            Console.WriteLine("\nVälj en åtgärd:");

            Console.WriteLine("1. Lägg till produkt");

            Console.WriteLine("2. Visa inventarie");

            Console.WriteLine("3. Avsluta");

            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    LäggTillProdukt();
                    Pause();
                    break;
                case "2":
                    VisaInventarie();
                    Pause();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
    static void LäggTillProdukt()
    {
        Console.Clear();
        Console.WriteLine("Vad för produkt vill du lägga till?");
        string? item = Console.ReadLine();
        // TODO: Implementera metod för att lägga till produkt 
    }

    static void VisaInventarie()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            // TODO: Implementera metod för att visa inventarie 
            Console.WriteLine(inventory[i]);
        }
    }
    static void Pause()
    {
        Console.WriteLine("Tryck Enter för att gå vidare");
        Console.ReadLine();
        Console.Clear();
    }
}