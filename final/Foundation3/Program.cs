using System;
class Program
 {
     static void Main(string[] args)
     {
        Address A1 = new Address("123 Elysian blvd", "Krat", "CVDL", "France");
        Address A2 = new Address("456 Malum Ave", "Slums", "Corsica", "France");
        Address A3 = new Address("789 Tower Isle", "Alchemist Island", "Occitanie", "France");

        Event lecture = new Lecture("Lorenzini Venigni", 10, "A New Era", "Learning about advanced technology", "10-27-2025", "7:00 PM", A1);
        Event reception = new Reception("Reunion", "Carlo and Lea", "11-28-2025", "4:00 PM", A2, "Pulcinella@VenigniWorks.com");
        Event outdoor = new Outdoor("Sparring Session", "Test the Monad's Rose Sword", "12-29-2025", "9:00 AM", A3, "Snowey");

        List<Event> E = new List<Event>
        {
            lecture,
            reception,
            outdoor
        };
        
        foreach (Event i in E)
        {
            Console.WriteLine("Standard Details: ");
            Console.WriteLine(i.GStandard());
            Console.WriteLine();
            Console.WriteLine("Full Details: ");
            Console.WriteLine("Blank");
            Console.WriteLine();
            Console.WriteLine("Short Description: ");
            Console.WriteLine(i.GShort());
        }
     }
}
