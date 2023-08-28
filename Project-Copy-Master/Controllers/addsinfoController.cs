using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Models;
using Project_Copy_Master.Repository;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class addsinfoController : Controller
    {
        private readonly IaddsinfoRepository _addsinfoRepository;

        public addsinfoController(IaddsinfoRepository addsinfoRepository)
        {
            _addsinfoRepository = addsinfoRepository;
        }



        /*Called on StudyAdsView*/
        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getall()
        {
            return await (_addsinfoRepository.Getall());
        }




        /*Was Called on AddsApprovel (by admin)*/
        [Route("[action]")]
        [HttpGet]
        public async Task<JsonResult> Getbystatuspending()
        {
           
            return await (_addsinfoRepository.Getbystatuspending());
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) */
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        
        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<JsonResult> Getbyemail(string email)
        {
            
            return await (_addsinfoRepository.Getbyemail(email));
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile)  and also in single page (SinglestudyAdspage) */
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<JsonResult> Getbyid(int id)
        {
            return await (_addsinfoRepository.Getbyid(id));
        }


        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for adding new StudyAdds */
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> PostByadd([FromForm] addsinfo adds) 
        {

            return await (_addsinfoRepository.PostByadd(adds));
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for updating StudyAdds */
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]")]
        [HttpPut]
        public async Task<JsonResult> Putaddbyid(addsinfo adds)
        {
            return await (_addsinfoRepository.Putaddbyid(adds));
        }


        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for deleting StudyAdds */
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(String id)
        {
            return await (_addsinfoRepository.Delete(id));
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) */
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Consultant,Institute")]
        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> savepic([FromForm] addsinfo adds)
        {
            return await (_addsinfoRepository.savepic(adds));
        }


  
        [Route("[action]/{Country}")]
        [HttpGet]
        public async Task<JsonResult> Getbycountries(string Country)
        {
            return await (_addsinfoRepository.Getbycountries(Country));
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<JsonResult> pickpic(addsinfo adds)
        {
            return await (_addsinfoRepository.pickpic(adds));
        }


    }
}
