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
using System.Text;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class consultantinfoController : Controller
    {
       
        private readonly IconsultantinfoRepository _consultantinfoRepository;
      
        public consultantinfoController( IconsultantinfoRepository consultantinfoRepository)
        {
                 
            _consultantinfoRepository = consultantinfoRepository;
        }



        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
            {
            
           return await (_consultantinfoRepository.Getall());
                
            }


        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getallinfo()
        {
            return await (_consultantinfoRepository.Getallinfo());
        }



        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult>  Getbystatuspending()
        {
            return await (_consultantinfoRepository.Getbystatuspending());
        }

      
        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> GetbyEmail(string email)
        {

            return await (_consultantinfoRepository.GetbyEmail(email));
        }

            /*SIGUP process*/
            [HttpPost]
            public async Task<JsonResult> Post(consultantinfo cons)
            {
            return await (_consultantinfoRepository.Post(cons));
            }


            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            [Authorize(Roles = "Consultant")]
            [Route("[action]")]
            [HttpPut]
            public async Task<JsonResult> Putbyemail(consultantinfo cons)
            {
            return await (_consultantinfoRepository.Putbyemail(cons));
            }








        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "MAIN_ADMIN")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putupdatestatus(consultantinfo cons)
        {
            return await (_consultantinfoRepository.Putupdatestatus(cons));
        }








        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> PutbyPassword(consultantinfo cons)
        {
            return await (_consultantinfoRepository.PutbyPassword(cons));
        }






        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,MAIN_ADMIN")]
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)
            {
            return await (_consultantinfoRepository.Delete(id));
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> savepic([FromForm] consultantinfo cons)
        {
            return await (_consultantinfoRepository.savepic(cons));
        }

        //filter process
        [Route("[action]/{countries}")]
        [HttpGet]
        public async Task<JsonResult> Getbycountries(string countries)
        {
            return await (_consultantinfoRepository.Getbycountries(countries));
        }



        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> pickpic(consultantinfo cons)
        {
            return await (_consultantinfoRepository.Post(cons));
        }


        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putreviewbyid(consultantinfo cons)
        {
            return await (_consultantinfoRepository.Putreviewbyid(cons));
        }




    }
}
