using System;

namespace Maxwell_Deliverable2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for integer input 

            Console.WriteLine("Please enter an integer value between 1 and 100");

            // Validate users response is an integer and not a character 

            try
            {
                // This variable will gather data from user input

                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements and is parsed as an integer

                int value_of_input = int.Parse(input);

                // If the value of user input is between 1 and 100

                if ((value_of_input > 0) && (value_of_input <= 100))
                {

                    // For Loop iterates the number of times == to user input

                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered number " + input.ToString());
                    }

                    //Display end of program prompt for user 

                    Console.WriteLine("Press any key to exit the program ...");

                    // Pause the program and await the user to press a key to end the program

                    Console.ReadKey(true);
                }
                else
                {
                    // Make sure user does not enter 0 value or value greater than 100

                    Console.WriteLine("The integer must be greater than 0 and less than or equal to 100.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input, please enter and integer.");
            }
        }
    }
}
