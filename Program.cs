// /* Writing my first hello world program */
// Console.WriteLine("Hello, World!");

// string firstName = "Karma";
// string lastName = "Gurung";

// /* Using String Interpolination */
// Console.WriteLine($"My name is {firstName} {lastName}.");

// /* Using String conCatination */
// Console.WriteLine("My name is " + firstName + " " + lastName + ".");

// /* Using Trim method */

// string fruit = "     Apple";
// string toy = "Ball     ";
// string pet = "     Cat     ";

// Console.WriteLine($"{fruit.TrimStart()}\n{toy.TrimEnd()}\n{pet.Trim()}");

// /* Searching String */
// firstName = firstName.Replace("Karma", "Bijay"); // using replace method to replace name Karma to Bijay. 
// Console.WriteLine(firstName);

// // Searching
// string text = "Something is better than nothing.";
// Console.WriteLine(text.Contains("better"));

// Console.WriteLine(text.ToUpper());
// Console.WriteLine(text.ToLower());
// Console.WriteLine($"The Length of text is {text.Length}.");
// Console.WriteLine(text.StartsWith("Something"));

// Using Number integers and Maths
// int a = 5;
// int b = 6;
// int c;
// c = a + b;
// Console.WriteLine(c);

// int a = 50000000;
// int b = 60000000;
// // long c = (long)a + (long)b; // to deal with massive numbers we can use long.

// long c = checked(a+b); // It check the numbers are overflowed or not. signed integer (-).
// Console.WriteLine(c);

// Using Doubles, casting, float
double a = 32.4;
float b = 23.2f; // f is a suffix
double c = a + b;
Console.WriteLine(c);

// typecasting
int num1 = 5;
float num2 = 2.4f;
int num3 = num1 + (int)num2; // here i typecast float to int
Console.WriteLine(num3);

// decimal
decimal x = 5.4m;
decimal y = 10.2m;
decimal result = x + y;
Console.WriteLine(result);

