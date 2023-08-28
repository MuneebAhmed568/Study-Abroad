using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class Instituteinfo
    {
        public string institutename { get; set; }
        public string email { get; set; }
        public int id { get; set; }
        public string detail { get; set; }
        public string password { get; set; }
        public string websitelink { get; set; }

        public string Contactno { get; set; }
        public string country { get; set; }
        [NotMapped]
        public string newpassword { get; set; }
        public string statuscheck { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Designation { get; set; }
        public string Qsworldranking { get; set; }
        public string Coverpicurlbase64 { get; set; }
        public string mainpicurlbase64 { get; set; }
        public string mainpicurl { get; set; }
        public string Coverpicurl { get; set; }
        
        public string Forbestranking { get; set; }
        public string Timeshighereducationranking { get; set; }
        public string Locationtitle { get; set; }
        public string Locationcountry { get; set; }
        public string Locationcity { get; set; }
        public string Fulladdress { get; set; }
        [NotMapped]
        public IFormFile files { get; set; } = null;
        [NotMapped]
        public Byte[] ImageByte { get; set; }
        public string totalreviewscount { get; set; }
        public string totalusercount { get; set; }
        public string averagecount { get; set; }
        [NotMapped]
        public string rate { get; set; }


    }
}
