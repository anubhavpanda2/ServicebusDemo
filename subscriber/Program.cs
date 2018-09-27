using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
namespace subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            string sbconnstring = "connectionstring";
            string queuename = "myq";
            QueueClient client = QueueClient.CreateFromConnectionString(sbconnstring, queuename);
            client.OnMessage(msg => {
                Console.WriteLine($"{msg.MessageId} body {msg.GetBody<string>()}");
            });
            Console.ReadKey();
        }
    }
}
