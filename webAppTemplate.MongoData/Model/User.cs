using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppTemplate.MongoData.Entities.Base;

namespace webAppTemplate.MongoData.Model
{
    public class User : MongoEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
