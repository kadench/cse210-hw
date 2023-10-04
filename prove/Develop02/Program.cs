using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Transactions;

class Journal
{
    // Menu
    static string JTPMenuMethod(){
        Console.WriteLine("Welcome to your electronic Journal!");
        Console.WriteLine("Enter 1 to write a new entry");
        Console.WriteLine("Enter 2 to show the dates you made entries");
        Console.WriteLine("Enter 3 to Save your Journal to a New File");
        Console.WriteLine("Enter 4 to Load a File");
        Console.WriteLine("Enter 0 to Exit this Program");
        string prompt = "";
        do{
        int number=Convert.ToInt32(Console.ReadLine());
        if (number == 1){
           prompt = "New Entry";
        }
        else if (number == 2){
            prompt = "Select an entry";
        }
        else if (number == 3){
            prompt = "Save your Journal";
        }
        else if (number == 4){
            prompt = "Load a file";

            // Save the new list to a variable called khLoadedFile.
            List<string> khLoadedFile = khLoadFile();
        }
        else if (number == 0){
            prompt = "Exit this program";
        }
        }
        while (prompt == "");
        return prompt;
    }
    // New Entry (The Return should be in the form of a dictionary 0 being date 1 being the entry Adam S.)
 
    // Select an Entry (A list of Dates should be created and prompted to the user. After they should be able to select the desired date Lisa H.)
 
    // Save Journal (Save the current journal into a CSV file Emma S.)
 
    // Load a File (It should return a list of entries in their given dictionaries from a CSV file in the same format that a saved file would be inserted. Olivia S.)
    static List<string> khLoadFile()
    // This method reads lines from a given file and
    // returns it as a string list.
    //
    // Parameters:
    // None.
    // 
    // Return:
    // Each line of a file as a string in a list.
    {   
        // Define a "temperary" list to house the file name in to carry it out of the while loop.
        List<string> khTemporaryStoreList = new List<string>();

        // Set a bool that changes when the file exists.
        bool khPathTrue = false;

        // Repeat the while loop until a correct file is given.
        while (khPathTrue == false)
        {
            // Ask the user for a filename to load. (We need to either have a set place for the files or they need to be in the same directory as the .cs file.) 
            Console.Write("Enter a file's name (ex. example.csv): ");
            string khFilePath = Console.ReadLine();

            // Check if the file exists
            if (File.Exists(khFilePath) == false)
            {
                // Warn the user if it doesn't
                Console.WriteLine("File does not exist or the path is invalid.");
            }
            else
            {
                // If the file exists, continue..
                khPathTrue = true;
                
                // Store the file name in the "temporary" list. 
                khTemporaryStoreList.Add(khFilePath);
            }
        }
        // Get the file name from the "temporary" list
        string khPath = khTemporaryStoreList[0];

        // Create a new string list.
        List<string> khFileLines = new List<string>();

        // Add every line from the file to the new string list.
        using (StreamReader reader = new StreamReader(khPath))
        {
        
            // The variable each line will be represented by
            string khLine;

            // While the line in the file isn't empty, or nothing..
            while ((khLine = reader.ReadLine()) != null)
            {   
                // Add the line to the string list.
                khFileLines.Add(khLine);
            }
        }

        // Once done, return the string list so that it can be manipulated later on in the program.
        return khFileLines;
    }
 
    // Exit this program (Done)
    static void Main(string[] args)
    {
        string menuPrompt = "";
        do{
        menuPrompt = JTPMenuMethod();
        Console.WriteLine("you have chosen to " + menuPrompt);
        Console.WriteLine("");}
        while(menuPrompt != "Exit this program");
    }
}