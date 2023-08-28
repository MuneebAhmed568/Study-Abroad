using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface ICoursesinfoRepository
    {
        Task<JsonResult> Getall();
    }
}