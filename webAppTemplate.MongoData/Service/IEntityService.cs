using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppTemplate.MongoData.Entities.Base;

namespace webAppTemplate.MongoData.Service
{
    public interface IEntityService<T> where T : IMongoEntity
    {
        void Create(T entity);
        Task<List<T>> ListAll();
    }
}
