Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("***********************************************");
Console.WriteLine("*            SQUID GAME                       *");
Console.WriteLine("*        Isgyvenimo zaidimas                  *");
Console.WriteLine("***********************************************");
Console.ResetColor();


Console.WriteLine(" ---       ---       ---       --- ");
Console.WriteLine("|   |     |   |     |   |     |   |");
Console.WriteLine("| 1 |     | 2 |     | 3 |     | 4 |");
Console.WriteLine("|   |     |   |     |   |     |   |");
Console.WriteLine("|___|     |___|     |___|     |___|");

Console.WriteLine("");
Console.Write("Pasirinkite duris: "); string door = Console.ReadLine();

bool next = false;
string space = "";

if (door == "1")
{
    Console.Clear();
    Console.WriteLine(@"  O  ");
    Console.WriteLine(@" /|\ ");
    Console.WriteLine(@" / \ ");
    Console.WriteLine("Ispreskite uzdavini:");
    Console.Write("50+50="); string inputTsk1 = Console.ReadLine();
    int tsk1 = Convert.ToInt32(inputTsk1);
    if (tsk1 == 100)
    {
        next = true;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.Write("Teisingai! Spauskite Enter, kad pereiti i Final Stage: "); space = Console.ReadLine();
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You are Dead!!!");
        Console.ResetColor();
        next = false;
    }
}
else if (door == "2")
{
    Console.Clear();
    Console.WriteLine("Kokia tai figura:");
    Console.WriteLine(" ---");
    Console.WriteLine("|   |");
    Console.WriteLine(" ---");
    Console.WriteLine("1-Trikampis");
    Console.WriteLine("2-Apskritimas");
    Console.WriteLine("3-Kvadratas");
    Console.Write("Tavo atsakymas yra..."); string inputTsk1 = Console.ReadLine();
    int tsk1 = Convert.ToInt32(inputTsk1);
    if (tsk1 == 3)
    {
        next = true;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.Write("Teisingai! Spauskite Enter, kad pereiti i Final Stage: "); space = Console.ReadLine();
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You are Dead!!!");
        Console.ResetColor();
        next = false;
    }

}
else if (door == "3")
{
    Console.Clear();
    Console.WriteLine("Parasykite programavimo kalba su kuria parasyta si programa:");
    Console.Write("Tavo atsakymas yra..."); string inputTsk1 = Console.ReadLine();
    if (inputTsk1 == "C#")
    {
        next = true;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.Write("Teisingai! Spauskite Enter, kad pereiti i Final Stage: "); space = Console.ReadLine();
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You are Dead!!!");
        Console.ResetColor();
        next = false;
    }
}
else if (door == "4")
{
    Console.Clear();
    Console.WriteLine("Ispreskite uzdavini:");
    Console.Write("2*2="); string inputTsk1 = Console.ReadLine();
    int tsk1 = Convert.ToInt32(inputTsk1);
    if (tsk1 == 4)
    {
        next = true;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.Write("Teisingai! Spauskite Enter, kad pereiti i Final Stage: "); space = Console.ReadLine();
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You are Dead!!!");
        Console.ResetColor();
        next = false;
    }
}

// Final stage

if (next == true && space == "")
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("*****************************************");
    Console.WriteLine("*            FINAL STAGE                *");
    Console.WriteLine("*****************************************");
    Console.ResetColor();
    Console.WriteLine("Imink misle:");
    Console.WriteLine("Be koju, be ranku duris atidaro");
    Console.Write("Kas? "); string inputTsk1 = Console.ReadLine();
    if (inputTsk1 == "Vejas" || inputTsk1 == "vejas")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@"  O  ");
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("You are winner!!!");
        Console.ResetColor();
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"  O  ");
        Console.ResetColor();
        Console.WriteLine(@" /|\ ");
        Console.WriteLine(@" / \ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You are Dead!!!");
        Console.ResetColor();
    }
}