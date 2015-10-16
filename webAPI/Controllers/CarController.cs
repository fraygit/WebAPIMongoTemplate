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
        [EnableCors(origins: "http://localhost:61447", headers: "*", methods: "*")]
        public async Task<List<Car>> GetAllCars()
        {
            var carRepository = new CarRepository();
            var cars = await carRepository.ListAll();
            return cars;
        }

        [EnableCors(origins: "http://localhost:61447", headers: "*", methods: "*")]
        public async Task<HttpResponseMessage> Insert(Car car)
        {
            var carRepository = new CarRepository();
            await carRepository.CreateSync(car);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
