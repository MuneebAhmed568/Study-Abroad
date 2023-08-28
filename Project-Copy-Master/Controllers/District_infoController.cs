using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Repository;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class District_infoController : Controller
    {
        public readonly IDistrict_infoRepository _district_InfoRepository;
        public District_infoController(IDistrict_infoRepository district_InfoRepository)
        {
            _district_InfoRepository= district_InfoRepository;  
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_district_InfoRepository.Getall());
        }
    }
}
