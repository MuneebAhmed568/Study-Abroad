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
    public class CommentsinfoController : Controller
    {
        private readonly ICommentsinfoRepository _commentsinfoRepository;

        public CommentsinfoController(ICommentsinfoRepository CommentsinfoRepository)
        {
            _commentsinfoRepository = CommentsinfoRepository;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> Insertbyemail(Commentsinfo conns)
        {

            return await (_commentsinfoRepository.Insertbyemail(conns));
        }

        [Route("[action]/{Pagename}")]
        [HttpGet]
        public async Task<JsonResult> Getall(string Pagename)
        {
            return await (_commentsinfoRepository.Getall(Pagename));
        }


    }
}
