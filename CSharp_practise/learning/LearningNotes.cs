namespace Exercise.learning;

public class LearningNotes
{

using System.ComponentModel;

int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

Console.WriteLine(myText + myLetter);

int x = 5, y = 6, z = 50;

// int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
// long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
// double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
// bool	1 byte	Stores true or false values
// char	2 bytes	Stores a single character/letter, surrounded by single quotes
// string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes

// Casting
// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double
// int myInt = 9;
// double myDouble = myInt;

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char
// double myDouble = 9.78;
// int myInt = (int) myDouble; 

Console.WriteLine("Enter your age:");
string age = Console.ReadLine();
Console.WriteLine("Your age is: " + age);

double mathPow = Math.Pow(2, 3);
Console.WriteLine(mathPow);

string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
string conactenatedName = $"My full name is: {firstName} {lastName}";
string interpolatedName = firstName + lastName + "sdcsadcs";
string txt = "It\"s alright."; // escape character turns special characters into string characters

//if else

int time = 22;

if (time < 10) 
{
    Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
    Console.WriteLine("Good day.");
} 
else 
{
    Console.WriteLine("Good evening.");
}

//ternary operator of if else:
string result = (time < 18) ? "Good day." : "Good evening.";

// Switch
int day = 4;

switch (day) 
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
}

switch (day) 
{
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}

// break can save a lot of execution time because it "ignores" the execution of all the rest of the code in the switch block.
// default is optional

//while
int i = 0;
while (i < 5) 
{
    Console.WriteLine(i);
    i++;
}

//do while 
// will execute the code block ONCE, before checking if the condition is true, then it will repeat the loop as long as the condition is true.
do 
{
    Console.WriteLine(i);
    i++;
}
while (i < 5);


//for loop
for (int a = 0; a < 5; a++) 
{
    Console.WriteLine(a);
}

// Nested for loops 
// Outer loop
for (int b = 1; b <= 2; ++b) 
{
    Console.WriteLine("Outer: " + b);  // Executes 2 times

    // Inner loop
    for (int j = 1; j <= 3; j++) 
    {
        Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
    }
}

// foreach Loop
// exclusively to loop through elements in an array (or other data sets):
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string c in cars) 
{
    Console.WriteLine(c);
}

//break & continue can be in a loop as well

//ARRAY
// Create an array of four elements, and add values later
string[] cars1 = new string[4];

// Create an array of four elements and add values right away 
string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};

// Declare an array, later add values, must have new!
string[] cars5;
cars5 = new string[] {"Volvo", "BMW", "Ford"};

// Loop through array with for loop and Length OR foreach
for (int d = 0; d < cars.Length; d++) 
{
    Console.WriteLine(cars[i]);
}

// OR
foreach (string i in cars) 
{
    Console.WriteLine(i);
}

// Sort Array
Array.Sort(cars);
//in .NET using LINQ namespace
// using System;
// using System.Linq;
//
// namespace MyApplication
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] myNumbers = {5, 1, 8, 9};
//             Console.WriteLine(myNumbers.Max());  // returns the largest value
//             Console.WriteLine(myNumbers.Min());  // returns the smallest value
//             Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
//         }
//     }
// }

//two dimensional array - only by using comma!
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

//flat iterate 
foreach (int i in numbers)
{
    Console.WriteLine(i);
} 

//OR
for (int h = 0; h < numbers.GetLength(0); h++) 
{ 
    for (int j = 0; j < numbers.GetLength(1); j++) 
    { 
        Console.WriteLine(numbers[h, j]); 
    } 
}

// OVERLOADING = multiple methods can have the same name with different parameters
int PlusMethod(int x, int y)
{
    return x + y;
}

static double PlusMethod(double x, double y)
{
    return x + y;
}

// Constructor
// constructor name must match the class name, and it cannot have a return type

// Create a Car class
class Car
{
    public string model;
    public string color;
    public int year;

    // Class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    static void Mainn(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
}

// Outputs "Mustang"

// Access Modifier
// public	
// private - DEFAULT, within the same class
// protected - within the same class, or in a class that is inherited from that class
// internal - only accessible within its own assembly, but not from another assembly, (assembly = one .dll or .exe)
    
// getters/setters
class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Programm
{
    static void Mainn(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam"; // cannot do without set
        Console.WriteLine(myObj.Name); //cannot do without get
    }
}

//Inheritance
// - ":" - key symbol for Inheritance
- class Vehicle  // base class (parent) 
{
    public string brand = "Ford";
    public void honk()             
    {                    
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";
}

class Programm
{
    static void Mainn(string[] args)
    {
        Car myCar = new Car();

        myCar.honk();

        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}

// "sealed" keyword - If you don't want other classes to inherit from a class
sealed class Vehicle 
{
...
}

// polymorphysm - inherit fields and methods from another class

class Animal  // Base class (parent) 
{
    public void animalSound() 
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void animalSound() 
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void animalSound() 
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Programm
{
    static void Mainn(string[] args) 
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}

//virtual keyword -  override the base class method
// override keyword -   for each derived class methods

class Animal  // Base class (parent) 
{
    public virtual void animalSound() 
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public override void animalSound() 
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void animalSound() 
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Programm
{
    static void Mainn(string[] args) 
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}

// abstraction -  hiding certain details and showing only essential information
// Abstract class: is a restricted class that cannot be used to create objects
//                 to access it, it must be inherited from another class
// Abstract method: only be used in an abstract class, not have a body
//                  the body is provided by the derived class (inherited from).

abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Programm
{
    static void Mainn(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep();  // Call the regular method
    }
}

// interface ="abstract class", which can only contain abstract methods and properties (with empty bodies)
// C# does not support "multiple inheritance" (a class can only inherit from one base class).
// However, it can be achieved with interfaces, because the class can implement multiple interfaces

interface IAnimal 
{
    void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
    public void animalSound() 
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Programm
{
    static void Mainn(string[] args) 
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();
    }
}

//multiple interfaces
interface IFirstInterface 
{
    void myMethod(); // interface method
}

interface ISecondInterface 
{
    void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
    public void myMethod() 
    {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod() 
    {
        Console.WriteLine("Some other text...");
    }
}

class Programm
{
    static void Mainn(string[] args)
    {
        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();
    }
}

//     Feature	              Interface	Abstract Class
//     Multiple inheritance	✔ Yes	✖ No
//     Abstract methods	   ✔ Yes	✔ Yes
//     Regular methods	✔ (C# 8+ default)	✔ Yes
//     Fields	           ✖ No	✔ Yes
//     Constructors       	✖ No	✔ Yes
//     Purpose	Capability contract  	Base shared behavior

//Enums - special "class" that represents a group of constants
class Programm
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    static void Mainn(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);
    }
}

// The File class from the System.IO
using System.IO;

string writeText = "Hello World!";
File.WriteAllText("filename.txt", writeText);

string readText = File.ReadAllText("filename.txt");
Console.WriteLine(readText);

// AppendText()	Appends text at the end of an existing file
// Copy()	Copies a file
// Create()	Creates or overwrites a file
// Delete()	Deletes a file
// Exists()	Tests whether the file exists
// ReadAllText()	Reads the contents of a file
// Replace()	Replaces the contents of a file with the contents of another file
// WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

//Exceptions
// When an error occurs, C# will normally stop and generate an error message
// the technical term for this is: C# will throw an exception (throw an error).

    try
    {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}