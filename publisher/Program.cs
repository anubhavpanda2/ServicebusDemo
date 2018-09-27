using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
namespace publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            string sbconnstring = "connectionString";
            string queuename = "myq";
            QueueClient client = QueueClient.CreateFromConnectionString(sbconnstring, queuename);
            BrokeredMessage message = new BrokeredMessage("this is test message 1!");
            client.Send(message);
            Console.WriteLine("message sent successfully");
            Console.Read();

        }
    }
}
