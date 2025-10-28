public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string desc, string date, string time, Address addr, string weather)
        : base(title, desc, date, time, addr)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }
        public string GFullOutdoor()
    {
        return ($"{GStandard()} - Type: {_eventType} - Weather: {_weather}");
    }
}