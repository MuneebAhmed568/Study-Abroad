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
    public class scholarshipinfoRepository : IscholarshipinfoRepository
    {
        int i = 0;
        int j = 0;
        int k = 0;
        string message = "";
        string path = "";
        string fileName = "";

        private readonly IConfiguration _configuration;
        public scholarshipinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }


        public async Task<JsonResult> Getall()
        {

            string currentdate = DateTime.Now.ToString("yyyy-MM-dd");
            String activeandexpiretimes = DateTime.Now.ToString("HH-mm");
            string query = @"
                           update scholarshipinfo set statuscheck='pending'
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
                            select top 5 id,title,email,shortdiscription,detail,imageurlbase64,dates
                            from
                            dbo.scholarshipinfo where statuscheck!='pending' and expiredates >=@expiredates ";

            table = new DataTable();
            sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader1;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
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

        public async Task<JsonResult> Getallinfo()
        {

            string currentdate = DateTime.Now.ToString("yyyy-MM-dd");
            String activeandexpiretimes = DateTime.Now.ToString("HH-mm");
            string query = @"
                           update scholarshipinfo set statuscheck='pending'
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
                            select top 500 id,title,email,shortdiscription,detail,imageurlbase64
                            from
                            dbo.scholarshipinfo where statuscheck!='pending' and expiredates >=@expiredates and expiretime != @expiretime
                            ";

            table = new DataTable();
            sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader1;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@expiredates", currentdate);
                    myCommand.Parameters.AddWithValue("@expiretime", activeandexpiretimes);
                    myReader1 = myCommand.ExecuteReader();
                    table.Load(myReader1);
                    myReader1.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);

        }



        public async Task<JsonResult> Getbyemail(string email)
        {
            string query = @"
                            select 
                            id,title,shortdiscription,countries,detail,imageurl,email,dates,statuscheck
                            from
                            dbo.scholarshipinfo
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
                    myCommand.Parameters.AddWithValue("@Email", email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        public async Task<JsonResult> countries(string countries)
        {

            if (countries == "All")
            {
                countries = "";
            }
            string query = @"
                            select 
                            id, title,email,shortdiscription,detail,imageurlbase64
                            from
                            dbo.scholarshipinfo
                            where countries like @countries
                            and
                            statuscheck!='pending' order by id desc
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


        public async Task<JsonResult> Getbyid(int id)
        {
            string query = @"
                            select 
                            *
                            from
                            dbo.scholarshipinfo
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

        public async Task<JsonResult> Getbystatuspending()
        {
            string query = @"
                            select 
                            *
                            from
                            dbo.scholarshipinfo
                            where statuscheck=@statuscheck
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
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


        public async Task<JsonResult> PosteventByemail([FromForm] eventsinfo enet)
        {
            string Email = enet.email;

            string query = @"
                           insert into dbo.scholarshipinfo
                           (title,shortDiscription,countries,detail,imageurl,email,dates,statuscheck,imageurlbase64 , expiretime,expiredates,activatetime,activatedate)
                    values (@title,@shortDiscription,@Countries,@detail,@imageurl,@email,@dates,@statuscheck,@imageurlbase64,@expiretime,@expiredates,@activatetime,@activatedate)
                            ";


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@title", enet.title);
                    myCommand.Parameters.AddWithValue("@ShortDiscription", enet.shortDiscription);
                    myCommand.Parameters.AddWithValue("@Countries", enet.Countries);
                    myCommand.Parameters.AddWithValue("@detail", enet.detail);
                    myCommand.Parameters.AddWithValue("@imageurl", "none");
                    myCommand.Parameters.AddWithValue("@email", enet.email);
                    string gs = DateTime.Now.ToString("dd-MM-yyyy");
                    myCommand.Parameters.AddWithValue("@dates", gs.ToString());
                    myCommand.Parameters.AddWithValue("@imageurlbase64", enet.imageurlbase64);

                    myCommand.Parameters.AddWithValue("@statuscheck", "approve");
                    string currentdate = DateTime.Now.ToString("yyyy-MM-dd");
                    myCommand.Parameters.AddWithValue("@activatedate", currentdate);
                    string iDate = currentdate;
                    DateTime oDate = Convert.ToDateTime(iDate);
                    DateTime expiredates = oDate.AddMonths(6);
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
            return new JsonResult("Scholarship Posted Successfully");
        }


        public async Task<JsonResult> Puteventbyid(eventsinfo enet)
        {
            string query = @"
                            update dbo.scholarshipinfo
                            set title=@title,
                            ShortDiscription=@ShortDiscription,
                            Countries=@Countries,
                            detail=@detail,                            
                            email = @email,
                            dates = @dates
                            where Id=@Id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@title", enet.title);
                    myCommand.Parameters.AddWithValue("@ShortDiscription", enet.shortDiscription);
                    myCommand.Parameters.AddWithValue("@Countries", enet.Countries);
                    myCommand.Parameters.AddWithValue("@detail", enet.detail);
                    myCommand.Parameters.AddWithValue("@email", enet.email);
                    string gs = DateTime.Now.ToString("dd-MM-yyyy");
                    myCommand.Parameters.AddWithValue("@dates", gs.ToString());
                    myCommand.Parameters.AddWithValue("@Id", enet.id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Scholarship Updated Successfully");
        }




        public async Task<JsonResult> Delete(int id)
        {
            string query = @"
                           delete from dbo.scholarshipinfo
                            where Id=@Id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Scholarship Deleted Successfully");
        }




        public async Task<JsonResult> savepic([FromForm] eventsinfo enet)
        {
            string message = "Start";
            string Email = enet.email;

            string query2 = @"
                            Update dbo.scholarshipinfo
                            set imageurl=@imageurl,
                            imageurlbase64=@imageurlbase64
                            where Email=@Email and id=@id 
                            ";

            DataTable table2 = new DataTable();
            string sqlDataSource2 = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader2;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource2))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", Email);
                    myCommand.Parameters.AddWithValue("@id", enet.id);
                    myCommand.Parameters.AddWithValue("@imageurl", "none");
                    myCommand.Parameters.AddWithValue("@imageurlbase64", enet.imageurlbase64);
                    myReader2 = myCommand.ExecuteReader();
                    table2.Load(myReader2);
                    myReader2.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(message);
        }




        public async Task<JsonResult> pickpic(eventsinfo enet)
        {
            enet.ImageByte = System.IO.File.ReadAllBytes(enet.imageurl);
            return new JsonResult(enet.ImageByte);
        }



        public async Task<JsonResult> Putreviewbyid(scholarshipinfo scho)
        {
            string totalreviewscount = "";
            string totalusercount = "";
            string averagecount = "";
            string rate = "";
            float floattotalreviewscount = 0;
            float floattotalusercount = 0;
            float floataveragecount = 0;
            float floatrate = 0;


            string query = @"
                            select totalreviewscount,totalusercount,averagecount from dbo.scholarshipinfo
                            where id=@id  ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", scho.id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {

                    totalreviewscount = row1["totalreviewscount"].ToString();
                    if (totalreviewscount == "")
                    {
                        totalreviewscount = "0";
                    }
                    totalusercount = row1["totalusercount"].ToString();
                    if (totalusercount == "")
                    {
                        totalusercount = "0";
                    }
                    averagecount = row1["averagecount"].ToString();
                    if (totalreviewscount == "")
                    {
                        totalreviewscount = "0";
                    }

                }
            }

            floattotalreviewscount = float.Parse(totalreviewscount);
            floattotalreviewscount += float.Parse(scho.rate);

            floattotalusercount = float.Parse(totalusercount);
            floattotalusercount += 1;
            if (floattotalreviewscount == 0 || floattotalusercount == 0)
            {
                floattotalreviewscount = float.Parse(scho.rate);
                floattotalusercount = 1;
            }

            float average = floattotalreviewscount / floattotalusercount;
            floataveragecount = average;

            string query1 = @"
                            
                            Update dbo.scholarshipinfo
                            set totalreviewscount=@totalreviewscount,
                            totalusercount=@totalusercount,
                            averagecount=@averagecount
                            where id=@id 
                            ";

            DataTable table1 = new DataTable();
            string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader1;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                {

                    myCommand.Parameters.AddWithValue("@totalreviewscount", floattotalreviewscount.ToString());
                    myCommand.Parameters.AddWithValue("@totalusercount", floattotalusercount.ToString());
                    myCommand.Parameters.AddWithValue("@averagecount", floataveragecount.ToString());
                    myCommand.Parameters.AddWithValue("@id", scho.id);
                    myReader1 = myCommand.ExecuteReader();
                    table1.Load(myReader1);
                    myReader1.Close();
                    myCon.Close();
                }

            }
            return new JsonResult("Thankyou for your Review :)");
        }
    }
}
