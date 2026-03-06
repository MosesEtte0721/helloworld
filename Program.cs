 using System;
 using System.Linq;
 using System.Collections.Generic;
 using System.Globalization;

// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Threading.Tasks.Dataflow;


string name = "My name is Moses Ette";
string helloWorld = "\nHello World \n";
Console.WriteLine(helloWorld.ToUpper());

 TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; // Create a TextInfo object based on the current culture

string aboutMe = $@"I am {textInfo.ToTitleCase(name)},a software development student with a strong foundation in full‑stack web development and computer programming. 
I have earned BYU–Idaho certificates in frontend development, backend development, and programming, giving me hands-on experience building responsive user interfaces, server-side applications, and clean, maintainable code. 
I am passionate about solving real-world problems through technology and continually expanding my skillset as I work toward becoming a well‑rounded software engineer.\n";

Console.WriteLine($"{aboutMe}\n");




