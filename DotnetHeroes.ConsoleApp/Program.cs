
namespace DotnetHeroes;


class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Id = 2,
            Name = "James"
        };

        Console.WriteLine(person.Name);
        Console.WriteLine(person.Id);
        Console.WriteLine(person.DateCreated);

        Console.WriteLine($"my name is {person.Name} and my id is {person.Id}");
    }

    class Person : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

    }

    class Animal : BaseEntity
    {
        public string Color { get; set; } = string.Empty;
    }

    class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated = DateTime.UtcNow;
    }
}