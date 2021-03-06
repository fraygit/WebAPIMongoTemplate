﻿using MongoDB.Driver;
using webAppTemplate.MongoData.Interface;
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAppTemplate.MongoData.Repository
{
    public class AdminUserTokenRepository : EntityService<AdminUserToken>, IAdminUserTokenRepository
    {
        public async Task<AdminUserToken> GetUserToken(string username)
        {
            var builder = Builders<AdminUserToken>.Filter;
            var filter = builder.Eq("Email", username);
            var token = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (token != null)
            {
                if (token.Any())
                {
                    return token.FirstOrDefault();
                }
            }
            return null;
        }

        public async Task<bool> IsTokenValid(string userToken)
        {
            var builder = Builders<AdminUserToken>.Filter;
            var filter = builder.Eq("Token", userToken);
            var token = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (token != null)
            {
                if (token.Any())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
