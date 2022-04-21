using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTests_Data.Context
{
    public class MongoContext
    {
        public MongoClient _client;
        public IMongoDatabase _db;

        public string ConnectionString = "";
        public string DB_Name = "";

        public MongoContext()
        {
            ConnectionString = "mongodb://" + Properties.Resources.MongoString;
            DB_Name = Properties.Resources.MongodbName;
        }
    }
}
