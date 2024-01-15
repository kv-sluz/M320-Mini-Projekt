using System.Collections.Generic;
using System.Linq;

public class Kennel
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public List<Animal> GetAnimals()
    {
        return animals;
    }

    public Animal FindAnimalById(string id)
    {
        return animals.FirstOrDefault(a => a.Id == id);
    }
}
