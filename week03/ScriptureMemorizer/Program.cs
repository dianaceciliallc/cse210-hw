using System;
// Enhancement: 
// I added a prompt at the beginning of the program
// that lets the user choose to use hints, displaying 
// the first letter of each hidden word to make
// memorization easier.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 4, 29);
        string text = "And it came to pass that I called after them, and they did hear me; wherefore they did cease to flee from my presence.";
        Scripture myScripture = new Scripture(reference, text);

        Console.WriteLine("Do you want to use hints (first letter)? (y/n):");
        string response = Console.ReadLine().Trim().ToLower();

        bool useHint = false;
        
        if (response == "y")
        {
            useHint = true;
        }

        while(true)
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText(useHint));
            Console.WriteLine();

            if( myScripture.IsCompletelyHidden() )
            {
                Console.WriteLine("You has memorized all the scripture!");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string keep = Console.ReadLine();
            
            if ( keep == "quit")
            {
                break;
            }
            else if ( keep == "")
            {
                Random random = new Random();
                int randomWords = random.Next(1, 5);

                myScripture.HideRandomWords(randomWords);
            }
            else
            {
                break;
            }
        }
    }
}