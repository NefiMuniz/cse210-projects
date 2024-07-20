using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Viking St", "Rexburd", "ID", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Central Avenue", "Salvador", "BA", "Brazil");

        // Create events
        Lecture lecture = new Lecture("Tech Talk", "A talk about the latest in tech.", "2024-08-01", "10:00 AM", address1, "Jane Doe", 100);
        Reception reception = new Reception("Company Party", "Annual company gathering.", "2024-08-05", "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Family-friendly outdoor event.", "2024-08-12", "2:00 PM", address3, "Sunny and warm");

        // Create a list of events
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
    }
}
