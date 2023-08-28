using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IFormdataRepository
    {
        Task<JsonResult> countries(string countries);
        Task<JsonResult> Getall(string id);
        Task<JsonResult> GetbyId(int id);
        Task<JsonResult> Insertbyemail(Formdata fds);
    }
}