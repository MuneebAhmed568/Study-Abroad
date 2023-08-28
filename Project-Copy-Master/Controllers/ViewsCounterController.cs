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
    public class ViewsCounterController : Controller
    {
        private readonly IViewsCounterRepository _viewsCounterRepository;

        public ViewsCounterController(IViewsCounterRepository ViewsCounterRepository)
        {
            _viewsCounterRepository = ViewsCounterRepository;
        }
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Mainpageviewsupdate()
        {
            return await (_viewsCounterRepository.Mainpageviewsupdate());
        }

        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> MainNewspageviewsupdate()
        {
            return await (_viewsCounterRepository.MainNewspageviewsupdate());
        }


        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> MainAddspageviewsupdate()
        {
            return await (_viewsCounterRepository.MainAddspageviewsupdate());
        }


        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> MainScholarshippageviewsupdate()
        {
            return await (_viewsCounterRepository.MainScholarshippageviewsupdate());
        }

        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> MainUniversitypageviewsupdate()
        {
            return await (_viewsCounterRepository.MainUniversitypageviewsupdate());
        }
        //Consultant


        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> MainConsultantpageviewsupdate()
        {
            return await (_viewsCounterRepository.MainConsultantpageviewsupdate());
        }





        

        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> ConsultantSinglepageviewsupdate(ViewsCounter views)
        {
            return await (_viewsCounterRepository.ConsultantSinglepageviewsupdate(views));
        }

        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> NewsSinglepageviewsupdate(ViewsCounter views)
        {
            return await (_viewsCounterRepository.NewsSinglepageviewsupdate(views));
        }



        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> AddsSinglepageviewsupdate(ViewsCounter views)
        {
            return await (_viewsCounterRepository.AddsSinglepageviewsupdate(views));
        }


        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> UniversitySinglepageviewsupdate(ViewsCounter views)
        {
            return await (_viewsCounterRepository.UniversitySinglepageviewsupdate(views));
        }



        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> ScholarshipSinglepageviewsupdate(ViewsCounter views)
        {
            return await (_viewsCounterRepository.ScholarshipSinglepageviewsupdate(views));
        }



        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> Getuniversitybyemail(string email)
        {
            return await (_viewsCounterRepository.Getuniversitybyemail(email));
        }


        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> Getconsultantbyemail(string email)
        {
            return await (_viewsCounterRepository.Getconsultantbyemail(email));
        }

    }
}
