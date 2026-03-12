using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;




public class Entry
{
    
    // Variables 
    private string _prompt;
    private string _date;
    private string _response;
    // private string _entry;

    // Constructor
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }   

    // Getters
    public string GetDate()
    {
        return _date;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public string GetResponse()
    {
        return _response;
    }

    // Methods
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}: {_prompt}\n{_response}\n");
    }   
}