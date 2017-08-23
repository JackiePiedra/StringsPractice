using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string firstName = "Jackie";
            string lastName = "Piedra";
            string fullName = string.Concat(firstName, " ", lastName); // Concat same as --> = firstName+" "+lastName
            Console.WriteLine(firstName.Length);
            Console.WriteLine(lastName.Length);
            Console.WriteLine(firstName[0]);
            Console.WriteLine(firstName[firstName.Length -1]); //index of 7 doesn't exist, it was out of bounds, so -1
            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Equals(lastName)); // same as --> (firstName == lastName)
            Console.WriteLine("My favorite book is \"The Notebook\""); //escape characters allows use of "" in the string

            //Trim() removes the white space at the beginning and end of a string
            //input a string
            string st = "  this is a sample    ";
            Console.WriteLine(st+"string."); //outputs the string as is

            st = st.Trim();  //use trim to eliminate the extra space at the end of initial string
            Console.WriteLine(st+" string.");

            string newLines = "This is a string \n\n\n";
            Console.WriteLine("["+newLines+"]");

            newLines = newLines.Trim();
            Console.WriteLine("[" + newLines + "]");

            //ToString() -- converting anything that is NOT a string to a string
            int num = 3;

            string newNum = num.ToString();
            Console.WriteLine(newNum.ToString());
            Console.WriteLine(newNum.GetType()); //GetType used here only to show that it was converted but not needed
            //can use math on num, will get error if .ToString is used because it is a string, can't do math on it
            */

            //.Length property -- find the length of first and last names
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("First is longer.");
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("Last must be longer!");
            }
            else
            {
                Console.WriteLine("Samesies!");
            }

            //escaping special characters
            Console.WriteLine("This is a tab \t. \nThis is a blackslash \\. \nThis is a new line. \nThis is a bell sound \a.");

            //comparing strings for equality using == and .Equals
            string nameA = "Sally";
            string nameB = "Joey";
            if(nameA == nameB)
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }
            if (nameA.Equals(nameB))
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

            //Concatenation -- using + and then .Equals()
            Console.WriteLine("Please enter your first name:");
            string nameFirst = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string nameLast = Console.ReadLine();
            string nameFull = nameFirst + " " + nameLast;
            Console.WriteLine(nameFull);
            string newNameFull = string.Concat(nameFirst," ",nameLast);
            Console.WriteLine(newNameFull);

            //ask user to guess type of pet(hint that it's the opposite of dog)
            //assign variable to the value of cat
            //use ToLower() and ToUpper() to ensure cat, CAT, Cat are all correct
            Console.WriteLine("Guess a type of pet (Hint: It's the opposite of dog):");
            string petGuess = Console.ReadLine().ToLower();
            string answer = "cat";
            //string finalGuess = petGuess.ToLower();
            if(petGuess == answer)
            {
                Console.WriteLine("You guessed correctly!");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly...");
            }
        }
    }
}
