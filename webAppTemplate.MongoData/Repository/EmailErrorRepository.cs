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
    public class EmailErrorRepository : EntityService<EmailError>, IEmailErrorRepository
    {
    }
}
