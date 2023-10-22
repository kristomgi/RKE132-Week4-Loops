
Random random = new Random();
int cpuRandom;

bool loopAvtive = true;

while (loopAvtive)
{
    cpuRandom = random.Next(1, 4);
    //Console.WriteLine($"cpu ha generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopAvtive = false;
        break;
    } 
    else 
    {
        Console.WriteLine("Oops. Try again.");
     }

}
Console.WriteLine("Have a nice day!");