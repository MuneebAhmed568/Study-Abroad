using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface ICommentsinfoRepository
    {
        Task<JsonResult> Getall(string Pagename);
        Task<JsonResult> Insertbyemail(Commentsinfo conns);
    }
}