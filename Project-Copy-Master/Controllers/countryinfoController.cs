using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class countryinfoController : Controller
    {
        private readonly IcountryinfoRepository _countryinfoRepository;

        public countryinfoController(IcountryinfoRepository countryinfoRepository)
        { 
            _countryinfoRepository = countryinfoRepository;
        }



        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_countryinfoRepository.Getall());
        }


        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getallinfo()
        {
            return await (_countryinfoRepository.Getallinfo());
        }


        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> Getbyid(int id)
        {
            return await (_countryinfoRepository.Getbyid(id));
        }
    }
}
