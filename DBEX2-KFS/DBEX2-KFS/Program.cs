using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization;

namespace DBEX2_KFS
{
    class Program
    {
        static void Main(string[] args)
        {
            BsonClassMap.RegisterClassMap<Tweets>(cm =>
            {
                cm.AutoMap();
            });
            MainAsync().Wait();

            Console.ReadLine();
        }

        static async Task MainAsync()
        {

            var connectionString = "mongodb://192.168.33.10:27017";

            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("social_net");

            var collection = database.GetCollection<Tweets>("tweets");

            var list = await collection.Find(x => x.user == "Jack").ToListAsync();

            foreach (var item in list)
            {
                Console.WriteLine(item.user);
            }

            //Console.WriteLine(tweets.ToString());

            //var query = 

            //var list = await collection.Find(new tweets(x => x.user == "Jack").ToListAsync();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item["user"]);
            //}

            //tweets = await collection.Find(new BsonDocument()).FirstOrDefaultAsync();

            //var document = await collection.Find(new BsonDocument()).ToListAsync();

            //int bad = 0, neutral = 0, good = 0, unknown = 0;
            ////tweets.ElementAt(1).Equals(1);
            //foreach (var item in document)
            //{
            //    if (item.ElementAt(1).Value == 0)
            //    {
            //        bad += 1;
            //    }
            //    else if (item.ElementAt(1).Value == 2)
            //    {
            //        neutral += 1;
            //    }
            //    else if (item.ElementAt(1).Value == 4)
            //    {
            //        good += 1;
            //    }
            //    else
            //    {
            //        unknown += 1;
            //    }
            //    //Console.WriteLine(item.ElementAt(0).Value);
            //    //Console.WriteLine(item.ElementAt(1).Value);
            //    //Console.WriteLine(item.ElementAt(2).Value);
            //    //Console.WriteLine(item.ElementAt(3).Value);
            //    //Console.WriteLine(item.ElementAt(4).Value);
            //    //Console.WriteLine(item.ElementAt(5).Value);
            //    //Console.WriteLine(item.ElementAt(6).Value);
            //    //Console.ReadKey();
            //    //Console.WriteLine(item);
            //}
            //Console.WriteLine(bad);
            //Console.WriteLine(neutral);
            //Console.WriteLine(good);
            //Console.WriteLine(unknown);
            //Console.WriteLine(document.ToString());

            //var cursor = collection.Find(new BsonDocument()).ToCursor();

            //Console.WriteLine(cursor);

        }
    }
}
