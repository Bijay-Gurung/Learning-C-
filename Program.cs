using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
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
// var scores = new List<int> {97,92,60,81,100};

// Defining Query Expression
// IEnumerable<int> scoreQuery = from score in scores where score > 80 orderby score descending select score;
/*
IEnumerable<string> scoreQuery = from score in scores where score > 80 orderby score descending select $"The score is {score}";
Console.WriteLine(scoreQuery.Count()); // Basically, it counts the data
*/
// Executing query
// foreach(int i in scoreQuery){
//     Console.WriteLine(i + " ");
// }

// foreach(string s in scoreQuery){
//     Console.WriteLine(s);
// }

// IEnumerable<int> scoreQuery = from score in scores where score > 80 orderby score descending select score;

// var scoreQuery = scores.Where(s => s> 80).OrderByDescending(s => s);

// List<int> myscores = scoreQuery.ToList();
// foreach(var score in myscores){
//     Console.WriteLine(score);
// }

//  return;

// Object Oriented Programming
// Using Encapsulation
// var p1 = new Person("Karma", "Gurung", new DateOnly(2004,04,23));
// var p2 = new Person("Bijay", "Gurung", new DateOnly(2061,01,11));

// List<Person> people = [p1,p2];
// Console.WriteLine(people.Count);
// public class Person
// {
//     public Person(string first, string last, DateOnly bd){
//         firstName = first;
//         lastName = last;
//         birthday = bd;
//     }
//     private string firstName;
//     private string lastName;
//     private DateOnly birthday;
// }

// public class Person(string firstname, string lastname, DateOnly birthday)
// {
//     public string First {get;} = firstname;
//     public string Last {get;} = lastname;
//     public DateOnly Birthday {get;} = birthday;
// }

// Learning Method
// class Program{
//     static void MyMethod(){
//         Console.WriteLine("I just got executed.");
//     }

//     static void Main(String[] args){
//         MyMethod();
//     }
// }

// Parameters & Arguments
// class Program{
//     static void MyMethod(string fname,int age){
//         Console.WriteLine(fname + " Gurung");
//         Console.WriteLine(age);
//     }

//     static void Main(String[] args){
//         MyMethod("Karma", 20);
//         MyMethod("Bijay", 20);
//         MyMethod("Kritan", 21);
//     }
// }

// Method Overloading
// class Program{
//     static int PulseMethodInt(int x, int y){
//         return x+y;
//     }

//     static double PulseMethodDouble(double x, double y){
//         return x+y;
//     }

//     static void Main(string[] args){
//         int mymethod1 = PulseMethodInt(5,2);
//         double mymethod2 = PulseMethodDouble(4.2, 7.5);

//         Console.WriteLine("Int "+mymethod1);
//         Console.WriteLine("Double "+mymethod2);
//     }
// }

// Object Oriented Programming(OOP)
// Classes and objects
// class Car{
//     public string color = "red";
// }

// class Program{
//      static void Main(string[] args){
//         Car myObj1 = new Car();
//         Car myObj2 = new Car();
//         Console.WriteLine(myObj1.color);
//         Console.WriteLine(myObj2.color);
//     }
// }

// Class Members
// class Car{
//     public string color = "red"; //Field
//     public int maxSpeed = 200; //Field
//     public void fullThrottle() //Method
//     {
//         Console.WriteLine("The car is going as fast as it can!");
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Car myObj1 = new Car(); 
//         Car myObj2 = new Car();

//         Console.WriteLine($"{myObj1.color} | {myObj1.maxSpeed}");
//         myObj1.fullThrottle();

//         Console.WriteLine($"{myObj2.color} | {myObj2.maxSpeed}");
//         myObj2.fullThrottle();
//     }
// }

// Class Constructor
// class Car{
//     public string model;

//     /*
//     Creating a Constructor
//     Constructor name must match class name and it doesn't have return type like void or int
//     */
//     public Car(){
//         model = "Mustang"; // Setting the initial value for model
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Car Ford = new Car(); // Constructor is called when the object is created
//         Console.WriteLine(Ford.model);
//     }
// }

// Constructor parameters
// class Car{
//     public string model;

//     /*
//     Creating a Constructor
//     Constructor name must match class name and it doesn't have return type like void or int
//     */
//     public Car(string modelName){
//         model = modelName; // Setting the initial value for model
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Car Ford = new Car("Mustang"); // Constructor is called when the object is created
//         Console.WriteLine(Ford.model);
//     }
// }

// Encapsulation
// class Person{
//     private string name; //Field

//     public Person(){ // Constructor
//         name = string.Empty;
//     }

//     public string Name //Property
//     {
//         get{return name;}
//         set{name = value;}
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Person myObj = new Person();
//         myObj.Name = "Karma";
//         Console.WriteLine(myObj.Name);
//     }
// }

// Inheritance
// class Vehicle // Base class (Parent Class)
// {
//     public string brand = "Ford"; // Field
//     public void honk() // Method
//     {
//         Console.WriteLine("Tuut, tuut!");
//     }
// }

// class Car : Vehicle{ // Derived Class (Child Class)
//     public string modelName = "Mustang";
// }

// class Program{
//     static void Main(string[] args){
//         Car myCar = new Car();
//         myCar.honk();
//         Console.WriteLine(myCar.brand +" "+ myCar.modelName);
//     }
// }

// Polymorphism
/* It means many form and it occurs when we have many classes that are related to each other by inheritance. */
// class Animal{
//     public virtual void animalSound(){
//         Console.WriteLine("The animals make a sound");
//     }
// }

// class Pig : Animal{
//     public override void animalSound(){
//         Console.WriteLine("The pig says: wee wee");
//     }
// }

// class Dog : Animal{
//     public override void animalSound(){
//         Console.WriteLine("The dog says: bow wow");
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Animal myAnimal = new Animal();
//         Pig myPig = new Pig();
//         Dog myDog = new Dog();

//         myAnimal.animalSound();
//         myPig.animalSound();
//         myDog.animalSound();
//     }
// }

// Abstraction
/*
It is the process of hiding certain details and showing only essential information to the user.
Abstract class is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class)

Abstract Method can only be used in abstract class, and it does not have a body. The body is provided by the derived class  (inherited from).
*/

// abstract class Animal{
//     public abstract void animalSound();
//     public void sleep(){
//         Console.WriteLine("Zzz");
//     }
// }

// class Pig : Animal{
//     public override void animalSound()
//     {
//         Console.WriteLine("The pig says: wee wee");
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Pig myPig = new Pig();
//         myPig.animalSound();
//         myPig.sleep();
//     }
// }

// Interface
// It is a complete abstract class which contain only abstract method and properties with empty bodies.
interface IAnimal{
    void animalSound();
    // void run(); // interface methods does not have a body.
}

class Pig : IAnimal{
    public void animalSound(){
        Console.WriteLine("The pig says: wee wee");
    }
}

class program{
    static void Main(string[] args){
        Pig myPig = new Pig();
        myPig.animalSound();
    }
}