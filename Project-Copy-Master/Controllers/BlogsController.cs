using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using Project_Copy_Master.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : Controller
    {
        private readonly IBlogsRepository _blogsrepository;

        public BlogsController(IBlogsRepository Blogsrepository)
        {
            
            _blogsrepository = Blogsrepository;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_blogsrepository.Getall());
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> GetbyId(int id)
        {

            return await (_blogsrepository.GetbyId(id));
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "MAIN_ADMIN")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> PostBLog([FromForm] Blogs blog)
        {  
            return await (_blogsrepository.PostBLog(blog));
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> GetTopone()
        {
            return await (_blogsrepository.GetTopone());
        }
        

    }
}
