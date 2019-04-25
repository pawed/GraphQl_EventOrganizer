using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLApi.Interfaces;

namespace GraphQLApi.GraphQLElments.Mutation
{
    public class PeopleMutation:ObjectGraphType
    {

        public PeopleMutation(IPeopleRepository repository)
        {
            Field<PeopleGraphType>
        }

    }
}
