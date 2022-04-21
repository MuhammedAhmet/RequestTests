using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestTests_Data.Entities.Test;
using RequestTests_Data.Services.Test;
using RequestTests_WebApi.Models.TestModels;

namespace RequestTests_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITest_Service _testService;

        public TestController(ITest_Service testService)
        {
            _testService = testService;
        }

        #region GET

        #region Synchronous Method
        //[HttpGet]
        //[Route("Get")]
        //public IActionResult Get(string? Id)
        //{

        //    if(Id == null)
        //    {
        //        var Resp = _testService.Get();
        //        return Ok(Resp);
        //    }
        //    else
        //    {
        //        var Resp = _testService.Get(Id);
        //        return Ok(Resp);
        //    }

        //}

        #endregion

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {

            var Resp = await _testService.Get();
            return Ok(Resp);

            #region Old
            //if (Id == null)
            //{
            //    var Resp = await _testService.Get();
            //    return Ok(Resp);
            //}
            //else
            //{
            //    var Resp = await _testService.Get(Id);
            //    return Ok(Resp);
            //}
            #endregion

        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> Get(string Id)
        {

            var Resp = await _testService.Get(Id);
            return Ok(Resp);

        }

        #endregion

        
        #region CREATE

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(TestPostModel Data)
        {
            var Creation = new Test_Entity()
            {
                Desc = Data.Desc,
                Name = Data.Name
            };
            try
            {
                await _testService.Create(Creation);
                return Ok("Sent");
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        #endregion



        #region DELETE
        //[HttpPost]
        //[Route("Delete")]
        //public IActionResult Delete(string Id)
        //{
        //    _testService.Delete(Id);
        //    return Ok("Deleted");
        //}

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(string Id)
        {
            await _testService.Delete(Id);
            return Ok("Deleted");
        }

        #endregion
    }
}
