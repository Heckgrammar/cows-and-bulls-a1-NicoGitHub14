using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cows and Bulls Starter Framework Code
// Generate a four digit number with no repeating digits and not starting with zero
Random generator = new Random();
int[] digits = new int[4];

digits[0] = generator.Next(1, 10); 

for (int i = 1; i < 4; i++)
{
    int nextDigit;
    do
    {
        nextDigit = generator.Next(10);
    } while (Array.IndexOf(digits, nextDigit) != -1);

    digits[i] = nextDigit;
}
string number = string.Join("", digits);
Console.WriteLine(number); //take out later

//guess check
Console.WriteLine("Enter your 4-digit guess.");
string guess = Console.ReadLine();
// checks if it is correct length
if (guess.Length != 4)
{
    Console.WriteLine("Please enter a valid 4-digit number.");
    return;
}
//checks if user input can be converted to an int           
if (!int.TryParse(guess, out int parsedNumber))
{
    Console.WriteLine("Invalid input. Please enter a numeric value.");
    return;
}
//seperate numbers
int thousands = parsedNumber / 1000;
int hundreds = (parsedNumber / 100) % 10;
int tens = (parsedNumber / 10) % 10;
int units = parsedNumber / 10;
           
        }
    }
}
