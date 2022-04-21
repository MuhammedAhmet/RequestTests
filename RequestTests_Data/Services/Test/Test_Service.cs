using MongoDB.Driver;
using RequestTests_Data.Context;
using RequestTests_Data.Entities.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTests_Data.Services.Test
{
    public class Test_Service : ITest_Service
    {
        private readonly IMongoCollection<Entities.Test.Test_Entity> _db;
        public Test_Service()
        {
            _db = Mongo.GetMongo()._testEntity;
        }

        #region Create
        public async Task Create(Test_Entity Data)
        {
            if (Data != null)
            {
                await _db.InsertOneAsync(Data);
            }
        }

        //public void Create(Test_Entity Data)
        //{
        //    if (Data != null)
        //    {
        //        _db.InsertOne(Data);
        //    }
        //}
        #endregion

        #region Get

        public async Task<List<Test_Entity>> Get()
        {

            var List = await _db.FindAsync(x => true).Result.ToListAsync();

            return List;

        }

        public async Task<Test_Entity> Get(string Id)
        {
            try
            {
                var Element = await _db.FindAsync(x => x.Id == Id).Result.FirstOrDefaultAsync();

                return Element;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //public List<Test_Entity> Get()
        //{
        //    return _db.Find(x => true).ToList();
        //}

        //public Test_Entity Get(string Id)
        //{
        //    try
        //    {
        //        return _db.Find(x => x.Id == Id).FirstOrDefault();

        //    }
        //    catch(Exception e)
        //    {
        //        return null;
        //    }
        //}

        #endregion

        #region Delete      

        public async Task Delete(string Id)
        {
            await _db.FindOneAndDeleteAsync(x => x.Id == Id);
        }

        //public void Delete(string Id)
        //{
        //    _db.FindOneAndDelete(x => x.Id == Id);
        //}
        #endregion

        #region Update
        public async Task Update(Test_Entity Data)
        {
            await _db.ReplaceOneAsync(x => x.Id == Data.Id, Data);
        }

        //public void Update(Test_Entity Data)
        //{
        //    _db.ReplaceOne(x => x.Id == Data.Id, Data);
        //}
        #endregion
    }
}
