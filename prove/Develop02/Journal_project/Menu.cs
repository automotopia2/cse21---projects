using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

// The menu with actions or choices you can make

public class Menu
{
    private int _menuChoice;
    public int DisplayMenu()
    {
        Console.Write("Welcome to the journal! What would you like to do today? \n1) Create a new entry. \n2) Display your current entries.\n3) Load entries.\n4) Save entries.\n5) Delete entries.\n6) Exit journal.\nEnter the number correlating with your choice here: ");
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }

    public void WriteOption()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string promptfile = "prompts.txt";
        JournalProgram newEntry = new JournalProgram();

            PromptGen prompt1 = new PromptGen();
            prompt1.GetPrompt(promptfile);
            Console.Write(dateText + ": ");
            prompt1.DisplayPrompt();
            string response = Console.ReadLine();


            Entry entry = new Entry(dateText, prompt1._prompt, response);
            // string entry1 = entry.OrganizeEntry();

            newEntry.AddEntry(entry);
    }

    public void DisplayJournalOption()
    {
        
    }

    public void ReadMenu(int menuChoice)
    {
        if (menuChoice == 1)
        {
            WriteOption();
        }
        else if (menuChoice == 2)
        {
            
        }
        else if (menuChoice == 3)
        {
            
        }
        else if (menuChoice == 4)
        {
            
        }
        else if (menuChoice == 5)
        {
            
        }
        else if (menuChoice == 6)
        {
            Console.WriteLine("Thank you for using the journal program! Do something journal worthy today!");
        }
        else
        {
            
        }
    }
}
