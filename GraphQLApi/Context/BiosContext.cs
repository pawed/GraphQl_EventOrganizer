using Common.Models;
using GraphQLApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Context
{
    public class MongoDbContext
    {
        private const string CollectionName = "People";
        private readonly IMongoDatabase _database = null;

        public MongoDbContext(IOptions<DbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);

            BsonClassMap.RegisterClassMap<People>(cm => 
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });
        }

        public IMongoCollection<People> People
        {
            get
            {
                return _database.GetCollection<People>(CollectionName);
            }
        }
    }
}
