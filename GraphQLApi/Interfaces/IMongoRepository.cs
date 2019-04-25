using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLApi.Interfaces
{
    public interface IMongoRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll() ;
        IEnumerable<T> GetAllByQuery(FilterDefinition<T> query, SortDefinition<T> sort);
        T GetSingle(FilterDefinition<T> query) ;
        void AddSingle(T item) ;
    }
}
