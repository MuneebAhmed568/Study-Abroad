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
    public class InstituteinfoRepository : IInstituteinfoRepository
    {
        string check = "";
        string message = "";
        string path = "";
        string fileName = "";

        private readonly IConfiguration _configuration;
        public InstituteinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public async Task<JsonResult> Getall()
        {
            string query = @"
                            select top 6 id, institutename,email,country,Detail,mainpicurlbase64
                            from
                            dbo.Instituteinfo
                            where statuscheck!='pending'
                            order by averagecount desc
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
                            select top 100 id, institutename,email,country,Detail,mainpicurlbase64
                            from
                            dbo.Instituteinfo
                            where statuscheck!='pending'
                            order by averagecount desc
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


        public async Task<JsonResult> GetbyEmail(string email)
        {
            string query = @"
                            select * from
                            dbo.Instituteinfo where email=@email
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



        public async Task<JsonResult> Getbystatuspending()
        {
            string query = @"select 
                            *
                            from
                            dbo.Instituteinfo
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




        public async Task<JsonResult> Post(Instituteinfo inst)
        {

            //Contactno
            string query = @"
                           insert into dbo.Instituteinfo
                           (institutename,email,Contactno,password,statuscheck,mainpicurlbase64)
                    values (@institutename,@email,@Contactno,@password,@statuscheck,@mainpicurlbase64)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                await using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@institutename", inst.institutename);
                    myCommand.Parameters.AddWithValue("@email", inst.email);
                    myCommand.Parameters.AddWithValue("@password", inst.password);
                    myCommand.Parameters.AddWithValue("@Contactno", inst.Contactno);
                    myCommand.Parameters.AddWithValue("@statuscheck", "pending");
                    myCommand.Parameters.AddWithValue("@mainpicurlbase64", "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Account Created Successfully. Please Login !");
        }


        public async Task<JsonResult> Putbyemail(Instituteinfo inst)
        {
            string query = @"
                            update dbo.Instituteinfo
                            set institutename=@institutename,
                            websitelink=@websitelink,
                            Detail=@Detail,
                            Contactno=@Contactno,
                            Firstname=@Firstname,
                            Lastname=@Lastname,
                            Designation=@Designation,
                            Qsworldranking=@Qsworldranking,
                            Forbestranking=@Forbestranking,
                            Timeshighereducationranking=@Timeshighereducationranking,
                            Locationtitle=@Locationtitle,
                            Locationcountry=@Locationcountry,
                            Locationcity=@Locationcity,
                            Fulladdress=@Fulladdress,
                            country=@country
                            where email=@email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@institutename", inst.institutename);
                    myCommand.Parameters.AddWithValue("@websitelink", inst.websitelink);
                    myCommand.Parameters.AddWithValue("@Detail", inst.detail);
                    myCommand.Parameters.AddWithValue("@Contactno", inst.Contactno);
                    myCommand.Parameters.AddWithValue("@Firstname", inst.Firstname);
                    myCommand.Parameters.AddWithValue("@Lastname", inst.Lastname);
                    myCommand.Parameters.AddWithValue("@Designation", inst.Designation);
                    myCommand.Parameters.AddWithValue("@Qsworldranking", inst.Qsworldranking);
                    myCommand.Parameters.AddWithValue("@Forbestranking", inst.Forbestranking);
                    myCommand.Parameters.AddWithValue("@Timeshighereducationranking", inst.Timeshighereducationranking);
                    myCommand.Parameters.AddWithValue("@Locationtitle", inst.Locationtitle);
                    myCommand.Parameters.AddWithValue("@Locationcountry", inst.Locationcountry);
                    myCommand.Parameters.AddWithValue("@Locationcity", inst.Locationcity);
                    myCommand.Parameters.AddWithValue("@Fulladdress", inst.Fulladdress);
                    myCommand.Parameters.AddWithValue("@country", inst.country);
                    myCommand.Parameters.AddWithValue("@email", inst.email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Record Successfully");
        }



        public async Task<JsonResult> PutbyPassword(Instituteinfo inst)
        {
            string statucheck = "";

            string query = @"
                            select email from dbo.Instituteinfo
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

                    myCommand.Parameters.AddWithValue("@Email", inst.email);
                    myCommand.Parameters.AddWithValue("@password", inst.password);
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

            if (check == inst.email)
            {

                string query1 = @"
                            Update dbo.Instituteinfo
                            set password=@newpassword
                            where email=@email 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Email", inst.email);
                        myCommand.Parameters.AddWithValue("@newpassword", inst.newpassword);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }


                string query2 = @"
                            Update dbo.Verify_login
                            set password=@newpassword
                            where email=@email 
                            ";

                DataTable table2 = new DataTable();
                string sqlDataSource2 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader2;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource2))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Email", inst.email);
                        myCommand.Parameters.AddWithValue("@newpassword", inst.newpassword);
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


        public async Task<JsonResult> Putupdatestatus(Instituteinfo inst)
        {
            string query = @"
                            update dbo.Instituteinfo
                            set statuscheck=@statuscheck                           
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

                    myCommand.Parameters.AddWithValue("@Email", inst.email);
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

            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Pagetype1", "University");
                    myCommand.Parameters.AddWithValue("@Email", inst.email);
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype1", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype1", 0);

                    myCommand.Parameters.AddWithValue("@Pagetype2", "Adds");
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype2", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype2", 0);

                    myCommand.Parameters.AddWithValue("@Pagetype3", "News");
                    myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype3", 0);
                    myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype3", 0);

                    myCommand.Parameters.AddWithValue("@Pagetype4", "Scholarship");
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









        public async Task<JsonResult> Put(Instituteinfo inst)
        {
            string query = @"
                           update dbo.Instituteinfo
                           set institutename=@institutename,
                            email=@email,
                            websitelink=@websitelink,
                            country=@country,
                            details=@details,
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
                    myCommand.Parameters.AddWithValue("@institutename", inst.institutename);
                    myCommand.Parameters.AddWithValue("@email", inst.email);
                    myCommand.Parameters.AddWithValue("@websitelink", inst.websitelink);

                    myCommand.Parameters.AddWithValue("@details", inst.detail);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }



        public async Task<JsonResult> Delete(int id)
        {
            string query = @"
                           delete from dbo.Instituteinfo
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
                    myCommand.Parameters.AddWithValue("@EmployeeId", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }


        public async Task<JsonResult> savepiccover([FromForm] Instituteinfo inst)
        {
            string Email = inst.email;
            string message = "Start";
            /*var files = inst.files;

            inst.files = null;
            if (Email != "" && Email != null && files != null && files.Length > 0)
            {
                path = _WebHostEnviroment.WebRootPath + "\\Institutecoverandlogopic\\";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                fileName = "Institutecoverpic" + Email +".png";
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path + fileName);
                }
                using (FileStream filestream = System.IO.File.Create(path + fileName))
                {
                    files.CopyTo(filestream);
                    filestream.Flush();
                    message = "Coverpicurl Upload Successfully";
                }
            }
            if (files == null || files.Length == 0)
            {
                message = "Error Uploading File" +
                    "No file found!! ";
            }
            inst.ImageByte = System.IO.File.ReadAllBytes(path + fileName);
            message = Convert.ToBase64String(inst.ImageByte);*/
            string query2 = @"
                            Update dbo.Instituteinfo
                            set Coverpicurl=@Coverpicurl,
                            Coverpicurlbase64=@Coverpicurlbase64
                            where Email=@Email 
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
                    myCommand.Parameters.AddWithValue("@Coverpicurl", "none");
                    myCommand.Parameters.AddWithValue("@Coverpicurlbase64", inst.Coverpicurlbase64);
                    myReader2 = myCommand.ExecuteReader();
                    table2.Load(myReader2);
                    myReader2.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(message);
        }



        public async Task<JsonResult> savepicmain([FromForm] Instituteinfo inst)
        {
            string Email = inst.email;
            string message = "Start";
            /*
            var files = inst.files;
            
            inst.files = null;
            if (Email != ""  && Email != null && files != null && files.Length > 0)
            {
                path = _WebHostEnviroment.WebRootPath + "\\Institutecoverandlogopic\\";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                fileName = "Institutelogopic" + Email + ".png";
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path + fileName);
                }
                using (FileStream filestream = System.IO.File.Create(path + fileName))
                {
                    files.CopyTo(filestream);
                    filestream.Flush();
                    message = "mainpicurl Upload Successfully";
                }
            }
            if (files == null || files.Length == 0)
            {
                message = "Error Uploading File" +
                    "No file found!! ";
            }
            inst.ImageByte = System.IO.File.ReadAllBytes(path + fileName);
            message = Convert.ToBase64String(inst.ImageByte);*/
            string query2 = @"
                            Update dbo.Instituteinfo
                            set mainpicurl=@mainpicurl,
                            mainpicurlbase64=@mainpicurlbase64
                            where Email=@Email 
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
                    myCommand.Parameters.AddWithValue("@mainpicurl", "none");
                    myCommand.Parameters.AddWithValue("@mainpicurlbase64", inst.mainpicurlbase64);
                    myReader2 = myCommand.ExecuteReader();
                    table2.Load(myReader2);
                    myReader2.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(message);
        }



        public async Task<JsonResult> pickpiclogo(Instituteinfo inst)
        {
            inst.ImageByte = System.IO.File.ReadAllBytes(inst.mainpicurl);
            return new JsonResult(inst.ImageByte);
        }

        public async Task<JsonResult> pickpiccover(Instituteinfo inst)
        {
            inst.ImageByte = System.IO.File.ReadAllBytes(inst.Coverpicurl);
            return new JsonResult(inst.ImageByte);
        }

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
                            dbo.Instituteinfo
                            where country like @countries and
                            statuscheck!='pending'
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



        public async Task<JsonResult> Putreviewbyid(Instituteinfo inst)
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
                            select totalreviewscount,totalusercount,averagecount from dbo.Instituteinfo
                             where email=@email  ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@email", inst.email);
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
            floattotalreviewscount += float.Parse(inst.rate);

            floattotalusercount = float.Parse(totalusercount);
            floattotalusercount += 1;
            if (floattotalreviewscount == 0 || floattotalusercount == 0)
            {
                floattotalreviewscount = float.Parse(inst.rate);
                floattotalusercount = 1;
            }

            float average = floattotalreviewscount / floattotalusercount;
            floataveragecount = average;

            string query1 = @"
                            
                            Update dbo.Instituteinfo
                            set totalreviewscount=@totalreviewscount,
                            totalusercount=@totalusercount,
                            averagecount=@averagecount
                            where email=@email 
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
                    myCommand.Parameters.AddWithValue("@email", inst.email);
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
