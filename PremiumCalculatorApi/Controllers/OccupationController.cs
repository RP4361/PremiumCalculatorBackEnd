using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PremiumCalculatorApi.Controllers
{
    [EnableCors("GlobalCorsPolicy")]
    [Route("api/GetOccupationData")]
    [ApiController]
    public class OccupationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OccupationController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        
        [HttpGet]
        public async Task<IEnumerable<Occupation>> GetAllOccupations()
        {
            return await _unitOfWork.Occupations.GetAll();
        }
            

            
    }
}
