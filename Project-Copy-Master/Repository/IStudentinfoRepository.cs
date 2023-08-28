using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IStudentinfoRepository
    {
        Task<JsonResult> Getall();
        Task<JsonResult> GetbyEmail(string email);
        Task<JsonResult> Getbystatuspending();
        Task<JsonResult> Post(Studentinfo stu);
        Task<JsonResult> Putbyemail(Studentinfo stu);
        Task<JsonResult> PutbyPassword(Studentinfo stu);
        Task<JsonResult> Putbyupdemails(Studentinfo stu);
        Task<JsonResult> Putupdatestatus(Studentinfo stu);
        Task<JsonResult> savepic([FromForm] Studentinfo stu);
    }
}