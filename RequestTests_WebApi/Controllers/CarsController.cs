using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestTests_Data.Entities.Cars;
using RequestTests_Data.Services.Cars;
using RequestTests_WebApi.Models.CarModels;

namespace RequestTests_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICars_Service _carsService;
        public CarsController(ICars_Service carsService)
        {
            _carsService = carsService;
        }

        #region BASIC CRUD OPS

        #region GET

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {

            var Resp = await _carsService.Get();
            return Ok(Resp);

            #region Old
            //if (Id == null)
            //{
            //    var Resp = await _carsService.Get();
            //    return Ok(Resp);
            //}
            //else
            //{
            //    var Resp = await _carsService.Get(Id);
            //    return Ok(Resp);
            //}
            #endregion

        }


        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> Get(string Id)
        {

            var Resp = await _carsService.Get(Id);
            return Ok(Resp);

        }

        #endregion

        #region UPDATE
        #endregion

        #region CREATE

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CarPostModel Data)
        {
            var Obj = new Cars_Entity()
            {
                EngineSize = Data.EngineSize,
                MileAge = Data.MileAge,
                Mpg = Data.Mpg,
                Price = Data.Price,
                Tax = Data.Tax,
                Transmission = Data.Transmission,
                Year = Data.Year
            };

            try
            {
                await _carsService.Create(Obj);
                return Ok("Sent");
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        #endregion

        #region DELETE
        #endregion


        #endregion


    }
}
