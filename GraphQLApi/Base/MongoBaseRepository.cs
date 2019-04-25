using Common.Models;
using GraphQLApi.Context;
using GraphQLApi.Interfaces;
using GraphQLApi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLApi.Base
{
    public abstract class MongoBaseRepository<T> : IMongoRepository<T> where T : class, new()
    {
        protected readonly IMongoCollection<T> _collection;
        protected readonly MongoDbContext _context;

        private readonly Dictionary<Type, string> _collectionMapping = new Dictionary<Type, string>
        {
            { typeof(People),"People"}
        };

        protected MongoBaseRepository(DbSettings settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<T>(_collectionMapping[typeof(T)]);
        }

        public void AddSingle(T item) 
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll() 
        {
           return _collection.AsQueryable();
        }

        public IEnumerable<T> GetAllByQuery(FilterDefinition<T> query, SortDefinition<T> sort = null)
        {

            return _collection.Find(query).Sort(sort).ToList();
        }

       
        public T GetSingle(FilterDefinition<T> query)
        {
            return _collection.Find(query).FirstOrDefault();
        }
    }
}
