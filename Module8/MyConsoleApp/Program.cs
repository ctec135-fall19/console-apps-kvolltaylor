/* 
 Katrina Voll-Taylor
 CTEC 135: C#
 12 November 2019

 Programming Assignment: Console Apps: Problem 1

    1. Create a Console App named "MyConsoleApp"
    2. Write code in Main() that:
        a. Tests the length of the args array. If the length is zero, 
                output a message to that affect.
        b. If the length is greater than zero, output each argument on a 
                separate line in the form of:
                > command: <command line argument>
    3. Run the program to test. It should print your message that there are 
            no arguments
    4. Right-click the project and select the properties (at the bottom of 
            the list)
            a. In the dialog select the Debug tab on the left
            b. In the Command Line Arguments field enter several words 
            separated by spaces as well as several more words with double 
            quotes at the beginning and end. Something of the form:
                one two three "one two three"
    5. Run the program again. You should see the individual arguments printed 
            on separate lines and the quoted string printed together on the same 
            line.
    6. As a separate test open a command window (cmd.exe), navigate to the 
            location of your exe for this project, then run the program with 
            several words following the program name
                >MyConsoleApp one two three "one two three"
    7. You should get the same output, but this is an example of how your program 
            would be used in the field as compared to testing it in the 
            development environment.
    8. Take a screenshot of the command window after running your program. 
            Save it in a Word file. Keep the file open as we will use it for 
            prob 2.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyConsoleApp
{
    class Program
    {
        static int Main(string[] args)

            // Input: 4 arguments in properties
            // Process: logic to test if 0 args, or to iterate through the args if there
            // Output: print out if 0 arts or all the arts

        {

            if (args.Length == 0)
            {
                Console.WriteLine("There are zero args currently!");
            }
            else
            {
                foreach (string arg in args)
                {
                    Console.WriteLine("-> command: {0}", arg);
                }
            }

            Console.ReadLine();
            return -1;

        }
    }
}
