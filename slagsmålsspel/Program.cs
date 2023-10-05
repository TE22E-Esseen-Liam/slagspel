//WHILE-LOOP

int ironmanHP = 100;
int thanosHP = 100;

while (ironmanHP > 0 && thanosHP > 0)
{
Random generator = new Random();
int idmg = generator.Next(5, 15);
int tdmg = generator.Next(5, 15);

Console.WriteLine($"Ironman {ironmanHP}HP");
Console.WriteLine($"Thanos {thanosHP}HP");
Console.WriteLine("Press [ENTER] to continue");
Console.WriteLine("");
ironmanHP -= idmg;
thanosHP -= tdmg;
Console.ReadKey();
}

if (ironmanHP < 0)
{
Console.WriteLine("You lost to Thanos");
}

if (thanosHP < 0)
{
Console.WriteLine("You lost to Ironman");    
}


Console.ReadLine();