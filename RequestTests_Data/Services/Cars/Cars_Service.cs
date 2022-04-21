using MongoDB.Driver;
using RequestTests_Data.Context;
using RequestTests_Data.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTests_Data.Services.Cars
{
    public class Cars_Service : ICars_Service
    {
        private readonly IMongoCollection<Entities.Cars.Cars_Entity> _db;
        public Cars_Service()
        {
            _db = Mongo.GetMongo()._carsEntity;
        }

        #region Create
        public async Task Create(Cars_Entity Data)
        {
            if (Data != null)
            {
               await _db.InsertOneAsync(Data);
            }

        }

        public async Task CreateMany(List<Cars_Entity> Data)
        {
            if (Data != null)
            {
               await _db.InsertManyAsync(Data);
            }
        }
        #endregion

        #region Get
        public async Task<List<Cars_Entity>> Get()
        {
            return await _db.FindAsync(x => true).Result.ToListAsync();
        }

        public async Task<Cars_Entity> Get(string Id)
        {
            return await _db.FindAsync(x => x.Id == Id).Result.FirstOrDefaultAsync();
        }

        #endregion

        #region Delete      
        public async Task Delete(string Id)
        {
            await _db.FindOneAndDeleteAsync(x => x.Id == Id);
        }
        #endregion

        #region Update
        public async Task Update(Cars_Entity Data)
        {
            await _db.ReplaceOneAsync(x => x.Id == Data.Id, Data);
        }
        #endregion

        //#region Create
        //public void Create(Cars_Entity Data)
        //{
        //    if (Data != null)
        //    {
        //        _db.InsertOne(Data);
        //    }

        //}

        //public void CreateMany(List<Cars_Entity> Data)
        //{
        //    if (Data != null)
        //    {
        //        _db.InsertMany(Data);
        //    }
        //}


        //#endregion

        //#region Get
        //public List<Cars_Entity> Get()
        //{
        //    return _db.Find(x => true).ToList();
        //}

        //public Cars_Entity Get(string Id)
        //{
        //    return _db.Find(x => x.Id == Id).FirstOrDefault();
        //}

        //#endregion

        //#region Delete      
        //public void Delete(string Id)
        //{
        //    _db.FindOneAndDelete(x => x.Id == Id);
        //}
        //#endregion

        //#region Update
        //public void Update(Cars_Entity Data)
        //{
        //    _db.ReplaceOne(x => x.Id == Data.Id, Data);
        //}
        //#endregion
    }
}