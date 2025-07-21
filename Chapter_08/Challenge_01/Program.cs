Console.Title = "Defense of Consolas";

Console.WriteLine("Target Row:");
int targetRowToProtect = int.Parse(Console.ReadLine());
Console.WriteLine("Target Column:");
int targetColumnToProtect = int.Parse(Console.ReadLine());

string topsquare = targetRowToProtect + 1 + "," + targetColumnToProtect;
string bottomsquare = targetRowToProtect - 1 + "," + targetColumnToProtect;
string leftsquare = targetRowToProtect + "," + (targetColumnToProtect - 1);
string rightsquare = targetRowToProtect + "," + (targetColumnToProtect + 1);

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({topsquare})");
Console.WriteLine($"({bottomsquare})");
Console.WriteLine($"({leftsquare})");
Console.WriteLine($"({rightsquare})");

Console.ForegroundColor = ConsoleColor.White;
