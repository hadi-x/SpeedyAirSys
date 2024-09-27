using Newtonsoft.Json;
 

class Program
{
    static void Main(string[] args)
    {
        var flightManager = new FlightManager();
        var orderManager = new OrderManager();
        var assignmentManager = new AssignmentManager();

        var flights = flightManager.LoadFlights();
        Console.WriteLine("Flight Schedule:");
        flightManager.DisplayFlights(flights);

        var orders = orderManager.LoadOrders("orders.json");
        Console.WriteLine("\nOrders:");
        assignmentManager.AssignOrdersToFlights(flights, orders);

        //foreach (var flight in flights)
        //{
        //    Console.WriteLine($"Capacity: {flight.Capacity} , FlightNumber: {flight.FlightNumber}, Departure: {flight.DepartureCity}, Arrival: {flight.ArrivalCity}, Day: {flight.Day}");
        //}
    }
}