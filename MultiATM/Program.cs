// See https://aka.ms/new-console-template for more information

using System;
using MultiATM;

public class Program
{
    public static void Main(string[] args)
    {
        Start();

        Console.ReadKey();
    }

    public static void Start()
    {
        ATMLanguage language = new EnglishLanguage();

        Console.WriteLine("Select your language 1. English 2. Pidgin 3. Native");
        string selectLanguageInput = Console.ReadLine();

        switch (selectLanguageInput)
        {
            case "1":
                language = new EnglishLanguage();
                break;
            case "2":
                language = new PidginLanguage();
                break;
            case "3":
                language = new NativeLanguage();
                break;
            default:
                Console.WriteLine("Please enter a valid language");
                Start();
                break;
        }

        ATM atm = new ATM(language);
        atm.Start();
    }
}

