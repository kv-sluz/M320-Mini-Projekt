using System;

public class Program
{
    public static void Main(string[] args)
    {
        Kennel kennel = new Kennel();
        UserInterface ui = new UserInterface(kennel);
        ui.Run();
    }
}

public class UserInterface
{
    private Kennel kennel;

    public UserInterface(Kennel kennel)
    {
        this.kennel = kennel;
    }

    public void Run()
    {
        bool exit = false;

        Console.WriteLine("Willkommen im Tierheim!");

        while (!exit)
        {
            Console.WriteLine("\nWählen Sie eine Option:");
            Console.WriteLine("1 - Tier hinzufügen");
            Console.WriteLine("2 - Alle Tiere anzeigen");
            Console.WriteLine("3 - Tier suchen");
            Console.WriteLine("4 - Programm beenden");

            switch (Console.ReadLine())
            {
                case "1":
                    AddDog();
                    break;
                case "2":
                    DisplayAllAnimals();
                    break;
                case "3":
                    FindAndDisplayAnimal();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe, bitte versuchen Sie es erneut.");
                    break;
            }
        }
    }

    private void AddDog()
    {
        Console.WriteLine("Geben Sie die ID des Hundes ein:");
        string id = Console.ReadLine();
        Console.WriteLine("Geben Sie die Rasse des Hundes ein:");
        string breed = Console.ReadLine();

        var dog = new Dog(id, breed);
        kennel.AddAnimal(dog);
        Console.WriteLine("Hund hinzugefügt.");
    }

    private void DisplayAllAnimals()
    {
        var animals = kennel.GetAnimals();
        if (animals.Count == 0)
        {
            Console.WriteLine("Keine Tiere im Tierheim.");
            return;
        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private void FindAndDisplayAnimal()
    {
        Console.WriteLine("Geben Sie die ID des Tieres ein, das Sie suchen:");
        string id = Console.ReadLine();
        var animal = kennel.FindAnimalById(id);

        if (animal != null)
        {
            Console.WriteLine(animal);
        }
        else
        {
            Console.WriteLine("Kein Tier mit der ID gefunden.");
        }
    }
}
