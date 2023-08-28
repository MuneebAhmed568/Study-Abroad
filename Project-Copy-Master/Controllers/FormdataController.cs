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
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormdataController : Controller
    {
        private readonly IFormdataRepository _formdataRepository;

        public FormdataController(IFormdataRepository FormdataRepository)
        {
            _formdataRepository = FormdataRepository;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant")]
        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> Getall(string id)
        {
            return await (_formdataRepository.Getall(id));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant")]
        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> GetbyId(int id)
        {
            return await (_formdataRepository.GetbyId(id));
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> Insertbyemail(Formdata fds)
        {
            return await (_formdataRepository.Insertbyemail(fds));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant")]
        [Route("[action]/{countries}")]
        [HttpGet]
        public async Task<JsonResult> countries(string countries)
        {
            return await (_formdataRepository.countries(countries));
        }
    }
}
