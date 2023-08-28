using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface ICities_infoRepository
    {
      Task<JsonResult> Getall();
        
    }
}
