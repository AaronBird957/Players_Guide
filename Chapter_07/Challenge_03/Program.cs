int provinceScore = 6;
int duchieScore = 3;
int estateScore = 1;

Console.WriteLine("Enter the number of provinces you have:");
provinceScore *= int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of duchies you have:");
duchieScore *= int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of estates you have:");
estateScore *= int.Parse(Console.ReadLine());

Console.WriteLine("Total Score: " + (provinceScore + duchieScore + estateScore));