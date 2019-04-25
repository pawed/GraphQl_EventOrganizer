using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Interfaces
{
    public interface IPeopleRepository
    {
        IEnumerable<People> GetAll();
        People GetById(string id);
        People Add(People people);
    }
}
