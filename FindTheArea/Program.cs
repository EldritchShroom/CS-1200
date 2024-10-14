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
        // Ask user for length and width
        Console.Write("Enter the length: ");
        double length = double.Parse(Console.ReadLine()); // Convert from string to double

        Console.Write("Enter the width: ");
        double width = double.Parse(Console.ReadLine()); 

        double sum = (length * width); // Multiply the length and the width to get the area of the rectangle
        Console.WriteLine($"The area of the rectangle is {Math.Round(sum,2)}.");
        break;

    case "T":
    case "t":
        // Ask user for base and height
        Console.Write("Enter the base: ");
        double triangle_base = double.Parse(Console.ReadLine());

        Console.Write("Enter the height: ");
        double triangle_height = double.Parse(Console.ReadLine());

        double triangle_sum = (triangle_base * triangle_height) / 2;
        Console.WriteLine($"The area of this triangle is {Math.Round(triangle_sum,2)}.");
        break;
    
    case "C":
    case "c":
        // Ask user for radius
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());

        double circle_radius = Math.PI * Math.Pow(radius,2);

        Console.WriteLine($"The area of this circle is {Math.Round(circle_radius,2)}.");
        break;
    
    default:
        // Invalid input message or something, idk i just work here
        Console.WriteLine("Invalid input");
        break;
}