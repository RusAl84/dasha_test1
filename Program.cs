using Newtonsoft.Json;
using System;

namespace dasha_test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message firstMessage = new Message();

            Console.WriteLine(firstMessage);
            string json_string = JsonConvert.SerializeObject(firstMessage);
            Console.WriteLine(json_string);

            Message secondMessage = JsonConvert.DeserializeObject<Message>(json_string);
            Console.WriteLine(secondMessage);

        }
    }
}
