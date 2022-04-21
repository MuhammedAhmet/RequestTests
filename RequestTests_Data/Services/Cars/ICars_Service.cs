using RequestTests_Data.Entities.Cars;

namespace RequestTests_Data.Services.Cars
{
    public interface ICars_Service
    {
        Task Create(Cars_Entity Data);
        Task CreateMany(List<Cars_Entity> Data);
        Task<List<Cars_Entity>> Get();
        Task<Cars_Entity> Get(string Id);
        Task Delete(string Id);
        Task Update(Cars_Entity Data);


        //void Create(Cars_Entity Data);
        //void CreateMany(List<Cars_Entity> Data);
        //List<Cars_Entity> Get();
        //Cars_Entity Get(string Id);
        //void Delete(string Id);
        //void Update(Cars_Entity Data);
    }
}