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
    public class addsinfoRepository : IaddsinfoRepository
    {
        int i = 0;
        int j = 0;
        int k = 0;
        string message = "";
        string path = "";
        string fileName = "";

        private readonly IConfiguration _configuration;
        public addsinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        /*Called on StudyAdsView*/

        public async Task<JsonResult> Getall()
        {
            string currentdate = DateTime.Now.ToString("yyyy-MM-dd");
            String activeandexpiretimes = DateTime.Now.ToString("HH-mm");
            string query = @"
                           update addsinfo set statuscheck='pending'
                           where statuscheck!='pending' and expiredates <= @expiredates  and expiretime <@expiretime ;
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@expiredates", currentdate);
                    myCommand.Parameters.AddWithValue("@expiretime", activeandexpiretimes);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            currentdate = DateTime.Now.ToString("yyyy-MM-dd");
            activeandexpiretimes = DateTime.Now.ToString("HH-mm");
            query = @"
                            select top 500 * from addsinfo where statuscheck!='pending' and expiredates >=@expiredates";

            table = new DataTable();
            sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader1;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@expiredates", currentdate);
                    // myCommand.Parameters.AddWithValue("@expiretime", activeandexpiretimes);
                    myReader1 = myCommand.ExecuteReader();
                    table.Load(myReader1);
                    myReader1.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }




        /*Was Called on AddsApprovel (by admin)*/

        public async Task<JsonResult> Getbystatuspending()
        {
            string query = @"
                            select 
                            *
                            from
                            dbo.addsinfo
                            where statuscheck=@statuscheck
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@statuscheck", "pending");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) */

        public async Task<JsonResult> Getbyemail(string email)
        {
            string query = @"
                            select 
                            id,title,dates,id,statuscheck
                            from
                            dbo.addsinfo
                            where email=@email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile)  and also in single page (SinglestudyAdspage) */


        public async Task<JsonResult> Getbyid(int id)
        {
            string query = @"
                            select
                            *
                            from
                            dbo.addsinfo
                            where Id=@Id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id.ToString());
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }


        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for adding new StudyAdds */

        public async Task<JsonResult> PostByadd([FromForm] addsinfo adds)
        {

            string query = @"
                           insert into dbo.addsinfo
                           (title,Country,Educationlevel,detail,Email,dates,statuscheck,imageurl,imageurlbase64, expiretime,expiredates,activatetime,activatedate)
                    values (@title,@Country,@Educationlevel,@detail,@Email,@dates,@statuscheck,@imageurl,@imageurlbase64,@expiretime,@expiredates,@activatetime,@activatedate)
                            ";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@title", adds.title);
                    myCommand.Parameters.AddWithValue("@Country", adds.Country);
                    myCommand.Parameters.AddWithValue("@Educationlevel", adds.Educationlevel);
                    myCommand.Parameters.AddWithValue("@detail", adds.detail);
                    myCommand.Parameters.AddWithValue("@Email", adds.Email);
                    string gs = DateTime.Now.ToString("dd-MM-yyyy");
                    myCommand.Parameters.AddWithValue("@imageurl", "none");
                    myCommand.Parameters.AddWithValue("@dates", gs.ToString());

                    myCommand.Parameters.AddWithValue("@imageurlbase64", adds.imageurlbase64);

                    myCommand.Parameters.AddWithValue("@statuscheck", "approve");
                    string currentdate = DateTime.Now.ToString("yyyy-MM-dd");
                    myCommand.Parameters.AddWithValue("@activatedate", currentdate);
                    string iDate = currentdate;
                    DateTime oDate = Convert.ToDateTime(iDate);
                    DateTime expiredates = oDate.AddHours(24);
                    string newexpire = expiredates.ToString("yyyy-MM-dd");
                    myCommand.Parameters.AddWithValue("@expiredates", newexpire);
                    String activeandexpiretimes = DateTime.Now.ToString("HH-mm");
                    myCommand.Parameters.AddWithValue("@activatetime", activeandexpiretimes);
                    myCommand.Parameters.AddWithValue("@expiretime", activeandexpiretimes);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(message + "Add Posted Successfully");
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for updating StudyAdds */

        public async Task<JsonResult> Putaddbyid(addsinfo adds)
        {
            string query = @"
                            update dbo.addsinfo
                            set Title=@title,
                            Country=@Country,
                            Educationlevel=@Educationlevel,                           
                            Detail=@detail,
                            dates=@dates
                            where Id=@Id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Title", adds.title);
                    myCommand.Parameters.AddWithValue("@Country", adds.Country);
                    myCommand.Parameters.AddWithValue("@Educationlevel", adds.Educationlevel);
                    myCommand.Parameters.AddWithValue("@Detail", adds.detail);
                    myCommand.Parameters.AddWithValue("@Id", adds.id);
                    string gs = DateTime.Now.ToString("dd-MM-yyyy");
                    myCommand.Parameters.AddWithValue("@dates", gs.ToString());


                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Add Updated Successfully");
        }


        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) for deleting StudyAdds */

        public async Task<JsonResult> Delete(String id)
        {
            string query = @"
                           delete from dbo.addsinfo
                            where id=@id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(" Add Deleted Successfully");
        }



        /* Called on YourAds, yourAdsuni (for cunsultant and University in their profile) */

        public async Task<JsonResult> savepic([FromForm] addsinfo adds)
        {
            string Email = adds.Email;

            string query2 = @"
                            Update dbo.addsinfo
                            set imageurl=@imageurl,
                            imageurlbase64=@imageurlbase64
                            where Email=@Email and id=@id 
                            ";

            DataTable table2 = new DataTable();
            string sqlDataSource2 = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader2;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource2))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", Email);
                    myCommand.Parameters.AddWithValue("@id", adds.id);
                    myCommand.Parameters.AddWithValue("@imageurl", "none");
                    myCommand.Parameters.AddWithValue("@imageurlbase64", adds.imageurlbase64);
                    myReader2 = myCommand.ExecuteReader();
                    table2.Load(myReader2);
                    myReader2.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(message);
        }




        public async Task<JsonResult> Getbycountries(string Country)
        {
            if (Country == "All")
            {
                Country = "";
            }
            string query = @"
                            select 
                            Title,Detail,imageurlbase64
                            from
                            dbo.addsinfo
                            where Country like @Country and
                            statuscheck!='pending'
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@Country", "%" + Country + "%");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }


        public async Task<JsonResult> pickpic(addsinfo adds)
        {
             adds.ImageByte = System.IO.File.ReadAllBytes(adds.imageurl);
            return new JsonResult(adds.ImageByte);
        }


    }

}
