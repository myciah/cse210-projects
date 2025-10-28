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
        Outdoor TO = new Outdoor("Volleyball", "Bracket for the trophy", "10-27-2025", "6 pm", TA, "Rainy");
        Console.WriteLine(TO.GStandard());
        Console.WriteLine(TO.GFullOutdoor());
        Console.WriteLine(TO.GShort());
    }
}
 