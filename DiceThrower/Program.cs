using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling ThrowDice function and readkey
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            Console.ReadKey();
        }


        //Create a function called ThrowDice that takes a parameter of diceString
        static void ThrowDice(string diceString)
        {
            //Define variables
            var myStringNum = diceString.Split('d');
            var myDice = Convert.ToInt32(myStringNum[0]);
            var mySide = Convert.ToInt32(myStringNum[1]);
            //Make a randomTemp variable to plug into randomTemp.Next
            var randomTemp = new Random();

            //Prints Throwing: <diceSctring>
            //Prints Results: <randomSide>
            Console.WriteLine("Throwing: " + diceString);
            Console.Write("Results: ");
            //Create a for loop that counts the number of dice rolls
            for (int i = 1; i <= myDice; i++)
            {
                //Plugs in random number from 1 to the number of sides
                var randomSide = randomTemp.Next(1, mySide + 1);
                //Prints out all random numbers
                Console.Write(randomSide + " ");
            }
            //Makes it spaced better.
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}