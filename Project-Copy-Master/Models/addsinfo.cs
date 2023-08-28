using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Copy_Master.Models
{
    public class addsinfo
    {
        public string title { get; set; }
        public int id { get; set; }
        public string dates { get; set; }
      
        public string Country { get; set; }
        public string Educationlevel { get; set; }
        
        public string Email { get; set; }
        public string detail { get; set; }
        public string statuscheck { get; set; }
        public string imageurl { get; set; }
        public string imageurlbase64 { get; set; }
        [NotMapped]
        public IFormFile files { get; set; } = null;
        [NotMapped]
        public Byte[] ImageByte { get; set; }

        public string activatedate { get; set; }
        public string activatetime { get; set; }
        public string expiredates { get; set; }
        public string expiretime { get; set; }
    }
}
