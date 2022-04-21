using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTests_Data.Context
{
    public class Mongo
    {

        private static Mongo _mongo;
        private readonly IMongoClient _mongoDbClient = null;
        private readonly IMongoDatabase _mongoDb = null;


        public IMongoCollection<Entities.Test.Test_Entity> _testEntity;
        public IMongoCollection<Entities.Cars.Cars_Entity> _carsEntity;

        public Mongo()
        {
            var Context = new MongoContext();

            _mongoDbClient = new MongoClient(Context.ConnectionString);
            _mongoDb = _mongoDbClient.GetDatabase(Context.DB_Name);


            _testEntity = _mongoDb.GetCollection<Entities.Test.Test_Entity>("TestEntity");
            _carsEntity = _mongoDb.GetCollection<Entities.Cars.Cars_Entity>("Cars");
        }

        public static Mongo GetMongo()
        {
            if (_mongo == null)
            {
                _mongo = new Mongo();
            }
            return _mongo;
        }

    }
}
