using System;
using Newtonsoft.Json;

namespace Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Alex", "Howdy", DateTime.Now);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializeMsg);
            //Console.WriteLine("Начало");
            //Console.WriteLine(msg.ToString());
        }
    }
}
