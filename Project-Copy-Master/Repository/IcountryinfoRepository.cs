using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IcountryinfoRepository
    {
        Task<JsonResult> Getall();
        Task<JsonResult> Getallinfo();
        Task<JsonResult> Getbyid(int id);
    }
}