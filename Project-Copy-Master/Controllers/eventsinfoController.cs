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
    public class eventsinfoController : Controller
    {
        private readonly Ieventsinforepository _eventsinforepository;

        public eventsinfoController(Ieventsinforepository eventsinforepository)
        {
            _eventsinforepository = eventsinforepository;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_eventsinforepository.Getall());
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> Getbyemail(string email)
        {
            return await (_eventsinforepository.Getbyemail(email));
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        
        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> Getbyid(int id)
        {
            return await (_eventsinforepository.Getbyid(id));
        }


        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getbystatuspending()
        {
            return await (_eventsinforepository.Getbystatuspending());
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> PosteventByemail([FromForm] eventsinfo enet)
        {
            return await (_eventsinforepository.PosteventByemail(enet));
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Puteventbyid(eventsinfo enet)
        {
            return await (_eventsinforepository.Puteventbyid(enet));

        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)
        {
            return await (_eventsinforepository.Delete(id));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> savepic([FromForm] eventsinfo enet)
        {
            return await (_eventsinforepository.savepic(enet));
        }

        //filter process
        [Route("[action]/{countries}")]
        [HttpGet]
        public async Task<JsonResult> Getbycountries(string countries)
        {
            return await (_eventsinforepository.Getbycountries(countries));

        }



        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> pickpic(eventsinfo enet)
        {
            return await (_eventsinforepository.pickpic(enet));
        }



    



        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putreviewbyid(eventsinfo enet)
        {
            return await (_eventsinforepository.Putreviewbyid(enet));
        }


    }
    }
