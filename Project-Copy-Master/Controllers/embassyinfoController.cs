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
    public class embassyinfoController : Controller
    {
        
       
        private readonly IembassyinfoRepository _embassyinfoRepository;

        public embassyinfoController(IembassyinfoRepository embassyinfoRepository)
        {
            _embassyinfoRepository = embassyinfoRepository;
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_embassyinfoRepository.Getall());
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getallinfo()
        {
            return await (_embassyinfoRepository.Getallinfo());
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult>  Getbyid(int id)
        {
            return await (_embassyinfoRepository.Getbyid(id));
        }

        //filter process
        [Route("[action]/{countries}")]
        [HttpGet]
        public async Task<JsonResult> Getbycountries(string countries)
        {
            return await (_embassyinfoRepository.Getbycountries(countries));

        }


    }
}
