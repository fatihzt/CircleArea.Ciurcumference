using System;
Console.WriteLine("-----------------------------------------");
Console.WriteLine("Calculating Circle Area and Circumference");
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Please enter a radius:");
var value = Console.ReadLine();
if (string.IsNullOrEmpty(value))
{
    Console.WriteLine("Please enter a integer number.");
    return;
}
if (int.TryParse(value, out int x))
{
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine("Please!!!1 enter a integer number ");
}
double radius = Convert.ToDouble(value);
double area = Math.PI * radius * radius;
Console.WriteLine("area is " + area);

double circum = 2 * Math.PI * radius;
Console.WriteLine("circumference is " + circum);
