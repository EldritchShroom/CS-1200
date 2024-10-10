Random rand = new Random();

int randomNumber = rand.Next(1, 6);

int randomNumberTwo = rand.Next(1, 6);

if(randomNumber == 1 && randomNumberTwo == 1)
{
    Console.WriteLine($"You rolled {randomNumber},{randomNumberTwo}");
    Console.WriteLine("Snake Eyes!");
}
else if (randomNumber == 6 && randomNumberTwo == 6)
{
    Console.WriteLine($"You rolled {randomNumber},{randomNumberTwo}");
    Console.WriteLine("Box Cars!");
}
else 
{
    int sum = randomNumber + randomNumberTwo;
    Console.WriteLine($"You rolled {randomNumber},{randomNumberTwo}");
    Console.WriteLine(sum);
}
