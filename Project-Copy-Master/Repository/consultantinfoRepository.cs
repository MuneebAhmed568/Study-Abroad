using Microsoft.AspNetCore.Hosting;
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
    public class consultantinfoRepository : IconsultantinfoRepository
    {

        string check = "";
        string path = "";
        string fileName = "";

        private readonly IConfiguration _configuration;
        public consultantinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }



        public async Task<JsonResult> Getall()
        {
            string query = @"
                            select 
                            Top 6 * from
                            dbo.Consultantinfo
                            where statuscheck!='pending'
                            order by averagecount desc
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                     myReader =  myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                     myCon.Close();
                }
            }

            return  new JsonResult  (table);
        }



        public async Task<JsonResult> Getallinfo()
        {
            string query = @"
                            select 
                            Top 100 * from
                            dbo.Consultantinfo
                            where statuscheck!='pending'
                            order by averagecount desc
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
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




        public async Task<JsonResult> Getbystatuspending()
        {
            string query = @"select 
                            *
                            from
                            dbo.Consultantinfo
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





        public async Task<JsonResult> GetbyEmail(string email)
        {

            string query = @"
                            select *
                            from
                            dbo.Consultantinfo where Email=@Email
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


        public async Task<JsonResult> Post(consultantinfo cons)
        {
            if(cons.Branch == "Main")
            {
                cons.Heads_email = "no";
                cons.District_Id = "0";
            }
           
            string query = @"
                           insert into dbo.Consultantinfo
                           (CompanyName,Email,Conatctno,Password,statuscheck,companylogobase64,Branch,Heads_email,District_Id)
                            values (@CompanyName,@Email,@Conatctno,@Password,@statuscheck,@companylogobase64,@Branch,@Heads_email,@District_Id)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@CompanyName", cons.CompanyName);
                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
                    myCommand.Parameters.AddWithValue("@Conatctno", cons.Conatctno);
                    myCommand.Parameters.AddWithValue("@password", cons.password);
                    myCommand.Parameters.AddWithValue("@statuscheck", "pending");
                    myCommand.Parameters.AddWithValue("@Branch", cons.Branch.ToString());
                    myCommand.Parameters.AddWithValue("@Heads_email", cons.Heads_email.ToString());
                    myCommand.Parameters.AddWithValue("@District_Id", cons.District_Id.ToString());
                    myCommand.Parameters.AddWithValue("@companylogobase64", "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Account Created Successfully. Please Login !");
        }



        public async Task<JsonResult> Putbyemail(consultantinfo cons)
        {
            string query = @"
                            update dbo.Consultantinfo
                            set CompanyName=@CompanyName,
                            Conatctno=@Conatctno,
                            Phoneno=@Phoneno,
                            Address=@Address,
                            City=@City,
                            websitelink=@websitelink,
                            consultancyservices=@consultancyservices,
                            services=@services,
                            Detail=@Detail,
                            mapaddress=@mapaddress,
                            Personname=@Personname
                            where Email=@Email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@CompanyName", cons.CompanyName);
                    myCommand.Parameters.AddWithValue("@Conatctno", cons.Conatctno);
                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
                    myCommand.Parameters.AddWithValue("@Address", cons.Address);
                    myCommand.Parameters.AddWithValue("@City", cons.City);
                    myCommand.Parameters.AddWithValue("@websitelink", cons.websitelink);
                    myCommand.Parameters.AddWithValue("@Personname", cons.Personname);
                    myCommand.Parameters.AddWithValue("@consultancyservices", cons.consultancyservices);
                    myCommand.Parameters.AddWithValue("@services", cons.service);
                    myCommand.Parameters.AddWithValue("@Detail", cons.Detail);
                    myCommand.Parameters.AddWithValue("@mapaddress", "Location ");
                    myCommand.Parameters.AddWithValue("@Phoneno", cons.Phoneno);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Record Successfully");
        }


        public async Task<JsonResult> Putupdatestatus(consultantinfo cons)
        {
            string query = @"
                            update dbo.Consultantinfo
                            set statuscheck=@statuscheck                           
                            where Email=@Email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
                    myCommand.Parameters.AddWithValue("@statuscheck", "approve");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            query = @"
                           insert into dbo.ViewsCounter
                           (Email,Pagetype1,ViewcurrentmonthPagetype1,ViewpreviousmonthPagetype1,Pagetype2,ViewcurrentmonthPagetype2,ViewpreviousmonthPagetype2,Pagetype3,ViewcurrentmonthPagetype3,ViewpreviousmonthPagetype3,Pagetype4,ViewcurrentmonthPagetype4,ViewpreviousmonthPagetype4,refreshdatadate1,refreshdatadate2,refreshdatadate3,refreshdatadate4,refreshdatadate5)
                            values (@Email,@Pagetype1,@ViewcurrentmonthPagetype1,@ViewpreviousmonthPagetype1,@Pagetype2,@ViewcurrentmonthPagetype2,@ViewpreviousmonthPagetype2,@Pagetype3,@ViewcurrentmonthPagetype3,@ViewpreviousmonthPagetype3,@Pagetype4,@ViewcurrentmonthPagetype4,@ViewpreviousmonthPagetype4,@refreshdatedate1,@refreshdatedate2,@refreshdatedate3,@refreshdatedate4,@refreshdatedate5)
                            ";

            table = new DataTable();
            sqlDataSource = _configuration.GetConnectionString("DefaultConnection");

            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Pagetype1", "Consultant");
                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype1", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype1", 0);

                    myCommand.Parameters.AddWithValue("@Pagetype2", "Adds");
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype2", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype2", 0);

                    myCommand.Parameters.AddWithValue("@Pagetype3", "News");
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype3", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype3", 0);

                    myCommand.Parameters.AddWithValue("@Pagetype4", "null");
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype4", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype4", 0);

                    myCommand.Parameters.AddWithValue("@refreshdatedate1", "30");
                    myCommand.Parameters.AddWithValue("@refreshdatedate2", "30");
                    myCommand.Parameters.AddWithValue("@refreshdatedate3", "30");
                    myCommand.Parameters.AddWithValue("@refreshdatedate4", "30");
                    myCommand.Parameters.AddWithValue("@refreshdatedate5", "30");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }


            return new JsonResult("Status Approved Successfully");
        }





        public async Task<JsonResult> PutbyPassword(consultantinfo cons)
        {
            string statucheck = "";

            string query = @"
                            select Email from dbo.Consultantinfo
                            where Email=@Email and password=@password
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
                    myCommand.Parameters.AddWithValue("@password", cons.password);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {
                    statucheck = "Inside For Each";
                    check = row1["Email"].ToString();
                }
            }

            if (check == cons.Email)
            {

                string query1 = @"
                            Update dbo.Consultantinfo
                            set password=@newpassword
                            where Email=@Email 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Email", cons.Email);
                        myCommand.Parameters.AddWithValue("@newpassword", cons.newpassword);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }


                string query2 = @"
                            Update dbo.Verify_login
                            set password=@newpassword
                            where Email=@Email 
                            ";

                DataTable table2 = new DataTable();
                string sqlDataSource2 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader2;
                await using(SqlConnection myCon = new SqlConnection(sqlDataSource2))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Email", cons.Email);
                        myCommand.Parameters.AddWithValue("@newpassword", cons.newpassword);
                        myReader2 = myCommand.ExecuteReader();
                        table2.Load(myReader2);
                        myReader2.Close();
                        myCon.Close();
                    }

                }

                statucheck = "Passowrd Updated";
            }
            else
            {
                statucheck = "Current Password is Wrong";
            }
            return new JsonResult(statucheck);
        }






        public async Task<JsonResult> Delete(int id)//query edit
        {
            string query = @"
                           delete from dbo.Consultantinfo
                            where EmployeeId=@EmployeeId
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@EmployeeId", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }




        public async Task<JsonResult> savepic([FromForm] consultantinfo cons)
        {
            string Email = cons.Email;
            string message = "Start";

            string query2 = @"
                            Update dbo.Consultantinfo
                            set companylogo=@companylogo,
                            companylogobase64=@companylogobase64
                            where Email=@Email 
                            ";

            DataTable table2 = new DataTable();
            string sqlDataSource2 = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader2;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource2))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                {
                    myCommand.Parameters.AddWithValue("@email", Email);
                    myCommand.Parameters.AddWithValue("@companylogo", "none");
                    myCommand.Parameters.AddWithValue("@companylogobase64", cons.companylogobase64);
                    message = "Updated";
                    myReader2 = myCommand.ExecuteReader();
                    table2.Load(myReader2);
                    myReader2.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(message);
        }


        public async Task<JsonResult> Getbycountries(string countries)
        {
            if (countries == "All")
            {
                countries = "";
            }
            string query = @"
                            select 
                            id,CompanyName,companylogo,Email,companylogobase64
                            from
                            dbo.Consultantinfo
                            where countries like @countries and
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

                    myCommand.Parameters.AddWithValue("@countries", "%" + countries + "%");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }



            return new JsonResult(table);

        }




        public async Task<JsonResult> pickpic(consultantinfo cons)
        {
             cons.ImageByte = System.IO.File.ReadAllBytes(cons.companylogo);
            return new JsonResult(cons.ImageByte);
        }



        public async Task<JsonResult> Putreviewbyid(consultantinfo cons)
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
                            select totalreviewscount,totalusercount,averagecount from dbo.Consultantinfo
                             where Email=@Email  ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
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
            floattotalreviewscount += float.Parse(cons.rate);

            floattotalusercount = float.Parse(totalusercount);
            floattotalusercount += 1;
            if (floattotalreviewscount == 0 || floattotalusercount == 0)
            {
                floattotalreviewscount = float.Parse(cons.rate);
                floattotalusercount = 1;
            }

            float average = floattotalreviewscount / floattotalusercount;
            floataveragecount = average;

            string query1 = @"
                            
                            Update dbo.Consultantinfo
                            set totalreviewscount=@totalreviewscount,
                            totalusercount=@totalusercount,
                            averagecount=@averagecount
                            where Email=@Email 
                            ";

            DataTable table1 = new DataTable();
            string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader1;
            await using(SqlConnection myCon = new SqlConnection(sqlDataSource1))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                {

                    myCommand.Parameters.AddWithValue("@totalreviewscount", floattotalreviewscount.ToString());
                    myCommand.Parameters.AddWithValue("@totalusercount", floattotalusercount.ToString());
                    myCommand.Parameters.AddWithValue("@averagecount", floataveragecount.ToString());
                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
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
