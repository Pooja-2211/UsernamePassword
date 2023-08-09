using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UsernamePassword
{
    static void Main()
    {
        const string validUsername = "Pooja";
        const string validPassword = "Modi";
        int maxAttempts = 3;

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (username == validUsername && password == validPassword)
            {
                Console.WriteLine("Login successful!"); //for the first time if the user writes correct details
                break; // Exit the loop if login is successful
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                int attemptsLeft = maxAttempts - attempt;
                if (attemptsLeft > 0)
                {
                    Console.WriteLine("You have {0} attempts left.", attemptsLeft);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You have exceeded the maximum number of attempts.");
                    Console.WriteLine("Login failed.");
                }
            }
        }
    }
}