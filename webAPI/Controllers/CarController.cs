using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Repository;

namespace webAPI.Controllers
{
    public class CarController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public async Task<List<Car>> GetAllCars()
        {
            var carRepository = new CarRepository();
            var cars = await carRepository.ListAll();
            return cars;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        public async Task<HttpResponseMessage> PostInsert(Car car)
        {
            var carRepository = new CarRepository();
            await carRepository.CreateSync(car);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPut]
        public async Task<HttpResponseMessage> PutUpdate([FromUri]string id, [FromBody]Car car)
        {
            var f = "";
            var carRepository = new CarRepository();
            try
            {
                var result = await carRepository.Update(id, car);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteCar([FromUri]string id)
        {
            var f = "";
            var carRepository = new CarRepository();
            try
            {
                var result = await carRepository.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

    }
}
