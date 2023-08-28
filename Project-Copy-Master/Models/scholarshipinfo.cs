using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class scholarshipinfo
    {
        public string title { get; set; }
        public string shortDiscription { get; set; }
        public int id { get; set; }
        public string Countries { get; set; }

        public string detail { get; set; }
        public string email { get; set; }
        
        public string dates { get; set; }

        public string imageurl { get; set; }
        [NotMapped]
        public IFormFile files { get; set; } = null;
        [NotMapped]
        public Byte[] ImageByte { get; set; }
       
        public string totalreviewscount { get; set; }
        public string totalusercount { get; set; }
        public string averagecount { get; set; }
        public string imageurlbase64 { get; set; }
        public string statuscheck { get; set; }
        [NotMapped]
        public string rate { get; set; }

        public string activatedate { get; set; }
        public string activatetime { get; set; }
        public string expiredates { get; set; }
        public string expiretime { get; set; }
    }
}
