using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IVerify_loginRepository
    {
        Task<JsonResult> Get(string email, string password);
        Task<JsonResult> Getbyemail(string email);
        Task<JsonResult> Post(Verify_login ver);
        Task<JsonResult> Put(Verify_login ver);
    }
}