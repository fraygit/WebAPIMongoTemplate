﻿using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;
using System.Threading.Tasks;

namespace webAppTemplate.MongoData.Interface
{
    public interface IUserRepository : IEntityService<User>
    {
        Task<User> GetUser(string username);
    }
}
