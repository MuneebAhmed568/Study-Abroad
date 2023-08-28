using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class Studentinfo
    {
        public string Fullname { get; set; }
        public string Phoneno { get; set; }
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Qualification { get; set; }

        public string wanttostudy { get; set; }
        public string Location { get; set; }
        public string Interestedcountry { get; set; }
        public string imageurl { get; set; }
        public string imageurlbase64 { get; set; }
        public string statuscheck { get; set; }
        [NotMapped]
        public IFormFile files { get; set; } = null;
        [NotMapped]
        public Byte[] ImageByte { get; set; }
        [NotMapped]
        public string newpassword { get; set; }
        public string scores { get; set; }
        public string course { get; set; }
    }
}
