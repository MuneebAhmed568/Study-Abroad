using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IconsultantinfoRepository
    {
        Task<JsonResult> Delete(int id);
        Task<JsonResult> Getall();
        Task<JsonResult> Getallinfo();
        Task<JsonResult> Getbycountries(string countries);
        Task<JsonResult> GetbyEmail(string email);
        Task<JsonResult> Getbystatuspending();
        Task<JsonResult> pickpic(consultantinfo cons);
        Task<JsonResult> Post(consultantinfo cons);
        Task<JsonResult> Putbyemail(consultantinfo cons);
        Task<JsonResult> PutbyPassword(consultantinfo cons);
        Task<JsonResult> Putreviewbyid(consultantinfo cons);
        Task<JsonResult> Putupdatestatus(consultantinfo cons);
        Task<JsonResult> savepic([FromForm] consultantinfo cons);
    }
}