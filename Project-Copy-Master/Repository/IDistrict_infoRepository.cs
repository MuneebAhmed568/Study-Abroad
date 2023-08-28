using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IDistrict_infoRepository
    {
        Task<JsonResult> Getall();
    }
}
