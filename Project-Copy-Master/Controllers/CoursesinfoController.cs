using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesinfoController : Controller
    {
        private readonly ICoursesinfoRepository _coursesinforepository;

        public CoursesinfoController(ICoursesinfoRepository Coursesinforepository)
        {
            _coursesinforepository = Coursesinforepository;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_coursesinforepository.Getall());
        }
    }
}
