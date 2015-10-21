using webAppTemplate.MongoData.Interface;
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;

namespace webAppTemplate.MongoData.Repository
{
    public class CarRepository : EntityService<Car>, ICarRepository
    {
    }
}
