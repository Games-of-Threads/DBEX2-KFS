using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEX2_KFS
{
    class Tweets
    {
        [BsonElement("_id")]
        public ObjectId _id { get; set; }

        [BsonElement("polarity")]
        public int polarity { get; set; }

        [BsonElement("id")]
        public int id { get; set; }

        [BsonElement("date")]
        public string date { get; set; }

        [BsonElement("query")]
        public string query { get; set; }

        [BsonElement("user")]
        public string user { get; set; }

        [BsonElement("text")]
        public string text { get; set; }
    }
}
