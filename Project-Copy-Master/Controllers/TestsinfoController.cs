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
    public class TestsinfoController : Controller
    {
        private readonly ITestsinfoRepository _testsinforepository;

        public TestsinfoController(ITestsinfoRepository Testsinforepository)
        {
            _testsinforepository = Testsinforepository;
        }

        [Route("[action]/{name}")]
        [HttpGet]
        public async Task<JsonResult> GetbyName(string name)
        {
            return await (_testsinforepository.GetbyName(name));
        }



        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_testsinforepository.Getall());
        }
    }
}
