/*
 Ask user for shape they want area for.

If user chose Rectangle, ask for width and length.

If user chose Triangle, ask for base and height.

if user chose Cirlce, ask for radius. 
*/


Console.Write("What type of shape (R)ectangle, (T)riangle, or (C)ircle? ");

string shape = Console.ReadLine();

switch(shape)
{
    case "R":
    case "r":
        // Ask user for width and length
    
    case "T":
    case "t":
        // Ask user for base and height
    
    case "C":
    case "c":
        // Ask user for radius
    
    default:
        // Invalid input message or something, idk i just work here
}