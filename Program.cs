// See https://aka.ms/new-console-template for more information

Random random = new Random();
int hemligatalet= random.Next(1, 101);
int gissarätt = 1;
int antalgissningar = 0;


bool kor = true;
Console.WriteLine("gissa ett nummer mellan ett och hundra");

while(kor)
{
    gissarätt = Convert.ToInt32(Console.ReadLine());
    antalgissningar++;

    if (gissarätt == hemligatalet)
    {
        Console.WriteLine("Du gissade rätt och " + "du gissade " + antalgissningar);
        kor = false;
    }

    else if(gissarätt < hemligatalet)
    {
        Console.WriteLine("gissa ett högre nummer");
        kor = true;
    }

    else if (gissarätt > hemligatalet)
    {
        Console.WriteLine("gissa ett lägre nummer");
        kor = true;
    }

}
