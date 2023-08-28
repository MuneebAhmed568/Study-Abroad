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
    public class StudentinfoController : Controller
    {
       

        private readonly IStudentinfoRepository _studentinfoRepository;

        public StudentinfoController(IStudentinfoRepository StudentinfoRepository)
        {
            _studentinfoRepository = StudentinfoRepository;
        }

        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_studentinfoRepository.Getall());
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Student")]
        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> GetbyEmail(string email)
        {
            return await (_studentinfoRepository.GetbyEmail(email));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getbystatuspending()
        {
            return await (_studentinfoRepository.Getbystatuspending());
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Student")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putbyemail(Studentinfo stu)
        {
            return await (_studentinfoRepository.Putbyemail(stu));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Student")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putbyupdemails(Studentinfo stu)
        {
            return await (_studentinfoRepository.Putbyupdemails(stu));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Student")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> savepic([FromForm] Studentinfo stu)
        {
            return await (_studentinfoRepository.savepic(stu));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Student,MAIN_ADMIN")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putupdatestatus(Studentinfo stu)
        {
            return await (_studentinfoRepository.Putupdatestatus(stu));
        }


        [HttpPost]
        public async Task<JsonResult> Post(Studentinfo stu)
        {
            return await (_studentinfoRepository.Post(stu));

        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Student")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> PutbyPassword(Studentinfo stu)
        {
            return await (_studentinfoRepository.PutbyPassword(stu));
        }

        

    }
}
