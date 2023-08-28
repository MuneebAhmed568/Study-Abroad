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
    public class StudentinfoRepository : IStudentinfoRepository
    {
        private readonly IConfiguration _configuration;

        string check = "";
        string path = "";
        string fileName = "";

        public StudentinfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public async Task<JsonResult> Getall()
        {
            string query = @"
                            select *
                            from
                            dbo.Studentinfo
                            where statuscheck!='pending'
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
                            select *
                            from
                            dbo.Studentinfo where Email=@Email
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
                            dbo.Studentinfo
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



        public async Task<JsonResult> Putbyemail(Studentinfo stu)
        {
            string query = @"
                            update dbo.Studentinfo
                            set Fullname=@Fullname,
                            Phoneno=@Phoneno,
                            Location=@Location                          
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
                    myCommand.Parameters.AddWithValue("@Fullname", stu.Fullname);
                    myCommand.Parameters.AddWithValue("@Phoneno", stu.Phoneno);
                    myCommand.Parameters.AddWithValue("@Location", stu.Location);

                    myCommand.Parameters.AddWithValue("@Email", stu.Email);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Reocrd updated !");
        }

        public async Task<JsonResult> Putbyupdemails(Studentinfo stu)
        {
            string query = @"
                            update dbo.Studentinfo
                            set Qualification=@Qualification,
                            Interestedcountry=@Interestedcountry,
                            course=@course,   
                            scores=@scores,  
                            wanttostudy=@wanttostudy  
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
                    myCommand.Parameters.AddWithValue("@Qualification", stu.Qualification);
                    myCommand.Parameters.AddWithValue("@Interestedcountry", stu.Interestedcountry);
                    myCommand.Parameters.AddWithValue("@course", stu.course);
                    myCommand.Parameters.AddWithValue("@scores", stu.scores);
                    myCommand.Parameters.AddWithValue("@wanttostudy", stu.wanttostudy);
                    myCommand.Parameters.AddWithValue("@Email", stu.Email);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Reocrd updated !");
        }

        public async Task<JsonResult> savepic([FromForm] Studentinfo stu)
        {
            string message = "Start";
            string Email = stu.Email;
            /*var files = stu.files;
            
            stu.files = null;
            if (Email != "" && Email != null && files != null && files.Length > 0)
            {
                path = _WebHostEnviroment.WebRootPath + "\\Studentpics\\";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                fileName = "StudentPic" + Email + ".png";
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path + fileName);
                }
                using (FileStream filestream = System.IO.File.Create(path + fileName))
                {
                    files.CopyTo(filestream);
                    filestream.Flush();
                    message = "Image Upload Successfully";
                }
            }
            if (files == null || files.Length == 0)
            {
                message = "Error Uploading File" +
                    "No file found!! ";
            }
            stu.ImageByte = System.IO.File.ReadAllBytes(path + fileName);
            message = Convert.ToBase64String(stu.ImageByte);*/
            string query2 = @"
                            Update dbo.Studentinfo
                            set  imageurl=@imageurl,
                            imageurlbase64=@imageurlbase64
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
                    myCommand.Parameters.AddWithValue("@imageurl", "none");
                    myCommand.Parameters.AddWithValue("@imageurlbase64", stu.imageurlbase64);
                    message = "Updated Image Record";
                    myReader2 = myCommand.ExecuteReader();
                    table2.Load(myReader2);
                    myReader2.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(message);
        }

        public async Task<JsonResult> Putupdatestatus(Studentinfo stu)
        {
            string query = @"
                            update dbo.Studentinfo
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

                    myCommand.Parameters.AddWithValue("@Email", stu.Email);
                    myCommand.Parameters.AddWithValue("@statuscheck", "approve");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Status Approved Successfully");
        }


        public async Task<JsonResult> Post(Studentinfo stu)
        {

            string query = @"
                           insert into dbo.Studentinfo
                           (Fullname, Email,Phoneno,Password,statuscheck,imageurlbase64)
                    values (@Fullname,@Email,@Phoneno,@Password,@statuscheck,@imageurlbase64)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Fullname", stu.Fullname);
                    myCommand.Parameters.AddWithValue("@Phoneno", stu.Phoneno);
                    myCommand.Parameters.AddWithValue("@Email", stu.Email);
                    myCommand.Parameters.AddWithValue("@Password", stu.Password);
                    myCommand.Parameters.AddWithValue("@statuscheck", "pending");
                    myCommand.Parameters.AddWithValue("@imageurlbase64", "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY");
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Account Created Successfully. Please Login !");
        }



        public async Task<JsonResult> PutbyPassword(Studentinfo stu)
        {
            string statucheck = "";

            string query = @"
                            select Email from dbo.Studentinfo
                            where Email=@Email and Password=@password
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@Email", stu.Email);
                    myCommand.Parameters.AddWithValue("@Password", stu.Password);
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

            if (check == stu.Email)
            {

                string query1 = @"
                            Update dbo.Studentinfo
                            set Password=@newpassword
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

                        myCommand.Parameters.AddWithValue("@Email", stu.Email);
                        myCommand.Parameters.AddWithValue("@newpassword", stu.newpassword);
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
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource2))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Email", stu.Email);
                        myCommand.Parameters.AddWithValue("@newpassword", stu.newpassword);
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
    }
}
