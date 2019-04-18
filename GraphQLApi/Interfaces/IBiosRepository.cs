using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Interfaces
{
    public interface IBiosRepository
    {
        IEnumerable<Bios> GetAll();
    }
}
