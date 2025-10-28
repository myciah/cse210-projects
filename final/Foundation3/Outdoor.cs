public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string desc, string date, string time, Address addr, string weather);
        base : (title, desc, date, time, addr)
        {
            _weather = weather;
        }
        public string GFullOutdoor()
        {
    ($"{GStandard()} - Type: {_eventType} - Weather: {_weather}");
        }
}