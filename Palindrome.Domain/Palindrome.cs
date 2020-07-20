using System;

namespace Palindrome.Domain
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            string initial = "";
            Console.WriteLine("Enter a string");
            string userinput = Console.ReadLine();
            int userinputLength = userinput.Length;
            if (userinputLength == 0)
            {
                Console.WriteLine("Please enter a string");

            }

            else

            {

                for (int j = userinputLength - 1; j >= 0; j--)
                {
                    initial = initial + userinput[j];
                }

                if (initial == userinput)
                {
                    Console.WriteLine(userinput + " is palindrome");
                }
                else
                {
                    Console.WriteLine(userinput
                        + " is not a palindrome");
                }


                Console.Read();
            }
        }
    }

}