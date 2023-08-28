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
    public class InstituteinfoController : Controller
    {
     
    
        private readonly IInstituteinfoRepository _instituteinfoRepository;

        public InstituteinfoController(IInstituteinfoRepository InstituteinfoRepository)
        {
            _instituteinfoRepository = InstituteinfoRepository;
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_instituteinfoRepository.Getall());
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getallinfo()
        {
            return await (_instituteinfoRepository.Getallinfo());
        }

       // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> GetbyEmail(string email)
        {
            return await (_instituteinfoRepository.GetbyEmail(email));
        }



        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getbystatuspending()
        {
            return await (_instituteinfoRepository.Getbystatuspending());
        }



        [HttpPost]
        public async Task<JsonResult> Post(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.Post(inst));

        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putbyemail(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.Putbyemail(inst));
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> PutbyPassword(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.PutbyPassword(inst));
        }
       

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute,MAIN_ADMIN")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putupdatestatus(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.Putupdatestatus(inst));
        }

       
        [HttpPut]
        public async Task<JsonResult> Put(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.Put(inst));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute,MAIN_ADMIN")]
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)
        {
            return await (_instituteinfoRepository.Delete(id));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> savepiccover([FromForm] Instituteinfo inst)
        {
            return await (_instituteinfoRepository.savepiccover(inst));
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult>  savepicmain([FromForm] Instituteinfo inst)
        {
            return await (_instituteinfoRepository.savepicmain(inst));
        }



        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> pickpiclogo(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.pickpiclogo(inst));
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> pickpiccover(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.pickpiccover(inst));
        }

        [Route("[action]/{countries}")]
        [HttpGet]
        public async Task<JsonResult> countries(string countries)
        {
            return await (_instituteinfoRepository.countries(countries));
        }


        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putreviewbyid(Instituteinfo inst)
        {
            return await (_instituteinfoRepository.Putreviewbyid(inst));
        }


    }
}
