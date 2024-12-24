Namespace ConsoleAppCs
    Public Class PersonModel
        Public firstName As String
        Public lastName As String
        Public emailAddress As String

        Public Property FirstName2 As String
        Public Property LastName2 As String
        Public Property EmailAddress2 As String
        Public Property HasBeenGreeted As Boolean

        Public Shared Sub GreetPerson(person As PersonModel)
            Console.WriteLine($"Hello {person.FirstName2} {person.LastName2}")
            person.HasBeenGreeted = True
        End Sub
    End Class
End Namespace

