using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        //standards for password 
        int minLength = 8;

        string uppercasePattern = "[A-Z]";
        string lowercasePattern = "[a-z]";
        string digitsPattern = "[0-9]";
        // exclude spaces from special chars with \s
        string specialCharsPattern = "[^A-Za-z0-9\\s]";

        Regex uppercase = new Regex(uppercasePattern);
        Regex lowercase = new Regex(lowercasePattern);
        Regex digits = new Regex(digitsPattern);
        Regex specialChars = new Regex(specialCharsPattern);


        // ask user to set password
        Console.WriteLine("Enter your new password: ");
        string password = Console.ReadLine();

        // score password for standards
        int score = 0;

        if (password.Length >= minLength) {
            score++;
        }
        
        if (uppercase.IsMatch(password)) {
            score++;
        }
        
        if (lowercase.IsMatch(password)) {
            score++;
        }
        
        if (digits.IsMatch(password)) {
            score++;
        }
        
        if (specialChars.IsMatch(password)) {
            score++;
        }

        if (password=="password"||password=="1234") {
            score = 0;
        }

        switch (score) {
            case >= 4:
                Console.WriteLine("Password is extremely strong.");
                break;
            case 3:
                Console.WriteLine("Password is strong.");
                break;
            case 2: 
                Console.WriteLine("Password is medium strength.");
                break;
            case 1:
                Console.WriteLine("Password is weak.");
                break;
            default:
                Console.WriteLine("Password doesn't meet any standards.");
                break;
        }
    }
  }
}
