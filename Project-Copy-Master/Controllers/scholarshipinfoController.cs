using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Models;
using Project_Copy_Master.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class scholarshipinfoController : Controller
    {
      
        private readonly IscholarshipinfoRepository _scholarshipinfoRepository;

        public scholarshipinfoController (IscholarshipinfoRepository scholarshipinfoRepository)
        {
          
            _scholarshipinfoRepository = scholarshipinfoRepository;
        }


        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {

            return await (_scholarshipinfoRepository.Getall());

        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getallinfo()
        {
            return await (_scholarshipinfoRepository.Getallinfo());
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> Getbyemail(string email)
        {
            return await (_scholarshipinfoRepository.Getbyemail(email));
        }

        [Route("[action]/{countries}")]
        [HttpGet]
        public async Task<JsonResult> countries(string countries)
        {
            return await (_scholarshipinfoRepository.countries(countries));
        }


        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> Getbyid(int id)
        {
            return await (_scholarshipinfoRepository.Getbyid(id));
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getbystatuspending()
        {
            return await (_scholarshipinfoRepository.Getbystatuspending());
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> PosteventByemail([FromForm] eventsinfo enet)
        {
            return await (_scholarshipinfoRepository.PosteventByemail(enet));
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Puteventbyid(eventsinfo enet)
        {
            return await (_scholarshipinfoRepository.Puteventbyid(enet));
        }




        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)      
        {

            return await (_scholarshipinfoRepository.Delete(id));
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> savepic([FromForm] eventsinfo enet)
        {
            return await (_scholarshipinfoRepository.savepic(enet));
        }



        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> pickpic(eventsinfo enet)
        {
            return await (_scholarshipinfoRepository.pickpic(enet));
        }



        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putreviewbyid(scholarshipinfo scho)
        {
            return await (_scholarshipinfoRepository.Putreviewbyid(scho));
        }
    }
}
