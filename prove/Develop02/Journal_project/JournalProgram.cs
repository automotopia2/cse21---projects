using System;
using System.Runtime.CompilerServices;


class JournalProgram
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    
    static void Main(string[] args)
    {
        int menuChoice = 99;
        while(menuChoice != 6)
        {
            // Run the Menu
            Menu menu = new Menu();

            menuChoice = menu.DisplayMenu();
            menu.ReadMenu(menuChoice);



            // PromptGen prompt1 = new PromptGen();
            // prompt1.GetPrompt(promptfile);
            // Console.Write(dateText + ": ");
            // prompt1.DisplayPrompt();
            // string response = Console.ReadLine();


            // Entry entry = new Entry(dateText, prompt1._prompt, response);

        }
    }    
    
}
