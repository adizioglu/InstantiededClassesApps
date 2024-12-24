#include "PersonModel.h"

int main()
{
    ConsoleAppCs::PersonModel person;
    person.firstName = "Ahmet";
    person.lastName = "Dizioglu";
    person.emailAddress = "adizioglu@gmail.com";

    std::cout << "Hello " << person.firstName << " " << person.lastName << "! Your email address is " << person.emailAddress << "." << std::endl;

    return 0;
}