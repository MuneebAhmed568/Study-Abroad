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
    public class ViewsCounterRepository : IViewsCounterRepository
    {
        private int id = 0;

        private int currentviews = 0;
        private int previousviews = 0;
        public string refreshdatadate = "30";

        private readonly IConfiguration _configuration;
        public ViewsCounterRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public async Task<JsonResult> Mainpageviewsupdate()
        {
            string query = @"
                            select Id,Viewscurrentmonth,Viewspreviousmonth,refreshdatadate from dbo.MainViewsCounter
                            where Pagetype='Main' and Email='default'   
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

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["Viewscurrentmonth"].ToString());
                    previousviews = int.Parse(row1["Viewspreviousmonth"].ToString());
                    refreshdatadate = row1["refreshdatadate"].ToString();
                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.MainViewsCounter
                            set Viewscurrentmonth=@Viewscurrentmonth,
                            Viewspreviousmonth=@Viewspreviousmonth,
                            refreshdatadate=@refreshdatadate
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Viewscurrentmonth", currentviews);
                        myCommand.Parameters.AddWithValue("@Viewspreviousmonth", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult(" Vue updated ");
        }
        public async Task<JsonResult> MainNewspageviewsupdate()
        {
            string query = @"
                            select Id,Viewscurrentmonth,Viewspreviousmonth,refreshdatadate from dbo.MainViewsCounter
                            where Pagetype='News' and Email='default'   
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

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["Viewscurrentmonth"].ToString());
                    previousviews = int.Parse(row1["Viewspreviousmonth"].ToString());
                    refreshdatadate = row1["refreshdatadate"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.MainViewsCounter
                            set Viewscurrentmonth=@Viewscurrentmonth,
                            Viewspreviousmonth=@Viewspreviousmonth,
                            refreshdatadate=@refreshdatadate
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Viewscurrentmonth", currentviews);
                        myCommand.Parameters.AddWithValue("@Viewspreviousmonth", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult(" ");
        }


        public async Task<JsonResult> MainAddspageviewsupdate()
        {
            string query = @"
                            select Id,Viewscurrentmonth,Viewspreviousmonth,refreshdatadate from dbo.MainViewsCounter
                            where Pagetype='Adds' and Email='default'   
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

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["Viewscurrentmonth"].ToString());
                    previousviews = int.Parse(row1["Viewspreviousmonth"].ToString());
                    refreshdatadate = row1["refreshdatadate"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.MainViewsCounter
                            set Viewscurrentmonth=@Viewscurrentmonth,
                            Viewspreviousmonth=@Viewspreviousmonth,
                            refreshdatadate=@refreshdatadate
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Viewscurrentmonth", currentviews);
                        myCommand.Parameters.AddWithValue("@Viewspreviousmonth", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult(" ");
        }


        public async Task<JsonResult> MainScholarshippageviewsupdate()
        {
            string query = @"
                            select Id,Viewscurrentmonth,Viewspreviousmonth,refreshdatadate from dbo.MainViewsCounter
                            where Pagetype='Scholarship' and Email='default'   
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

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["Viewscurrentmonth"].ToString());
                    previousviews = int.Parse(row1["Viewspreviousmonth"].ToString());
                    refreshdatadate = row1["refreshdatadate"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.MainViewsCounter
                            set Viewscurrentmonth=@Viewscurrentmonth,
                            Viewspreviousmonth=@Viewspreviousmonth,
                            refreshdatadate=@refreshdatadate
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Viewscurrentmonth", currentviews);
                        myCommand.Parameters.AddWithValue("@Viewspreviousmonth", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult(" ");
        }

        public async Task<JsonResult> MainUniversitypageviewsupdate()
        {
            string query = @"
                            select Id,Viewscurrentmonth,Viewspreviousmonth,refreshdatadate from dbo.MainViewsCounter
                            where Pagetype='University' and Email='default'   
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

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["Viewscurrentmonth"].ToString());
                    previousviews = int.Parse(row1["Viewspreviousmonth"].ToString());
                    refreshdatadate = row1["refreshdatadate"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.MainViewsCounter
                            set Viewscurrentmonth=@Viewscurrentmonth,
                            Viewspreviousmonth=@Viewspreviousmonth,
                            refreshdatadate=@refreshdatadate
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Viewscurrentmonth", currentviews);
                        myCommand.Parameters.AddWithValue("@Viewspreviousmonth", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult(" ");
        }
        //Consultant


        public async Task<JsonResult> MainConsultantpageviewsupdate()
        {
            string query = @"
                            select Id,Viewscurrentmonth,Viewspreviousmonth,refreshdatadate from dbo.MainViewsCounter
                            where Pagetype='Consultant' and Email='default'   
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

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["Viewscurrentmonth"].ToString());
                    previousviews = int.Parse(row1["Viewspreviousmonth"].ToString());
                    refreshdatadate = row1["refreshdatadate"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.MainViewsCounter
                            set Viewscurrentmonth=@Viewscurrentmonth,
                            Viewspreviousmonth=@Viewspreviousmonth,
                            refreshdatadate=@refreshdatadate
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@Viewscurrentmonth", currentviews);
                        myCommand.Parameters.AddWithValue("@Viewspreviousmonth", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult(" ");
        }







        public async Task<JsonResult> ConsultantSinglepageviewsupdate(ViewsCounter views)
        {
            string query = @"
                            select * from dbo.ViewsCounter
                            where Pagetype1='Consultant' and Email=@Email   
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", views.Email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["ViewcurrentmonthPagetype1"].ToString());
                    previousviews = int.Parse(row1["ViewpreviousmonthPagetype1"].ToString());
                    refreshdatadate = row1["refreshdatadate1"].ToString();
                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.ViewsCounter
                            set ViewcurrentmonthPagetype1=@ViewcurrentmonthPagetype1,
                            ViewpreviousmonthPagetype1=@ViewpreviousmonthPagetype1,
                            refreshdatadate1=@refreshdatadate1
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype1", currentviews);
                        myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype1", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate1", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult("  of Single Page");
        }
        public async Task<JsonResult> NewsSinglepageviewsupdate(ViewsCounter views)
        {
            string query = @"
                            select * from dbo.ViewsCounter
                            where Pagetype3='News' and Email=@Email   
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", views.Email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["ViewcurrentmonthPagetype3"].ToString());
                    previousviews = int.Parse(row1["ViewpreviousmonthPagetype3"].ToString());
                    refreshdatadate = row1["refreshdatadate3"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.ViewsCounter
                            set ViewcurrentmonthPagetype3=@ViewcurrentmonthPagetype3,
                            ViewpreviousmonthPagetype3=@ViewpreviousmonthPagetype3,
                            refreshdatadate3=@refreshdatadate3
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype3", currentviews);
                        myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype3", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate3", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult("  of Single Page");
        }



        public async Task<JsonResult> AddsSinglepageviewsupdate(ViewsCounter views)
        {
            string query = @"
                            select * from dbo.ViewsCounter
                            where Pagetype2='Adds' and Email=@Email   
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", views.Email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["ViewcurrentmonthPagetype2"].ToString());
                    previousviews = int.Parse(row1["ViewpreviousmonthPagetype2"].ToString());
                    refreshdatadate = row1["refreshdatadate2"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.ViewsCounter
                            set ViewcurrentmonthPagetype2=@ViewcurrentmonthPagetype2,
                            ViewpreviousmonthPagetype2=@ViewpreviousmonthPagetype2,
                            refreshdatadate2=@refreshdatadate2
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype2", currentviews);
                        myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype2", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate2", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult("  of Single Page");
        }


        public async Task<JsonResult> UniversitySinglepageviewsupdate(ViewsCounter views)
        {
            string query = @"
                            select * from dbo.ViewsCounter
                            where Pagetype1='University' and Email=@Email   
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", views.Email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["ViewcurrentmonthPagetype1"].ToString());
                    previousviews = int.Parse(row1["ViewpreviousmonthPagetype1"].ToString());
                    refreshdatadate = row1["refreshdatadate5"].ToString();

                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.ViewsCounter
                            set ViewcurrentmonthPagetype1=@ViewcurrentmonthPagetype1,
                            ViewpreviousmonthPagetype1=@ViewpreviousmonthPagetype1,
                            refreshdatadate5=@refreshdatadate5
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype1", currentviews);
                        myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype1", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate5", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult("  of Single Page");
        }



        public async Task<JsonResult> ScholarshipSinglepageviewsupdate(ViewsCounter views)
        {
            string query = @"
                            select * from dbo.ViewsCounter
                            where Pagetype4='Scholarship' and Email=@Email   
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            await using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", views.Email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }

                foreach (DataRow row1 in table.Rows)
                {
                    id = int.Parse(row1["Id"].ToString());
                    currentviews = int.Parse(row1["ViewcurrentmonthPagetype4"].ToString());
                    previousviews = int.Parse(row1["ViewpreviousmonthPagetype4"].ToString());
                    refreshdatadate = row1["refreshdatadate4"].ToString();
                }
            }
            string currentdate = DateTime.Now.ToString("dd");
            if (currentdate == refreshdatadate)
            {
                previousviews = currentviews;
                currentviews = 0;
                refreshdatadate = "29";
            }
            if (currentdate == "1")
            {
                refreshdatadate = "30";
            }
            currentviews = currentviews + 1;
            if (id != 0)
            {

                string query1 = @"
                            Update dbo.ViewsCounter
                            set ViewcurrentmonthPagetype4=@ViewcurrentmonthPagetype4,
                            ViewpreviousmonthPagetype4=@ViewpreviousmonthPagetype4,
                            refreshdatadate4=@refreshdatadate4
                            where Id=@Id 
                            ";

                DataTable table1 = new DataTable();
                string sqlDataSource1 = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader1;
                await using (SqlConnection myCon = new SqlConnection(sqlDataSource1))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                    {

                        myCommand.Parameters.AddWithValue("@ViewcurrentmonthPagetype4", currentviews);
                        myCommand.Parameters.AddWithValue("@ViewpreviousmonthPagetype4", previousviews);
                        myCommand.Parameters.AddWithValue("@refreshdatadate4", refreshdatadate);
                        myCommand.Parameters.AddWithValue("@Id", id);
                        myReader1 = myCommand.ExecuteReader();
                        table1.Load(myReader1);
                        myReader1.Close();
                        myCon.Close();
                    }

                }
            }
            return new JsonResult("  of Single Page");
        }



        public async Task<JsonResult> Getuniversitybyemail(string email)
        {
            string query = @"
                            select 
                             Id,Email,ViewcurrentmonthPagetype1,ViewcurrentmonthPagetype2,ViewcurrentmonthPagetype3,ViewcurrentmonthPagetype4
                            from
                            dbo.ViewsCounter
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
                    myCommand.Parameters.AddWithValue("@Email", email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }


        public async Task<JsonResult> Getconsultantbyemail(string email)
        {
            string query = @"
                            select 
                            Id,Email,ViewcurrentmonthPagetype1,ViewcurrentmonthPagetype2,ViewcurrentmonthPagetype3
                            from
                            dbo.ViewsCounter
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
                    myCommand.Parameters.AddWithValue("@Email", email);
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
