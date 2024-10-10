// Ask for input from user
Console.Write("Enter a Response code: ");
int code = int.Parse(Console.ReadLine()); 

// We can not forget that the ReadLine method only returns string, use parse to change to integer.

// Console.Write("Code = {0}", code); // Small test to make sure the input is what I need it to be.

if (code < 100 || code >= 600) // Handle an invalid number input
{
    Console.WriteLine($"{code} is not a valid response.");
}

if (code >= 100 && code < 200) // Wanted to use switch but multiple if else statements will have to do.
{
    Console.WriteLine($"{code} is an Informational Response.");
}
else if (code >= 200 && code < 300)
{
    Console.WriteLine($"{code} is a Successful Response.");
}
else if (code >= 300 && code < 400)
{
    Console.WriteLine($"{code} is a Redirection Message.");
}
else if (code >= 400 && code < 500)
{
    Console.WriteLine($"{code} is a Client Error Response.");
}
else
{
    Console.WriteLine($"{code} is a Server Error Response");
}
