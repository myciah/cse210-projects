public class Lecture : Event
{
    private string _speaker;
    private string _capacity;
    public Lecture(string speaker, string capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GFullLecture()
    {
        return ($"{GStandard()} - Type (Lecutere) Speaker: {_speaker} - Capacity: {_capacity}");
    }
}