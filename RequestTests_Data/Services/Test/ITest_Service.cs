using RequestTests_Data.Entities.Test;

namespace RequestTests_Data.Services.Test
{
    public interface ITest_Service
    {
        Task Create(Test_Entity Data);
        Task<List<Test_Entity>> Get();
        Task<Test_Entity> Get(string Id);
        Task Delete(string Id);
        Task Update(Test_Entity Data);

        //void Create(Test_Entity Data);
        //List<Test_Entity> Get();
        //Test_Entity Get(string Id);
        //void Delete(string Id);
        //void Update(Test_Entity Data);
    }
}