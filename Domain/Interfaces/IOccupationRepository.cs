using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOccupationRepository : IGenericRepository<Occupation>
    {
        // Here we can put up any non generic methods specific to Occupation Entity
        // This will be implemented in the Data Access project to fulfil DI
    }
}
