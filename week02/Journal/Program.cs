using System;
// EXCEEDING REQUIREMENTS:
// I added two features to exceed the core requirements: First, prompts are removed 
// once displayed so the user never gets asked the same question twice in a session. 
// Second, I updated the save/load format with commas and quotes so the files can 
// be saved and opened as either standard text files or Excel .csv spreadsheets.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int opt = 0;
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        while ( opt != 5 || opt > 5 )
        {
            Console.WriteLine("Please select one of the following choices:");
            string[] options = ["Write", "Display", "Load", "Save", "Quit"];

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.Write("What would you like to do? ");
            opt = int.Parse(Console.ReadLine());
            

            if (opt == 1)
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();

                Entry myEntry = new Entry();

                myEntry._entryText = answer;
                myEntry._promptText = prompt;

                myJournal.AddEntry(myEntry);
            }
            else if ( opt == 2)
            {
                myJournal.DisplayAll();
            }
            else if ( opt == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }
            else if ( opt == 4 )
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
        }
    }
}