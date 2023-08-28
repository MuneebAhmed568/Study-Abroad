using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface ITestsinfoRepository
    {
        Task<JsonResult> Getall();
        Task<JsonResult> GetbyName(string name);
    }
}