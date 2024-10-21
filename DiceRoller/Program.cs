/*
    -Use an integer array to represent the 5 dice rolls. Place the result of each die-rolled into the array.
    -Use a Random object to simulate rolling the dice, generating random values between 1 and 6 (inclusive) for each die.
    -Display the initial roll of the dice, numbering each die from 1 to 5.
    -Prompt the user to enter the dice numbers they want to reroll, separated by commas (e.g., "2,4,5"). The user can also keep the current dice by leaving the prompt blank.
    -Allow the user to reroll up to two times. After each reroll, display the updated rolls.
    -Use at least one while, for, if, and switch statement.
    -Clear the screen between each prompt to keep the console output clean and readable.
    -You do not need to validate the user's reroll input for simplicity and time savings. If the user enters invalid data, it will cost them a reroll, but only ensure that the program does not crash due to bad input.
*/

// Initial roll, start with a do while loop

// Inside the loop we will initialize our integer array, it should look something like this int dice_array[] = new int[5]; 
int end_of_loop = 1;
do
{
    int[] dice_array = new int[5]; // Declare our integer array and set it to have five "spaces"
    int reRolls = 2;

    Random rand = new Random();

    for (int i = 0; i < dice_array.Length; i++)
    {
        dice_array[i] = rand.Next(1, 6);
    }
    
} while(end_of_loop != 0);
