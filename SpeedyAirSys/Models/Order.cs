using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    public class Order
    {
        public string OrderId { get; set; }
        public string Destination { get; set; }

        public Order(string orderId, string destination)
        {
            OrderId = orderId;
            Destination = destination;
        }

        public override string ToString()
        {
            return $"Order: {OrderId}, Destination: {Destination}";
        }
    }
 
