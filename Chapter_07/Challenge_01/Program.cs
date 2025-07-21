Console.WriteLine("Input the triangle's base length:");
float baseLength = float.Parse(Console.ReadLine());

Console.WriteLine("Input the triangle's height:");
float height = float.Parse(Console.ReadLine());

float area = (baseLength * height) / 2;
Console.WriteLine("The area of the triangle is: " + area);