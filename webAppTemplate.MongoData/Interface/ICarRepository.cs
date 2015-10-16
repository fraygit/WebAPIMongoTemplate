using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;

namespace webAppTemplate.MongoData.Interface
{
    public interface ICarRepository : IEntityService<Car>
    {
    }
}
