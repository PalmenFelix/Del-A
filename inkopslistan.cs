/*
Del A — Inköpslistan (listor) 
Skriv ett konsolprogram som håller reda på en inköpslista med namn och pris för varje vara. 
Eftersom vi inte använder objekt i den här delen håller du ihop datan med två parallella listor — en 
List<string> för namnen och en List<int> för priserna — där samma index hör ihop (names[i] kostar 
prices[i]). 
Programmet ska hela tiden visa listan som en numrerad lista med totalsumma, t.ex.: 
1. Mjölk - 15 kr 
2. Bröd - 32 kr 
3. Ost - 89 kr 
Totalt: 136 kr 
Input från användaren: 
En vara: skriv ett varunamn (text). Programmet frågar då efter priset (ett heltal) och lägger till varan 
sist i listan. Skriver användaren något som inte är ett heltal som pris ska varan inte läggas till. 
Ett nummer: varan på den positionen tas bort ur listan (både namn och pris). 
Om användaren anger ett nummer som inte finns i listan ska programmet säga till i stället för att 
krascha. 
Extra (frivilligt, påverkar inte betyget): 
● Ordet dyrast skriver ut vilken vara som är dyrast. 
● Sortera listan efter pris. 
Repo och inlämning för del A 
Ett publikt GitHub-repo. Del A behöver inget C#-projekt — det räcker med en enda .cs-fil med din 
lösning (kör den med dotnet <fil>.cs). 
Frekventa commits med begripliga meddelanden — historiken ska visa hur du byggde upp lösningen, 
inte en enda stor "final"-commit. 
Krav för godkänt (del A) 
[ ] Programmet kör i en loop och visar hela tiden listan som en numrerad lista med totalsumma. 
[ ] Man kan lägga till en vara (namn + pris) sist i listan. 
[ ] De två listorna hålls i synk — tar man bort en vara försvinner både namn och pris. 
[ ] Man kan ta bort en vara genom att ange dess nummer. 
[ ] Ett pris som inte är ett heltal, eller ett nummer som inte finns, hanteras utan att programmet 
*/

List<string> items = []; // List for items

List<int> prices = []; // List for prices

while (true)
{
    Console.WriteLine("Skriv ett varunamn: "); // Fråga efter en vara
    string? iteminput = Console.ReadLine()!;

    while(true)
    {
        Console.WriteLine("Skriv ett pris: ");
        int priceinput; // Fråga efter priset på en vara

        if (int.TryParse(Console.ReadLine(), out priceinput)) // Kollar att int är ett heltal
        {
            items.Add(iteminput); // Lägger till vara och pris
            prices.Add(priceinput);
            break;
        }
        else
        {
            Console.WriteLine("Skriv ett giltligt pris\n"); // Skrivs om int inte är ett heltal
        }
    }    

    for (int i = 0; i < items.Count; i++)
    {
    Console.WriteLine($"{i + 1}. {items[i]} - {prices[i]} kr"); // Skriver ut vara och pris 
    }
}