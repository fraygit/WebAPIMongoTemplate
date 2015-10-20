using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppTemplate.MongoData.Entities.Base;

namespace webAppTemplate.MongoData.Service
{
    public class EntityService<T> : IEntityService<T> where T : IMongoEntity
    {
        protected readonly ConnectionHandler<T> ConnectionHandler;

        protected EntityService()
        {
            ConnectionHandler = new ConnectionHandler<T>();
        }

        public virtual void Create(T entity)
        {
            var result = this.ConnectionHandler.MongoCollection.InsertOneAsync(entity);
        }

        public virtual async Task<List<T>> ListAll()
        {
            return await this.ConnectionHandler.MongoCollection.Find(new BsonDocument()).ToListAsync();
        }

        public virtual async Task<ReplaceOneResult> Update(string id, T entity)
        {
            var carId = ObjectId.Parse(id);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("_id", carId);
            entity.Id = carId;
            var result = await this.ConnectionHandler.MongoCollection.ReplaceOneAsync(filter, entity);
            return result;
        }

        public virtual async Task<DeleteResult> Delete(string id)
        {
            var carId = ObjectId.Parse(id);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("_id", carId);
            var result = await this.ConnectionHandler.MongoCollection.DeleteManyAsync(filter);
            return result;
        }

        public virtual async Task<bool> CreateSync(T entity)
        {
            await this.ConnectionHandler.MongoCollection.InsertOneAsync(entity);
            return true;
        }

    }
}
