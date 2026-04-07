 using System;
 using System.Linq;
 using System.Collections.Generic;
 using System.Globalization;

// See https://aka.ms/new-console-template for more information
TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; // Create a TextInfo object based on the current culture
string name = "Moses Ette";

int counter = 1;
do
{//do while loop runs atleast once even if the condition is not met
    Console.WriteLine($"Hello World! \nThis is a simple Hello world program using C#\n");
    counter++;
} while (counter < 1);

string aboutMe = $@"I am {textInfo.ToTitleCase(name)},a software development student with a strong foundation in full‑stack web development and computer programming. 
I have earned BYU–Idaho certificates in frontend development, backend development, and programming, giving me hands-on experience building responsive user interfaces, server-side applications, and clean, maintainable code. 
I am passionate about solving real-world problems through technology and continually expanding my skillset as I work toward becoming a well‑rounded software engineer.";

List<string> names = ["Hiring Manager", "Ana", "Felipe"];
foreach (var person in names)
{
    
    if (person == "Hiring Manager")
    {
        Console.WriteLine($"Hello {person.ToUpper()}!");
        
            Console.WriteLine($"{aboutMe}\n");
    }
    Console.WriteLine($"Hello {person.ToUpper()}!");
}

/*
    practicing with tuples and records
*/
var pt = (x:1, y:2);
var slope = (double)pt.y / (double)pt.x;
Console.WriteLine($"The slope is {slope}");

pt.x = pt.x + 5;
Console.WriteLine($"The new pt value is {pt}");

var pt2 = pt with { x = 10 };
Console.WriteLine($"The new pt2 value is {pt2}");

// var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
// var person = (FirstName: "", LastName: "");
// var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);
// Console.WriteLine($"The order is for {order.quantity} {order.style} {order.Product} at a unit price of {order.UnitPrice:C}.");
// Console.WriteLine($"The named Data is:{namedData.Name} and Temperature: {namedData.Temp}.\n\n");


// Point pt3 = new Point(1, 1);
// var pt4 = pt3 with { Y = 10 };
// Console.WriteLine($"The two points are {pt3} and {pt4}");
// double slopeResult = pt4.Slope();
// Console.WriteLine($"The slope of {pt4} is {slopeResult}");



// for (int row = 1; row < 11; row++)
// {
//     for (char column = 'a'; column < 'k'; column++)
//     {
//         Console.WriteLine($"The cell is ({row}, {column})");
//     }
// }
// string name = "Moses Ette";
// string helloWorld = "\nHello World \n";

// Console.WriteLine(helloWorld.ToUpper());

// TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; // Create a TextInfo object based on the current culture


// Console.WriteLine($"{aboutMe}\n");




