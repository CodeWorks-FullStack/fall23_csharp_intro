// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

// SECTION strings

// NOTE var is rarely used
var weirdThing = "Miles"; // Implicit type

string name = "Jeremy"; // Exlpicit type

Console.WriteLine(name);

char character = 'J';

string? otherName = null;

Console.WriteLine("this is otherName" + otherName);

Console.WriteLine($"Hello my name is {name}, and my name starts with {character}");

string multilineString = @"

I'm a multi-line string!

I have multiple lines!

";

Console.WriteLine(multilineString);

// !SECTION

// SECTION bools

bool likesCats = false;

bool likesRawTomateoes = false;

// if (likesCats == true)
// {

// }

if (likesCats)
{
  Console.WriteLine($"{name} likes cats");
}
else
{
  Console.WriteLine($"{name} hates cats");
}


// !SECTION

// SECTION numbers

int num = 7;

double numWithDecimals = 7.7;

int sum = num + 11;

Console.WriteLine(sum);

int weirdInt = 7 / 2; // 3
double weirdDouble = 7.0 / 2.0; // 3.5

int multiplied = 7 * 3;
Console.WriteLine(multiplied * 2);
multiplied += 100;
Console.WriteLine(multiplied);

// !SECTION

// SECTION loops

for (int i = 0; i < multiplied; i++)
{
  // Console.WriteLine($"i: {i}");
}

// int[] nums = { 1, 2, 3, 4, 5 };
int[] numbers = [1, 200, 3, 4, 5]; // Arrays suck, we don't use them

for (int i = 0; i < numbers.Length; i++)
{
  int number = numbers[i];
  Console.WriteLine($"Here is the number, {number}");
}
// foreach (int number in numbers)
// {
//   Console.WriteLine(number);
// }

List<string> fruits = [];
// List<string> fruits = new List<string>();
// List<string> fruits = ["Apple", "Pear"];

fruits.Add("Apple"); // arr.push("Apple")
fruits.Add("Banana");
fruits.Add("Pear");

foreach (string fruit in fruits)
{
  Console.WriteLine(fruit);
}

fruits.ForEach(fruit => Console.WriteLine(fruit));