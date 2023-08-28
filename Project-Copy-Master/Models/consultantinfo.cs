using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class consultantinfo
    {
        
        public string Personname { get; set; }
        public int id { get; set; }
        public string CompanyName { get; set; }
        public string Conatctno { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        [NotMapped]
        public string newpassword { get; set; }
       
        public string Address { get; set; }

        public string City { get; set; }
        public string websitelink { get; set; }
        public string companylogo { get; set; }
        public string companylogobase64 { get; set; }
        public string consultancyservices { get; set; }
        public string service { get; set; }
        public string Detail { get; set; }
        public string statuscheck { get; set; }

        public string Phoneno { get; set; }
      
        public string mapaddress { get; set; }
        [NotMapped]
        public IFormFile files { get; set; } = null;
        [NotMapped]
        public Byte[] ImageByte { get; set; }

        public string totalreviewscount { get; set; }
        public string totalusercount { get; set; }
        public string averagecount { get; set; }
        [NotMapped]
        public string rate { get; set; }

        public string Branch { get; set; }
        public string Heads_email { get; set; }
        public string District_Id { get; set; }

    }
}
