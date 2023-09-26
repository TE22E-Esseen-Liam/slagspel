//WHILE-LOOP

int ironmanHP = 100;
int thanosHP = 100;

while (ironmanHP > 0 && thanosHP > 0)
{
Random generator = new Random();
int idmg = generator.Next(5, 15);
int tdmg = generator.Next(5, 15);

Console.WriteLine($"ironman {ironmanHP}");
Console.WriteLine($"thanos {thanosHP}");
ironmanHP -= idmg;
thanosHP -= tdmg;
Console.ReadKey();
}

if (ironmanHP < 0);
{
Console.WriteLine("Blod lost to thanos");
}

if (thanosHP < 0);
{
Console.WriteLine("You lost to ironman HAH");    
}


Console.ReadLine();