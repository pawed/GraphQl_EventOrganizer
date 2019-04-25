using Common.Models;
using GraphQLApi.Base;
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
    public class PeopleRepository : MongoBaseRepository<People>, IPeopleRepository
    {
       // private readonly MongoDbContext _context = null;

        public PeopleRepository(IOptions<DbSettings> settings):base(settings.Value)
        {
            //settings.Value;
            
        }

        public People Add(People people)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<People> GetAll()
        {

            var documents = base.GetAll();
            return documents;

            //var documents =  _context.AsQueryable().ToList();

            //return documents;
        }

        public People GetById(string id)
        {
            //throw new NotImplementedException();

            var query= Builders<People>.Filter.Eq(a => a.Id, id);

            var documents = base.GetSingle(query);

            return documents;

            // var documents = _context.People.Find(query).FirstOrDefault();

            // return documents;
        }
    }
}
