using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IembassyinfoRepository
    {
        Task<JsonResult> Getall();
        Task<JsonResult> Getallinfo();
        Task<JsonResult> Getbycountries(string countries);
        Task<JsonResult> Getbyid(int id);
    }
}