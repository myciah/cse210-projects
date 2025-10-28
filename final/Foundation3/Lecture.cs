public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string title, string desc, string date, string time, Address addr)
        : base(title, desc, date, time, addr)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }
    public string GFullLecture()
    {
        return ($"{GStandard()} - Type (Lecture) Speaker: {_speaker} - Capacity: {_capacity}");
    }
}