using Labb3;

class Program
{
    static void Main(string[] args)
    {

        Name name = new Name {FirstName ="Bosse", LastName ="Sten"};
        Gender gender = Gender.Male;
        Hair hair = new Hair {HairColour = "Brown", HairLength = 30};
        DateTime birthday = new DateTime(2003, 11, 10);
        string eyeColour = "Blue";

      
        Person person = new Person(gender, hair, birthday, eyeColour, name);

        Console.WriteLine(person.ToString());
        Console.ReadLine();


    }
}
