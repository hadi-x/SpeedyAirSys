using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FlightManager
{
    public List<Flight> LoadFlights()
    {
        return new List<Flight>
            {
                new Flight(1, "YUL", "YYZ", 1),
                new Flight(1, "YYZ", "YUL", 1),

                new Flight(2, "YUL", "YYC", 1),
                new Flight(2, "YYC", "YUL", 1),

                new Flight(3, "YUL", "YVR", 1),
                new Flight(3, "YVR", "YUL", 1),


                new Flight(4, "YUL", "YYZ", 2),
                new Flight(4, "YYZ", "YUL", 2),

                new Flight(5, "YUL", "YYC", 2),
                new Flight(5, "YYC", "YUL" ,2),

                new Flight(6, "YUL", "YVR", 2),
                new Flight(6, "YVR", "YUL", 2)
            };
    }

    public void DisplayFlights(List<Flight> flights)
    {
        foreach (var flight in flights)
        {
            Console.WriteLine(flight.ToString());
        }
    }
}

