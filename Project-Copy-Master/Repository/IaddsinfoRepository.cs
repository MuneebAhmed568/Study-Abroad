using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IaddsinfoRepository
    {
        Task<JsonResult> Delete(string id);
        Task<JsonResult> Getall();
        Task<JsonResult> Getbycountries(string Country);
        Task<JsonResult> Getbyemail(string email);
        Task<JsonResult> Getbyid(int id);
        Task<JsonResult> Getbystatuspending();
        Task<JsonResult> pickpic(addsinfo adds);
        Task<JsonResult> PostByadd([FromForm] addsinfo adds);
        Task<JsonResult> Putaddbyid(addsinfo adds);
        Task<JsonResult> savepic([FromForm] addsinfo adds);
    }
}