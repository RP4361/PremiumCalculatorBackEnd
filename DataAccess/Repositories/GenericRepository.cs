using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    /*
     *  This class will implement the IGenericRepository Interface.
     *   This way we are hiding all the actions related to the dbContext object within Repository Classes.
     *   Understood why we used a Generic Repository instead of a IDevloperRepository?? 
     *   When there are large number of entites in our application, we would need seperate repositories for each entities. 
     *   But we do not want to implement all of the above 7 Functions in each and every Repository Class, right? 
     *   Thus we made a generic repository that holds the most commonly used implementaions.
     */

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
