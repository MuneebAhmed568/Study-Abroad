using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IscholarshipinfoRepository
    {
        Task<JsonResult> countries(string countries);
        Task<JsonResult> Delete(int id);
        Task<JsonResult> Getall();
        Task<JsonResult> Getallinfo();
        Task<JsonResult> Getbyemail(string email);
        Task<JsonResult> Getbyid(int id);
        Task<JsonResult> Getbystatuspending();
        Task<JsonResult> pickpic(eventsinfo enet);
        Task<JsonResult> PosteventByemail([FromForm] eventsinfo enet);
        Task<JsonResult> Puteventbyid(eventsinfo enet);
        Task<JsonResult> Putreviewbyid(scholarshipinfo scho);
        Task<JsonResult> savepic([FromForm] eventsinfo enet);
    }
}