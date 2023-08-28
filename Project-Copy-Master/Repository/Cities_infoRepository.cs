using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Project_Copy_Master.Repository
{
    public class Cities_infoRepository : ICities_infoRepository
    {
        private readonly IConfiguration _configuration;
        public Cities_infoRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public async Task<JsonResult> Getall()
        {
            string query = @"
                            select *
                            from
                            Cities_info order by City_Name asc                
                            "
            ;

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
