using System.ComponentModel.DataAnnotations;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
// Generates a prompt for the person
public class PromptGen2
{
    // Variables
    public string _prompt;

    private Random _randint = new Random(); 
    
    // Methods
    public void GetPrompt(string promptFile)
    {
        string[] prompts = File.ReadAllLines(promptFile);
        int randint = _randint.Next(prompts.Length);
        
        string unfilteredPrompt = prompts[randint];

        string[] parts = unfilteredPrompt.Split("|"); 
        
        _prompt = parts[0]; 
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"-- {_prompt} --");
    }
    public void DisplayPromptQuestion()
    {
        Console.Write(_prompt);
    }   
}