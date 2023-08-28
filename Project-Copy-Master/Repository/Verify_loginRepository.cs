using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Models;
using Project_Copy_Master.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public class Verify_loginRepository : IVerify_loginRepository
    {
        public string identifier = "0";
        private readonly IConfiguration _configuration;
        private IAuthenticateService _authenticateService;
        public Verify_loginRepository(IConfiguration configuration, IAuthenticateService authenticateService)
        {
            _configuration = configuration;
            _authenticateService = authenticateService;
        }

        public async Task<JsonResult> Get(string email, string password)
        {
            string query = @"
                            select identifier from
                            dbo.Verify_login
                            where email=@email and password=@password 
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@email", email);
                    myCommand.Parameters.AddWithValue("@password", password);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
                foreach (DataRow row in table.Rows)
                {
                    identifier = row["identifier"].ToString();
                }

            }
            if (identifier == "0")
            {
                return new JsonResult("Incorrect Username or Passowrd");
            }
            if (identifier != "" && identifier != null)
            {
                var user = _authenticateService.Authenticate(identifier);
                newreturn n = new newreturn();
                n.token = user.ToString();
                n.identifier = identifier.ToString();
                return new JsonResult(n);
            }
            else
            {
                return new JsonResult("Incorrect Username or Passowrd");
            }
        }

        public async Task<JsonResult> Getbyemail(string email)
        {
            string query = @"
                            select identifier from
                            dbo.Verify_login
                            where email=@email 
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@email", email);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
                foreach (DataRow row in table.Rows)
                {
                    identifier = row["identifier"].ToString();
                }

            }
            return new JsonResult(identifier.ToString());
        }





        public async Task<JsonResult> Post(Verify_login ver)
        {
            string query = @"
                           insert into dbo.Verify_login
                            (Email,Password,identifier)
                           values (@Email,@Password, @identifier)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", ver.Email);
                    myCommand.Parameters.AddWithValue("@Password", ver.Password);
                    myCommand.Parameters.AddWithValue("@identifier", ver.value);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        public async Task<JsonResult> Put(Verify_login ver)
        {
            string query = @"
                           update dbo.Verify_login
                           set Password= @Password
                            where Email=@Email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", ver.Email);
                    myCommand.Parameters.AddWithValue("@Password", ver.Password);
                    myCommand.Parameters.AddWithValue("@identifier", ver.identifier);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }
    }
    class newreturn
    {
        public string token;
        public string identifier;
    }
}
