using System;

class Kh_program
{
    static void Main(string[] args)
    {
    kh_DisplayWelcome();
    string kh_users_name = kh_PromptUserName();
    int kh_users_int = kh_PromptUserNumber();
    int kh_squared_users_number = kh_SquareNumber(kh_users_int);
    kh_DisplayResult(kh_squared_users_number, kh_users_name);
    }

    static void kh_DisplayWelcome()
    // Displays welcome message to the user.
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string kh_PromptUserName()
    // Asks the user what their name is and then that is returned to main as the kh_users_name variable.
    {
        Console.Write("What is your name?: ");
        string kh_users_name = Console.ReadLine(); 
        return kh_users_name;
    }
    
    static int kh_PromptUserNumber()
    // Asks the user what their favorite number is and then that is returned to main as the kh_users_int variable.
    {
        Console.Write("What is your favorite number?: ");
        string kh_users_favorite_number = Console.ReadLine();
        int kh_users_int = int.Parse(kh_users_favorite_number); 
        return kh_users_int;
    }
    
    static int kh_SquareNumber(int kh_users_favorite_number)
    // Takes the users favorite number, squares it, and returns it to main as the kh_squared_users_number variable.
    {
        int kh_squared_users_number = kh_users_favorite_number * 2;
        return kh_squared_users_number;
    }
    
    static void kh_DisplayResult(int kh_squared_users_number, string kh_users_name)
    // Takes the users name and squared favorite number that are now stored in variables found in main and is displayed to the user as a formatted string.
    {
        Console.WriteLine($"{kh_users_name}, the sqare of your number is {kh_squared_users_number}");
        
    }


}