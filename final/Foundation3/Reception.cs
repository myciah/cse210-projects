public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string desc, string date, string time, Address addr, string rsvpEmail)
        : base(title, desc, date, time, addr)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";
    }
    public override string GFull()
    {
        return ($"{GStandard()} - Type: {_eventType} - RSVP Email: {_rsvpEmail}");
    }
}

//The following code was used to test Reception.cs in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Address TA = new Address("123 XYZ Rd", "YYYYYY", "VA", "USA");
//         Reception TR = new Reception("Wedding", "Wedding Reception", "10-27-2025", "6 pm", TA, "@gmail.com");
//         Console.WriteLine(TR.GStandard());
//         Console.WriteLine(TR.GFullReception());
//         Console.WriteLine(TR.GShort());
//     }
// }