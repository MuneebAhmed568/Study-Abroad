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
    public class CommentsinfoRepository : ICommentsinfoRepository
    {
        private readonly IConfiguration _configuration;

        public CommentsinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<JsonResult> Insertbyemail(Commentsinfo conns)
        {

            string query = @"
                           insert into dbo.commentsinfo
                           (FirstName,LastName,Email,Subjects,Messagess,Pagename,dates)
                    values (@FirstName,@LastName,@Email,@Subjects,@Messagess,@Pagename,@dates)
                            ";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@FirstName", conns.FirstName);
                    myCommand.Parameters.AddWithValue("@LastName", conns.LastName);
                    myCommand.Parameters.AddWithValue("@Email", conns.Email);
                    myCommand.Parameters.AddWithValue("@Subjects", conns.Subjects);
                    myCommand.Parameters.AddWithValue("@Messagess", conns.Messagess);
                    myCommand.Parameters.AddWithValue("@Pagename", conns.Pagename);
                    string gs = DateTime.Now.ToString("yyyy-MM-dd");
                    myCommand.Parameters.AddWithValue("@dates", gs.ToString());
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Comment Submitted Successfully");
        }


        public async Task<JsonResult> Getall(string Pagename)
        {
            string query = @"
                            select 
                            Top 5 * from
                            dbo.commentsinfo
                            where Pagename=@Pagename
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Pagename", Pagename);
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

