using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQLElments
{
    public class PeopleSchema: GraphQL.Types.Schema
    {

        public PeopleSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<PeopleQuery>();
        }
    }
}
