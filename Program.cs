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

/* Searching String */
firstName = firstName.Replace("Karma", "Bijay"); // using replace method to replace name Karma to Bijay. 
Console.WriteLine(firstName);

// Searching
string text = "Something is better than nothing.";
Console.WriteLine(text.Contains("better"));

Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());
Console.WriteLine($"The Length of text is {text.Length}.");
Console.WriteLine(text.StartsWith("Something"));