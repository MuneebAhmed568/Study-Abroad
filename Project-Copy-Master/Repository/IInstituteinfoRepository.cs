using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IInstituteinfoRepository
    {
        Task<JsonResult> countries(string countries);
        Task<JsonResult> Delete(int id);
        Task<JsonResult> Getall();
        Task<JsonResult> Getallinfo();
        Task<JsonResult> GetbyEmail(string email);
        Task<JsonResult> Getbystatuspending();
        Task<JsonResult> pickpiccover(Instituteinfo inst);
        Task<JsonResult> pickpiclogo(Instituteinfo inst);
        Task<JsonResult> Post(Instituteinfo inst);
        Task<JsonResult> Put(Instituteinfo inst);
        Task<JsonResult> Putbyemail(Instituteinfo inst);
        Task<JsonResult> PutbyPassword(Instituteinfo inst);
        Task<JsonResult> Putreviewbyid(Instituteinfo inst);
        Task<JsonResult> Putupdatestatus(Instituteinfo inst);
        Task<JsonResult> savepiccover([FromForm] Instituteinfo inst);
        Task<JsonResult> savepicmain([FromForm] Instituteinfo inst);
    }
}