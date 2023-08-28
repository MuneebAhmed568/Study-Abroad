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
    public class BlogsRepository : IBlogsRepository
    {
        private readonly IConfiguration _configuration;
        public BlogsRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public async Task<JsonResult> Getall()
        {
            string query = @"
                            select *
                            from
                            dbo.Blogs order by Dates desc                
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

        public async Task<JsonResult> GetbyId(int id)
        {
            string query = @"
                            select *
                            from
                            dbo.Blogs
                            where Id=@id
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

        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for adding new StudyAdds */

        public async Task<JsonResult> PostBLog([FromForm] Blogs blog)
        {

            string query = @"
                           insert into dbo.Blogs
                           (Category,Heading_1,Para_1,Heading_2,Para_2,Heading_3,Para_3,Heading_4,Para_4, Heading_5,Para_5, Heading_6,Para_6, Heading_7,Para_7,Imageipfs,Dates)
                    values (@Category,@Heading_1,@Para_1,@Heading_2,@Para_2,@Heading_3,@Para_3,@Heading_4,@Para_4,@Heading_5,@Para_5,@Heading_6,@Para_6,@Heading_7,@Para_7,@Imageipfs,@Dates)
                            ";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Category", blog.Category);
                    myCommand.Parameters.AddWithValue("@Heading_1", blog.Heading_1);
                    myCommand.Parameters.AddWithValue("@Para_1", blog.Para_1);
                    myCommand.Parameters.AddWithValue("@Heading_2", blog.Heading_2);
                    myCommand.Parameters.AddWithValue("@Para_2", blog.Para_2);
                    myCommand.Parameters.AddWithValue("@Heading_3", blog.Heading_3);
                    myCommand.Parameters.AddWithValue("@Para_3", blog.Para_3);

                    myCommand.Parameters.AddWithValue("@Heading_4", blog.Heading_4);

                    myCommand.Parameters.AddWithValue("@Para_4", blog.Para_4);

                    myCommand.Parameters.AddWithValue("@Heading_5", blog.Heading_5);

                    myCommand.Parameters.AddWithValue("@Para_5", blog.Para_5);

                    myCommand.Parameters.AddWithValue("@Heading_6", blog.Heading_6);

                    myCommand.Parameters.AddWithValue("@Para_6", blog.Para_6);
                    myCommand.Parameters.AddWithValue("@Heading_7", blog.Heading_7);

                    myCommand.Parameters.AddWithValue("@Para_7", blog.Para_7);
                    myCommand.Parameters.AddWithValue("@Imageipfs", blog.Imageipfs);
                    string currentdate = DateTime.Now.ToString("yyyy-MM-dd");
                    myCommand.Parameters.AddWithValue("@Dates", currentdate);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Add Posted Successfully");
        }

        public async Task<JsonResult> GetTopone()
        {
            string query = @"
                           select  top 1 *
                            from
                            dbo.Blogs order by Dates desc               
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

    }
}
