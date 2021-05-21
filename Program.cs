using System;

Console.Write("First Name> ");
string firstName = Console.ReadLine();

Console.Write("Last Name> ");
string lastName = Console.ReadLine();

// string initials = firstName[0] + " " + lastName[0];
// Console.WriteLine(initials);


Console.WriteLine(firstName + " " + lastName);

string reverse = string.Empty;
string fullName = firstName + " " + lastName;

for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse += fullName[i];
}
Console.WriteLine(reverse);