
using System.Runtime.CompilerServices;

string input;

Console.Write("Please enter a letter: ");
input = Console.ReadLine();

string letter = String.ToUpper(input);

switch (letter)
{
    case A:
    case E: 
    case I:
    case O:
    case U: 
        Console.WriteLine("Vowel");
        break;
    case Y:
        Console.WriteLine("Maybe");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}