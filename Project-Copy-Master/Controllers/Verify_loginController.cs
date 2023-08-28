using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Models;
using Project_Copy_Master.Repository;
using Project_Copy_Master.Service;
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
    public class Verify_loginController : Controller
    {
        private readonly IVerify_loginRepository _verify_LoginRepository;

        public Verify_loginController(IVerify_loginRepository Verify_loginRepository)
        {
            _verify_LoginRepository = Verify_loginRepository;
        }

        [HttpGet("{email}/{password}")]
        public async Task<JsonResult> Get(string email, string password)
        {
            return await (_verify_LoginRepository.Get(email, password ));
        }

        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult>  Getbyemail(string email)
        {
            return await (_verify_LoginRepository.Getbyemail(email));
        }


        [HttpPost]
        public async Task<JsonResult> Post(Verify_login ver)
        {
            return await (_verify_LoginRepository.Post(ver));
        }

        [HttpPut]
        public async Task<JsonResult> Put(Verify_login ver)
        {
            return await (_verify_LoginRepository.Put(ver));
        }




    }
    
}
