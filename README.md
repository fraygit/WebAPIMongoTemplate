# WebAPIMongoTemplate

### Description
This project aims to be a boilerplate for C# Web API project using MongoDB backend. 

### Structure

The project is broken down into 3 projects

1. Data Layer
2. Web API
3. Website

### Data Layer

To Create a new data model:
1. Create a data model class under webAppTemplate.MongoData > Model
e.g.
```csharp
using webAppTemplate.MongoData.Entities.Base;

namespace webAppTemplate.MongoData.Model
{
    public class Car : MongoEntity
    {
        public string Make { get; set; }
    }
}
```

2. 



### Todo's

Still a lot!!!!! Too many to list down for now!


License
----

MIT

