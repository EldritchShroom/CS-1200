﻿/*
    Prompt the user for total purchase price
    Prompt user for tax rate

    Use proper format codes and string interpolation for currenct and other symbols

    Result should be outputted with the purchase price, tax rate %, amount of tax, and the total owed.
*/

// Ask user for the sub_total amount before taxes
Console.Write("Enter the purchase price: ");
decimal sub_total = decimal.Parse(Console.ReadLine());

// Console.WriteLine($"Sub total is {sub_total}");

// Ask the user for the tax rate
Console.Write("Enter the tax rate: ");
decimal tax_rate = decimal.Parse(Console.ReadLine()); // tax_rate needs to be set to a decimal and not an int

// Console.WriteLine($"Tax rate is {tax_rate}");

// Calculate the of tax that needs to be paid, use the tax_rate and sub_total

decimal taxes = sub_total * (tax_rate / 100);

decimal total = (sub_total + taxes);

Console.WriteLine($"For your {sub_total:C2} purchase, a {tax_rate}% tax is {taxes:C2} for a total of {total:C2}");