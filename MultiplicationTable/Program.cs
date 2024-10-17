/* 
    User need to input number for beginning of rows and end of rows
    User need to input number for beginning of columns and end of columns 

    User nested loops for rows and columns
*/

// Get user input for row and column ranges
Console.Write("Enter starting value for rows: ");
int row_start = int.Parse(Console.ReadLine());

Console.Write("Enter ending value for rows: ");
int row_end = int.Parse(Console.ReadLine());

Console.Write("Enter starting value for columns: ");
int col_start = int.Parse(Console.ReadLine());

Console.Write("Enter the ending value for columns: ");
int col_end = int.Parse(Console.ReadLine());

// Print the column headers
Console.Write("\t");
for (int j = col_start; j <= col_end; j++)
{
    Console.Write($"{j}\t");
}
Console.WriteLine();
Console.WriteLine("================================================");

// Print each row of the multiplication table
for (int i = row_start; i <= row_end; i++)
{
    Console.Write($"{i}\t"); // Print the row header
    for (int j = col_start; j <= col_end; j++)
    {
        Console.Write($"{i * j}\t"); // Print the product of i and j
    }
    Console.WriteLine(); // Move to the next row
}