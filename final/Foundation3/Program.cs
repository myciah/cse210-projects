using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation3 World!");
//     }
// }

//The following code is to test the Lecutre class
class Program
{
    static void Main(string[] args)
    {
        Address TA = new Address("123 XYZ Rd", "YYYYYY", "VA", "USA");
        Lecture TR = new Reception("Wedding", "Wedding Reception", "10-27-2025", "6 pm", TA, "@gmail.com");
        Console.WriteLine(TR.GStandard());
        Console.WriteLine(TR.GFullLecture());
        Console.WriteLine(TR.GShort());
    }
}
 