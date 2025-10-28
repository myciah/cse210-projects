public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string desc, string date, string time, Address addr, string weather)
        : base(title, desc, date, time, addr)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }
    public override string GFull()
    {
        return ($"{GStandard()} - Type: {_eventType} - Weather: {_weather}");
    }
}

//The following code was used to test Outdoor.cs in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Address TA = new Address("123 XYZ Rd", "YYYYYY", "VA", "USA");
//         Outdoor TO = new Outdoor("Volleyball", "Bracket for the trophy", "10-27-2025", "6 pm", TA, "Rainy");
//         Console.WriteLine(TO.GStandard());
//         Console.WriteLine(TO.GFullOutdoor());
//         Console.WriteLine(TO.GShort());
//     }
// }