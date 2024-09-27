using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AssignmentManager
{
    public void AssignOrdersToFlights(List<Flight> flights, List<Order> orders)
    {
        foreach (var order in orders)
        {
            var assigned = false;

            foreach (var flight in flights)
            {
                if (flight.ArrivalCity == order.Destination && flight.Capacity > 0)
                {
                    Console.WriteLine($"Order: {order.OrderId}, FlightNumber: {flight.FlightNumber}, Departure: {flight.DepartureCity}, Arrival: {flight.ArrivalCity}, Day: {flight.Day}");
                    flight.Capacity--;
                    assigned = true;
                    break;
                }
            }

            if (!assigned)
            {
                Console.WriteLine($"Order: {order.OrderId}, flightNumber: not scheduled");
            }
        }
    }
}
