Imports System
Imports System.Collections.Generic

Module Program
    Sub Main()
        Dim person As New ConsoleAppCs.PersonModel()
        person.firstName = "Ahmet"
        person.lastName = "Dizioglu"
        person.emailAddress = "adizioglu@gmail.com"

        Console.WriteLine($"Hello {person.firstName} {person.lastName}! Your email address is {person.emailAddress}.")

        Dim secondperson As New ConsoleAppCs.PersonModel()
        secondperson.firstName = "Mehmet"
        secondperson.lastName = "Dizioglu"
        secondperson.emailAddress = "mdizioglu@gmail.com"

        Console.WriteLine($"Hello {secondperson.firstName} {secondperson.lastName}! Your email address is {secondperson.emailAddress}.")

        Dim people As New List(Of ConsoleAppCs.PersonModel)()

        person.firstName = "Ahmet"
        person.lastName = "Dizioglu"
        person.emailAddress = "adizioglu@gmail.com"
        people.Add(person)

        person = New ConsoleAppCs.PersonModel() '???
        person.firstName = "Mehmet"
        person.lastName = "Dizioglu"
        person.emailAddress = "mdizioglu@gmail.com"
        people.Add(person)

        For Each p As ConsoleAppCs.PersonModel In people
            Console.WriteLine($"Hello {p.firstName} {p.lastName}! Your email address is {p.emailAddress}.")
        Next

        Dim people2 As New List(Of ConsoleAppCs.PersonModel)()
        Dim firstName As String = ""
        Do
            Console.Write("What is your first name (or type exit to stop): ")
            firstName = Console.ReadLine()

            Console.Write("What is your last name: ")
            Dim lastName As String = Console.ReadLine()

            If firstName.ToLower() <> "exit" Then
                Dim person2 As New ConsoleAppCs.PersonModel()
                person2.FirstName2 = firstName
                person2.LastName2 = lastName
                people.Add(person2)
            End If
        Loop While firstName.ToLower() <> "exit"

        For Each p As ConsoleAppCs.PersonModel In people
            Console.WriteLine($" {p.FirstName2} {p.LastName2}!")
        Next

        For Each p As ConsoleAppCs.PersonModel In people
            ConsoleAppCs.PersonModel.GreetPerson(p)
        Next

        Console.ReadLine()
    End Sub
End Module

