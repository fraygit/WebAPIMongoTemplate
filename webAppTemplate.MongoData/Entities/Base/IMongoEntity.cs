using MongoDB.Bson;

namespace webAppTemplate.MongoData.Entities.Base
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
