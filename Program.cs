using System;
using System.Globalization;
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

// // Using Doubles, casting, float
// double a = 32.4;
// float b = 23.2f; // f is a suffix
// double c = a + b;
// Console.WriteLine(c);

// // typecasting
// int num1 = 5;
// float num2 = 2.4f;
// int num3 = num1 + (int)num2; // here i typecast float to int
// Console.WriteLine(num3);

// // decimal
// decimal x = 5.4m;
// decimal y = 10.2m;
// decimal result = x + y;
// Console.WriteLine(result);

// // using if statement
// int a = 5;
// int b = 6;
// int c = a+b;

// if(c > 10){
//     Console.WriteLine($"{c} is greater than 10.");
// }

// bool test = c > 10;

// if(test){
//     Console.WriteLine("The answer is greater than 10.");
// }else{
//     Console.WriteLine("The answer is less than 10.");
// }

// Using Comparison and logical operators

// if ((c > 10) /*&&*/ || (a==b)){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

// Using While Loop
// int count = 0;
// while(count <= 5){
//     Console.WriteLine(count);
//     count++;
// }

// Using do While loop
// int count = 0;

// do{
//     Console.WriteLine(count);
//     count++;
// }while(count < 5);

// for(int i=0; i<5; i++){
//     if(i==3){
//         Console.WriteLine(i);
//     }
// }

// Nested for loop
// for(int i=1; i<=5; i++){
//     for(int j=1; j<=i; j++){
//         Console.Write("*\t");
//     }
//     Console.WriteLine();
// }

// Managing Data Collections using list of T
// Using For each
// var is the local variable type inference
// var names = new List<string>
// {
//     "Karma",
//     "Mohan",
//     "Dolma",
//     "Maya",
//     "Nibin",
//     "Hero"
// };
// names.Add("Hero");
// names.Remove("Hero");
// foreach(var name in names){
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

/*
Console.WriteLine(names[names.Count-1]); // names[names.Count-1] will get the last name from the list
Console.WriteLine(names[^1]); // names[^1] it will also get the last name from the list
*/

// // Array Slicing
// var names = new string [] {"Jack", "Simon", "Ryan", "Monty", "Henry"};

// // adding name in array
// names[names.Length-1] = "Tenz"; 

// foreach(var name in names[2..5]){
//     Console.WriteLine(name);
// }

/*
// Sorting and Searching List
var names = new List<string> {"Jack", "Simon", "Ryan", "Monty", "Henry"};
// Before Sorting
Console.WriteLine(names.IndexOf("Ryan"));
// After Sorting
names.Sort();
Console.WriteLine(names.IndexOf("Ryan"));

foreach(var name in names){
    Console.WriteLine(name);
}
*/

// Language Integrated Query (LINQ)
var scores = new List<int> {97,92,60,81,100};

// Defining Query Expression
// IEnumerable<int> scoreQuery = from score in scores where score > 80 orderby score descending select score;
IEnumerable<string> scoreQuery = from score in scores where score > 80 orderby score descending select $"The score is {score}";
Console.WriteLine(scoreQuery.Count()); // Basically, it counts the data

// Executing query
// foreach(int i in scoreQuery){
//     Console.WriteLine(i + " ");
// }

foreach(string s in scoreQuery){
    Console.WriteLine(s);
}

 return;