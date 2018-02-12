using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEX2_KFS
{
    class MyInt32Serializer : SerializerBase<int>
    {
        public override int Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            var type = context.Reader.GetCurrentBsonType();
            switch (type)
            {
                case BsonType.Int32:
                    return context.Reader.ReadInt32();
                case BsonType.Int64:
                    return Convert.ToInt32(context.Reader.ReadInt64());
                case BsonType.Double:
                    return Convert.ToInt32(context.Reader.ReadDouble());
                case BsonType.String:
                    return int.Parse(context.Reader.ReadString());
                default:
                    var message = string.Format("Cannot convert a {0} to an Int32.", type);
                    throw new NotSupportedException(message);
            }
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, int value)
        {
            context.Writer.WriteInt32(value);
        }
    }
}
