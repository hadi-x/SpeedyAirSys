using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class OrderManager
{
    public List<Order> LoadOrders(string fileName)
    {
        string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", fileName);
        var jsonData = File.ReadAllText(relativePath);
        var ordersDictionary = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonData);

        var orders = new List<Order>();
        foreach (var orderEntry in ordersDictionary)
        {
            var orderId = orderEntry.Key;
            var destination = orderEntry.Value["destination"];
            orders.Add(new Order(orderId, destination));
        }

        return orders;
    }
}

