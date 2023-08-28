using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IBlogsRepository
    {
        Task<JsonResult> Getall();
        Task<JsonResult> GetbyId(int id);
        Task<JsonResult> PostBLog([FromForm] Blogs blog);
        Task<JsonResult> GetTopone();
       
    }
}