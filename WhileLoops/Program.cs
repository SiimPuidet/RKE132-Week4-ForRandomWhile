Random rnd = new Random();
int cpuRandom;
bool loopActive = true;
while(loopActive) //Järgnev tsükkel kestab seni, kuni kasutaja arvab arvuti genereeritud numbri ära - loopActive=True
{
    cpuRandom = rnd.Next(1, 4); //Arvuti genereerib juhusliku numbri vahemikus 1-3
    Console.WriteLine("Make a guess. Enter a number 1-3:"); //Kasutajalt küsitakse pakkumist, millise numbri on arvuti genereerinud
    int userNumber = Int32.Parse(Console.ReadLine()); //Kasutaja sisestab numbri ja arvuti genereerib selle numbri kujule
    if (userNumber == cpuRandom) //Kui kasutaja arvab õige numbri ära...
    {
        Console.WriteLine("Congratulations, you won!"); //... siis kasutajat õnnitletakse
        //loopActive = false; //Üks variant, et programm väljuks silmusest ehk ei paluks uuesti arvata
        break; //Teine variant silmuse lõpetamiseks, mis töötas ka switch käsuga
    }
    else // Kui kasutaja arvamus ei ole õige...
    {
        Console.WriteLine("Oops. Try again."); //...palutakse kasutajal uuesti proovida.
    }
    Console.WriteLine($"Right answer is: {cpuRandom}"); //Kasutajale näidatakse õiget vastust.
}
Console.WriteLine("Have a nice day!");