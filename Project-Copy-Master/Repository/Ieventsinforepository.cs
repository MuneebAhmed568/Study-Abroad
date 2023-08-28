using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface Ieventsinforepository
    {
        Task<JsonResult> Delete(int id);
        Task<JsonResult> Getall();
        Task<JsonResult> Getbycountries(string countries);
        Task<JsonResult> Getbyemail(string email);
        Task<JsonResult> Getbyid(int id);
        Task<JsonResult> Getbystatuspending();
        Task<JsonResult> pickpic(eventsinfo enet);
        Task<JsonResult> PosteventByemail([FromForm] eventsinfo enet);
        Task<JsonResult> Puteventbyid(eventsinfo enet);
        Task<JsonResult> Putreviewbyid(eventsinfo enet);
        Task<JsonResult> savepic([FromForm] eventsinfo enet);
    }
}