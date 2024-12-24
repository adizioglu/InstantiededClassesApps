
namespace ConsoleAppCs
{
    public class PersonModel
    {
        public string firstName;
        public string lastName;
        public string emailAddress;

        public string FirstName2 { get; set; }
        public string LastName2 { get; set; }
        public string EmailAddress2 { get; set; }
        public bool HasBeenGreeted { get; set; }

        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName2} {person.LastName2}");
            person.HasBeenGreeted = true;
        }


    }
}
