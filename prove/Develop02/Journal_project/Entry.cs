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

    // Functions
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }   

    public void DisplayEntry()
    {
        Console.WriteLine($"\n{_date}: {_prompt}\n{_response}\n");
    }   
    
    public void SetInfo(string date, string prompt, string response)
    {
        _response = response;
        _date = date;
        _prompt = prompt;
    }
}