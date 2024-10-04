/* Writing my first hello world program */
Console.WriteLine("Hello, World!");

string firstName = "Karma";
string lastName = "Gurung";

/* Using String Interpolination */
Console.WriteLine($"My name is {firstName} {lastName}.");

/* Using String Typecasting */
Console.WriteLine("My name is " + firstName + " " + lastName + ".");

/* Using Trim method */

string fruit = "     Apple";
string toy = "Ball     ";
string pet = "     Cat     ";

Console.WriteLine($"{fruit.TrimStart()}\n{toy.TrimEnd()}\n{pet.Trim()}");