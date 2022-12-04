using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OccupationRepository : GenericRepository<Occupation>, IOccupationRepository
    {
        public OccupationRepository(ApplicationContext context) : base(context)
        {
        }


        // any Entity specific implementation of IOccupatonRepo will go here
    }
}
