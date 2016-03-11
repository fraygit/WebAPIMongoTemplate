using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAppTemplate.MongoData.Interface
{
    public interface IAdminUserTokenRepository : IEntityService<AdminUserToken>
    {
        Task<AdminUserToken> GetUserToken(string username);
        Task<bool> IsTokenValid(string userToken);
    }
}
