
ConsoleAppCs.PersonModel person = new ConsoleAppCs.PersonModel();
person.firstName = "Ahmet";
person.lastName = "Dizioglu";
person.emailAddress = "adizioglu@gmail.com";

Console.WriteLine($"Hello {person.firstName} {person.lastName}! Your email address is {person.emailAddress}.");

ConsoleAppCs.PersonModel secondperson = new ConsoleAppCs.PersonModel();
secondperson.firstName = "Mehmet";
secondperson.lastName = "Dizioglu";
secondperson.emailAddress = "mdizioglu@gmail.com";

Console.WriteLine($"Hello {secondperson.firstName} {secondperson.lastName}! Your email address is {secondperson.emailAddress}.");

List<ConsoleAppCs.PersonModel> people = new List<ConsoleAppCs.PersonModel>();

person.firstName = "Ahmet";
person.lastName = "Dizioglu";
person.emailAddress = "adizioglu@gmail.com";
people.Add( person );

person = new ConsoleAppCs.PersonModel();  //???
person.firstName = "Mehmet";
person.lastName = "Dizioglu";
person.emailAddress = "mdizioglu@gmail.com";
people.Add(person);

foreach (ConsoleAppCs.PersonModel p in people)
{
    Console.WriteLine($"Hello {p.firstName} {p.lastName}! Your email address is {p.emailAddress}.");

}

List<ConsoleAppCs.PersonModel> people2 = new List<ConsoleAppCs.PersonModel>();
string firstName = "";
do
{
    Console.Write("What is your first name (or type exit to stop): ");
    firstName = Console.ReadLine();

    Console.Write("What is your last name: ");
    string lastName = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        ConsoleAppCs.PersonModel person2 = new ConsoleAppCs.PersonModel();
        person2.FirstName2 = firstName;
        person2.LastName2 = lastName;
        people.Add(person2);
    }
} while (firstName.ToLower() != "exit");

foreach (ConsoleAppCs.PersonModel p in people)
{
    Console.WriteLine($" {p.FirstName2} {p.LastName2}!");
}

foreach (ConsoleAppCs.PersonModel p in people)
{
    ConsoleAppCs.PersonModel.GreetPerson(p);
}


Console.ReadLine();
