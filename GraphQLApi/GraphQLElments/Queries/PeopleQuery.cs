using GraphQL.Types;
using GraphQLApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQLElments
{
    public class PeopleQuery : ObjectGraphType
    {
        public PeopleQuery(IPeopleRepository peopleRepository)
        {
            Field<ListGraphType<PeopleGraphType>>(
                "People",
                resolve: context => peopleRepository.GetAll()
                );

            Field<PeopleGraphType>(
                "person",
                arguments:new QueryArguments(new QueryArgument<StringGraphType> { Name="id"}),
                resolve:context => peopleRepository.GetById(context.GetArgument<string>("id"))
                );
        }
    }
}
