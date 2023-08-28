using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Service
{
    public interface IAuthenticateService
    {
        string Authenticate(string identifier);
    }
}
