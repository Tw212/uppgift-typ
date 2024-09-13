// See https://aka.ms/new-console-template for more information

Random random = new Random();
int hemligatalet= random.Next(1, 101);
int gissarätt = int.Parse(Console.ReadLine());


Console.WriteLine("gissa ett nummer mellan ett och hundra");
bool kor = true;
while(kor == true)
{
    Console.WriteLine("Skriv din gissning");
    gissarätt = Convert.ToInt32(Console.ReadLine());
if (gissarätt == hemligatalet)
{
    Console.WriteLine("Du gissade rätt " + " antalgissningar");
    kor = false;
}
 else if(gissarätt < hemligatalet)
 {
        Console.WriteLine("gissa ett högre nummer");
}

else if (gissarätt > hemligatalet)
{
    Console.WriteLine("gissa ett lägre nummer");
}
}
