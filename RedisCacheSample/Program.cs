using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = ConnectionMultiplexer.Connect("YOUR CONNECTION STRING");
            var db = connection.GetDatabase();

            // Add something to the cache
            db.StringSet("key", "value");

            // Get value from cache
            var value = db.StringGet("key");

            Console.WriteLine("Value = " + value);

            Console.ReadKey();

        }
    }
}
