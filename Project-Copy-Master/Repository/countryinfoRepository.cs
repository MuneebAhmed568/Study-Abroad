using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public class countryinfoRepository : IcountryinfoRepository
    {

        string check = "";
        string path = "";
        string fileName = "";
        private readonly IConfiguration _configuration;
        public countryinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public async Task<JsonResult> Getall()
        {
            string query = @"
                           select 
                            Top 6 
                            id,Country_Name,CountryLogo_Ipfs
                            from
                            dbo.countryinfo
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }



        public async Task<JsonResult> Getallinfo()
        {
            string query = @"
                           select 
                            Top 100 
                            id,Country_Name,CountryLogo_Ipfs
                            from
                            dbo.countryinfo
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }



        public async Task<JsonResult> Getbyid(int id)
        {
            string query = @"
                            select *
                            from
                            dbo.countryinfo
                            where id=@id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", id.ToString());
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }
    }
}

