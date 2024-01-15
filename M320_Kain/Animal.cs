public class Animal : IIdentifiable
{
    public string Id { get; private set; }

    public Animal(string id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return $"Tier ID: {Id}";
    }
}
