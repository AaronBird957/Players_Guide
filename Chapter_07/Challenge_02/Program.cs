Console.WriteLine("How many eggs did the 4 sisters collect?");
int eggs = int.Parse(Console.ReadLine());

int eggsPerSister = eggs / 4;
Console.WriteLine("Each sister gets: " + eggsPerSister + " eggs.");

int remainingEggs = eggs % 4;
Console.WriteLine("Remaining eggs after distribution: " + remainingEggs);