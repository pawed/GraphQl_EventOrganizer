using GraphQL.Types;
using GraphQLApi.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQLElments
{
    public class PeopleGraphType: ObjectGraphType<People>
    {
        public PeopleGraphType()
        {
            Field(x => x.Id);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.Nick);
            Field(x => x.Email);
        }
    }
}
