// MIS 3033 002
// September 6, 2023
// Abigail Pidgeon, 113515288

using a;

Console.WriteLine("Interface");//class interface

Person p1;

p1 = new Person();
p1.name = "Abigail Pidgeon";
p1.dob = new DateTime(2002, 8, 27);
p1.weight = 150;// in lbs
// this is on branch 1
Console.WriteLine(p1.dob.ToString("MMM dd, yyyy")); 
