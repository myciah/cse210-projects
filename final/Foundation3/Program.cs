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
        Lecture TL = new Lecture("Heidi Russell", 45);

        Console.WriteLine(TL.GFullLecture());
     }
 }