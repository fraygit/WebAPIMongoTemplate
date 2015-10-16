using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppTemplate.MongoData.Entities.Base;

namespace webAppTemplate.MongoData.Model
{
    public class Car : MongoEntity
    {
        public string Make { get; set; }
    }
}
