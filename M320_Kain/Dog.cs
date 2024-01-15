public class Dog : Animal
{
    public string Breed { get; private set; }

    public Dog(string id, string breed) : base(id)
    {
        Breed = breed;
    }

    public override string ToString()
    {
        return $"Hund [ID: {Id}, Rasse: {Breed}]";
    }
}
