
using System;
using System.Numerics;

////// EMNE 3.1

////Console.WriteLine("a" == "a");
////Console.WriteLine("a" == "A");
////Console.WriteLine(1 == 2);

////string myValue = "a";
////Console.WriteLine(myValue == "a");

////string pangram = "The quick brown fox jumps over the lazy dog.";
////Console.WriteLine(pangram.Contains("fox"));
////Console.WriteLine(pangram.Contains("cow"));

//////The following code sample demonstrates the use of the != operator:

////int a = 7;
////int b = 6;
////Console.WriteLine(a != b); // output: True
////string s1 = "Hello";
////string s2 = "Hello";
////Console.WriteLine(s1 != s2); // output: False

////Condional Operator

////< evaluate this condition > ? <if condition is true, return this value > : <if condition is false, return this value >

////int saleAmount = 1001;
//// int discount = saleAmount > 1000 ? 100 : 50;

////Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

////FLIP COIN

////Random coin = new Random();
////int flip = coin.Next(0, 1);
////Console.WriteLine((flip == 0) ? "heads" : "tails");

////Complete a challenge activity using Boolean expressions

////string permission = "Admin|Manager";
////int level = 55;

////if (permission.Contains("Admin"))
////{
////    if(level > 55)
////    {
////        Console.WriteLine("Welcome, Super Admin user.");
////    }
////    else
////    {
////        Console.WriteLine("Welcome, Admin User");
////    }
////}
////else if (permission.Contains("Manager"))
////{
////    if (level >= 20)
////    {
////        Console.WriteLine("Contact Admin for acess");
////    }
////    else
////    {
////        Console.WriteLine("You do not have sufficent privileges");
////    }
////}

//// EMNE 3.2 Control variable scope and logic using code blocks in C#

////1. Create a variable inside of a code block

////bool flag = true;
////int value = 0;
////if (flag)
////{

////    Console.WriteLine($"Inside the code block: {value}");
////}
////value = 10;
////Console.WriteLine($"Outside the code block: {value}");

//// Code sample 2
////int value;

////if (true)
////{
////    value = 10;
////    Console.WriteLine($"Inside the code block: {value}");
////}

////Console.WriteLine($"Outside the code block: {value}");




////2 Remove code blocks from if statements

////bool flag = true;
////if (flag)
////    Console.WriteLine(flag);

////string name = "steve";

////if (name == "bob")
////    Console.WriteLine("Found Bob");
////else if (name == "steve")
////    Console.WriteLine("Found Steve");
////else
////    Console.WriteLine("Found Chuck");



//// 3 Exercise - Complete a challenge activity using variable scope

////int[] numbers = { 4, 8, 15, 16, 23, 42 };

////foreach (int number in numbers)
////{
////    int total;

////    total += number;

////    if (number == 42)
////    {
////        bool found = true;
////    }

////}

////if (found)
////{
////    Console.WriteLine("Set contains 42");

////}

////Console.WriteLine($"Total: {total}");


////int[] numbers = { 4, 8, 15, 16, 23, 42 };
///*/*int total = 0; */*/// Move the declaration outside the loop
///*bool found = false;*/ // Move the declaration outside the loop

//////foreach (int number in numbers)
//////{
//////    total += number;

//////    if (number == 42)
//////    {
//////        found = true; // Update the value of 'found'
//////    }
//////}

//////if (found)
//////{
//////    Console.WriteLine("Set contains 42");
//////}

//////Console.WriteLine($"Total: {total}");




//////// 3.3 Exercise - Implement a switch statement


//////int employeeLevel = 100;
//////string employeeName = "John Smith";

//////string title = "";

//////switch (employeeLevel)
//////{
//////    case 100:
//////    case 200:
//////        title = "Senior Associate";
//////        break;
//////    case 300:
//////        title = "Manager";
//////        break;
//////    case 400:
//////        title = "Senior Manager";
//////        break;
//////    default:
//////        title = "Associate";
//////        break;
//////}

//////Console.WriteLine($"{employeeName}, {title}");


//// Exercise - Complete a challenge activity using switch statements


//// SKU = Stock Keeping Unit. 
//// SKU value format: <product #>-<2-letter color code>-<size code>
////string sku = "02-BL-S";

////string[] product = sku.Split('-');

////string type = "";
////string color = "";
////string size = "";

////switch (product[0])
////{
////    case "01":
////        type = "Sweat shirt";
////        break;
////    case "02":
////        type = "T-shirt";
////        break;
////    case "03":
////        type = "Sweat pants";
////        break;
////    default:
////        type = "Other";
////        break;

////}

////switch (product[1])
////{
////    case "BL":
////        color = "Black";
////        break;
////    case "MN":
////        color = "Maroon";
////        break;
////        default :
////        color = "White";
////        break;
////}

////switch (product[2])
////{
////    case "S":
////        size = "Small";
////        break;
////    case "M":
////        size = "Medium";
////        break;
////    case "L":
////        size = "Large";
////        break;
////    default:
////        size = "One Size fits All";
////        break ;
////}

////Console.WriteLine($"Product: {type}, {color}, {size}");






//// Exercise - Create and configure for iteration loops

////for (int i = 0; i < 10; i++)
////{
////    Console.WriteLine(i);
////}

////for(int i = 0; i<10;i++)
////{
////    Console.WriteLine(i);
////    if (i == 7) break;
////}

////string[] names = { "Alex", "Eddie", "David", "Michael" };
////for (int i = names.Length - 1; i >= 0; i--)
////{
////    Console.WriteLine(names[i]);
////}

////string[] names = { "Alex", "Eddie", "David", "Michael" };

////for (int i = 0; i < names.Length; i++)
////{
////    if (names[i] == "David")
////    {
////        names[i] = "Sammy";
////    }
////}

////foreach (var name in names)
////{
////    Console.WriteLine(name);
////}




////Exercise - Complete a challenge activity using for and if statements


for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);

    if (i % 3 == 0)
    {
        Console.WriteLine(i + " fizz");
    }
    if (i % 5 == 0)
    {
        Console.WriteLine(i + "Buzz");
    }
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + "Fizzbuzz");
    }
}