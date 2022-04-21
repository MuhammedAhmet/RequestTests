using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTests_Data.Entities.Cars
{
    public class Cars_Entity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Transmission { get; set; }
        public string MileAge { get; set; }
        public string Tax { get; set; }
        public string Mpg { get; set; }
        public string EngineSize { get; set; }

    }
}
