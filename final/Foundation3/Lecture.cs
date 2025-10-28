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

//The following code was used to test Lecture.cs in program.cs
//  class Program
//  {
//      static void Main(string[] args)
//      {
//         Address TA = new Address("123 XYZ Rd", "YYYYYY", "VA", "USA");
//         Lecture TL = new Lecture("Heidi Russell", 45, "Cosplay101", "Intro to cosplay", "10-27-2025", "6 pm", TA);
//         Console.WriteLine(TL.GStandard());
//         Console.WriteLine(TL.GFullLecture());
//         Console.WriteLine(TL.GShort());
//      }
//  }