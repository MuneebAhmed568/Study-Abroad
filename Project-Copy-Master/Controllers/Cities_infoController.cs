using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Repository;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Cities_infoController : Controller
    {
        public readonly ICities_infoRepository _cities_InfoRepository;
        public Cities_infoController(ICities_infoRepository cities_InfoRepository) 
        {
            _cities_InfoRepository =   cities_InfoRepository; 
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_cities_InfoRepository.Getall());
        }
    }
}
