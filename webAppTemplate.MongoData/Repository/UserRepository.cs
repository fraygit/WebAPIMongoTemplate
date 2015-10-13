using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppTemplate.MongoData.Interface;
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;

namespace webAppTemplate.MongoData.Repository
{
    public class UserRepository : EntityService<User>, IUserRepository
    {
        public async Task<User> GetUser(string username)
        {
            var builder = Builders<User>.Filter;
            var filter = builder.Eq("Email", username);
            var users = await this.ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (users.Any())
                return users.FirstOrDefault();
            else
                return null;
        }
    }
}
