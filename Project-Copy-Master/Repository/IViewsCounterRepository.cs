using Microsoft.AspNetCore.Mvc;
using Project_Copy_Master.Models;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public interface IViewsCounterRepository
    {
        Task<JsonResult> AddsSinglepageviewsupdate(ViewsCounter views);
        Task<JsonResult> ConsultantSinglepageviewsupdate(ViewsCounter views);
        Task<JsonResult> Getconsultantbyemail(string email);
        Task<JsonResult> Getuniversitybyemail(string email);
        Task<JsonResult> MainAddspageviewsupdate();
        Task<JsonResult> MainConsultantpageviewsupdate();
        Task<JsonResult> MainNewspageviewsupdate();
        Task<JsonResult> Mainpageviewsupdate();
        Task<JsonResult> MainScholarshippageviewsupdate();
        Task<JsonResult> MainUniversitypageviewsupdate();
        Task<JsonResult> NewsSinglepageviewsupdate(ViewsCounter views);
        Task<JsonResult> ScholarshipSinglepageviewsupdate(ViewsCounter views);
        Task<JsonResult> UniversitySinglepageviewsupdate(ViewsCounter views);
    }
}