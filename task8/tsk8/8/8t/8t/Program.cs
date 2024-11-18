//

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // konstruqtori, romelic parametrad igebs name da age
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // SevqmnaT Person klasis obieqti konstruqtoris saSualebit
        Person person = new Person("Natia", 39);

        // vaCveoT obieqtis monacemebi
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");

        // SevcvaloT obieqtis monacemebi
        person.Name = "Vakho";
        person.Age = 40;

        // vachvenot ganaxlebulil monacmeebi
        Console.WriteLine($"Updated Name: {person.Name}");
        Console.WriteLine($"Updated Age: {person.Age}");
    }
}
