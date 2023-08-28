using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public class FormdataRepository : IFormdataRepository
    {

        private readonly IConfiguration _configuration;
        public FormdataRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }


        //Need to Pass District_Id what ever that is
        public async Task<JsonResult> Getall(string id)
        {
            string query ="";
            if(id == "0")
            {
                query = @"
                            select *
                            from
                            dbo.formdata
                            ORDER BY id desc
                            ";
            }
            else
            {
                query = @"
                            select *
                            from
                            dbo.formdata where District_Id = '"+ id + "'ORDER BY id desc";
            }

            

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


        public async Task<JsonResult> GetbyId(int id)
        {
            string query = @"
                            select *
                            from
                            dbo.formdata
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

        public async Task<JsonResult> Insertbyemail(Formdata fds)
        {

            string query = @"select District_Id from Cities_info where City_Name like @City_Name";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@City_Name", "%" + fds.City + "%");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
                foreach (DataRow row1 in table.Rows)
                {
                    fds.District_Id = row1["District_Id"].ToString();
                }
            }
            query = @"      insert into dbo.formdata
                           (FullName,countries,Fieldofstudy,Email,Contactnumber,City,Score,BudgetRange,Currentedulevel,dates,Year,Institute_Name,District_Id)
                    values (@FullName,@countries,@Fieldofstudy,@Email,@Contactnumber,@City,@Score,@BudgetRange,@Currentedulevel,@dates,@Year,@Institute_Name,@District_Id)
                            ";


             table = new DataTable();
             sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
             await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@FullName", fds.FullName);
                    myCommand.Parameters.AddWithValue("@countries", fds.countries);
                    myCommand.Parameters.AddWithValue("@Fieldofstudy", fds.Fieldofstudy);
                    myCommand.Parameters.AddWithValue("@Email", fds.Email);
                    myCommand.Parameters.AddWithValue("@Contactnumber", fds.Contactnumber);
                    myCommand.Parameters.AddWithValue("@City", fds.City);
                    myCommand.Parameters.AddWithValue("@Score", fds.Score);
                    myCommand.Parameters.AddWithValue("@BudgetRange", fds.BudgetRange);
                    myCommand.Parameters.AddWithValue("@Currentedulevel", fds.Currentedulevel);
                    myCommand.Parameters.AddWithValue("@Year", fds.Year);
                    myCommand.Parameters.AddWithValue("@Institute_Name", fds.Institute_Name);
                    string gs = DateTime.Now.ToString("yyyy-MM-dd");
                    myCommand.Parameters.AddWithValue("@dates", gs.ToString());
                    myCommand.Parameters.AddWithValue("@District_Id", fds.District_Id.ToString());
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Form Submitted Successfully");
        }

        //  Filter by Countries , return All Without any Filter 
        public async Task<JsonResult> countries(string countries)
        {
            if (countries == "All")
            {
                countries = "";
            }
            string query = @"
                            select 
                            *
                            from
                            dbo.formdata
                            where countries like @countries
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@countries", "%" + countries + "%");
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
