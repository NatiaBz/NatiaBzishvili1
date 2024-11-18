

public interface IAnimal
{
    string MakeSound();  // yvela cxovels eqneba sakutari xma
}

public abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    // cxovelis konstruqtori romelic igebs asaks da saxels
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // MakeSound 
    public abstract string MakeSound();  // TiToeulisTvis sakuTari xmis minicheba
}

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    // Dog xma
    public override string MakeSound()
    {
        return "Woof";
    }
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Cat xma
    public override string MakeSound()
    {
        return "Meow";
    }
}

public class Cow : Animal
{
    public Cow(string name, int age) : base(name, age) { }

    // CowZroxis xma
    public override string MakeSound()
    {
        return "Moo";
    }
}

public class Program
{
    public static void Main()
    {
        // IAnimaltipis masivi
        IAnimal[] animals = new IAnimal[]
        {
            new Dog("Buddy", 3),
            new Cat("Whiskers", 2),
            new Cow("MooMoo", 5)
        };

        // yvela cxovelis saxeli da xma
        foreach (IAnimal animal in animals)
        {
            // vbechdavt yvela cxovelis saxels da xmas
            Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
        }
    }
}
