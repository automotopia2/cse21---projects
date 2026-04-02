using System;

class Reception : Event
{
    // Variables
    private string _rsvpEmail;

    // Constructor
    public Reception(string rsvpEmail, DateTime dateTime, Address address) : base("An Evening of Elegance", "Join us for a sophisticated evening of fine dining, live music, and wonderful company. Celebrate the season with friends and colleagues in style!", dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public void DisplayRsvpEmail()
    {
        Console.WriteLine($"RSVP is required. RSVP at:\n{_rsvpEmail}");
    }
}