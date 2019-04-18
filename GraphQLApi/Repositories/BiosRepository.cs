using Common.Models;
using GraphQLApi.Context;
using GraphQLApi.Interfaces;
using GraphQLApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly MongoDbContext _context = null;

        public PeopleRepository(IOptions<DbSettings> settings)
        {
            _context = new MongoDbContext(settings);
        }

        public IEnumerable<People> GetAll()
        {

            var documents =  _context.People.AsQueryable().ToList();

            return documents;
        }

        public People GetById(string id)
        {
           var query= Builders<People>.Filter.Eq(a => a.Id, id);

            var documents = _context.People.Find(query).FirstOrDefault();

            return documents;
        }
    }
}
