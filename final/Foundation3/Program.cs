using System;

class Program
{
    static void Main(string[] args)
    {
    // INPUT //
        // Lecture
        DateTime dateTimeL = new DateTime(2026, 3, 4, 15, 30, 0);
        Address addressL = new Address("123 Main St", "Springfield", "IL");
        Lecture lecture = new Lecture("David Man", 50000, dateTimeL, addressL);

        // Reception
        DateTime dateTimeR = new DateTime(2026, 7, 3, 12, 15, 0);
        Address addressR = new Address("456 Elm St", "Shelbyville", "TN");
        Reception reception = new Reception("floridaman@washington.com", dateTimeR, addressR);

        // OutdoorGathering
        DateTime dateTimeOG = new DateTime(2026, 6, 25, 20, 00, 0);
        Address addressOG = new Address("789 Oak Ave", "Greenville", "TX");
        OutdoorGather outdoorGather = new OutdoorGather("70 degrees and sunny with 2mph wind.", dateTimeOG, addressOG);

    // OUTPUT //
        // Lecture
        lecture.DisplayIntro();
        lecture.DisplaySpeakCap();
        lecture.DisplayWhenWhere();

        reception.DisplayIntro();
        reception.DisplayRsvpEmail();
        reception.DisplayWhenWhere();

        outdoorGather.DisplayIntro();
        outdoorGather.DisplayWeather();
        outdoorGather.DisplayWhenWhere();
    }
}