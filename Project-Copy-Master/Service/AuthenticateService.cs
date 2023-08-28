using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Project_Copy_Master.Models;

namespace Project_Copy_Master.Service
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IConfiguration _configuration;
        public readonly AppSettings _appSettings;

        public string Token { get; private set; }

        public AuthenticateService(IOptions<AppSettings> appsettings, IConfiguration configuration)
        {
            _configuration = configuration;
            _appSettings = appsettings.Value;
        }


        [Authorize]
        public string Authenticate(string identifier)
        {
            string role = "";
            if(identifier == "1")  //student
            {
                role = "Student";
            }
            else if(identifier == "2") //Consultant 
            {
                role = "Consultant";
            }
            else if (identifier == "3") //Institute /University 
            {
                role = "Institute";
            }
            else if (identifier == "4") //MAIN ADMIN
            {
                role = "MAIN_ADMIN";
            }
            else
            {
                role = "Fake";
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_appSettings.Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    
                    new Claim(ClaimTypes.Role, role),
                    new Claim(ClaimTypes.Version, "v4")
                }),


                //Changed Days to Minute to Verify
                Expires = DateTime.UtcNow.AddHours(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            IdentityModelEventSource.ShowPII = true;
            var token = tokenHandler.CreateToken(tokenDescriptor);
            Token = tokenHandler.WriteToken(token);
          
            return (Token);
        }
       
       


    }
}

