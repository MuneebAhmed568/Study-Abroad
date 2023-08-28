using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Copy_Master.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addsinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    dates = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Educationlevel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    statuscheck = table.Column<string>(nullable: true),
                    imageurl = table.Column<string>(nullable: true),
                    imageurlbase64 = table.Column<string>(nullable: true),
                    activatedate = table.Column<string>(nullable: true),
                    activatetime = table.Column<string>(nullable: true),
                    expiredates = table.Column<string>(nullable: true),
                    expiretime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addsinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    Heading_1 = table.Column<string>(nullable: true),
                    Para_1 = table.Column<string>(nullable: true),
                    Heading_2 = table.Column<string>(nullable: true),
                    Para_2 = table.Column<string>(nullable: true),
                    Heading_3 = table.Column<string>(nullable: true),
                    Para_3 = table.Column<string>(nullable: true),
                    Heading_4 = table.Column<string>(nullable: true),
                    Para_4 = table.Column<string>(nullable: true),
                    Heading_5 = table.Column<string>(nullable: true),
                    Para_5 = table.Column<string>(nullable: true),
                    Heading_6 = table.Column<string>(nullable: true),
                    Para_6 = table.Column<string>(nullable: true),
                    Heading_7 = table.Column<string>(nullable: true),
                    Para_7 = table.Column<string>(nullable: true),
                    Imageipfs = table.Column<string>(nullable: true),
                    Dates = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "commentsinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Subjects = table.Column<string>(nullable: true),
                    Messagess = table.Column<string>(nullable: true),
                    Pagename = table.Column<string>(nullable: true),
                    dates = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commentsinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Consultantinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personname = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Conatctno = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    websitelink = table.Column<string>(nullable: true),
                    companylogo = table.Column<string>(nullable: true),
                    companylogobase64 = table.Column<string>(nullable: true),
                    consultancyservices = table.Column<string>(nullable: true),
                    service = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    statuscheck = table.Column<string>(nullable: true),
                    Phoneno = table.Column<string>(nullable: true),
                    mapaddress = table.Column<string>(nullable: true),
                    totalreviewscount = table.Column<string>(nullable: true),
                    totalusercount = table.Column<string>(nullable: true),
                    averagecount = table.Column<string>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    Heads_email = table.Column<string>(nullable: true),
                    District_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultantinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countryinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_Name = table.Column<string>(nullable: true),
                    CountryLogo_Ipfs = table.Column<string>(nullable: true),
                    Five_Points = table.Column<string>(nullable: true),
                    Location_Geo = table.Column<string>(nullable: true),
                    Climate = table.Column<string>(nullable: true),
                    History_Population = table.Column<string>(nullable: true),
                    Society_Culture = table.Column<string>(nullable: true),
                    Economy = table.Column<string>(nullable: true),
                    Government = table.Column<string>(nullable: true),
                    Living_Cost = table.Column<string>(nullable: true),
                    Education_System = table.Column<string>(nullable: true),
                    InfoSpecific_Student = table.Column<string>(nullable: true),
                    Immigration_Visa = table.Column<string>(nullable: true),
                    EducationIn_Country = table.Column<string>(nullable: true),
                    MoreInfo_Specialization = table.Column<string>(nullable: true),
                    ImpGovernment_Agencies = table.Column<string>(nullable: true),
                    Local_Control = table.Column<string>(nullable: true),
                    Structure = table.Column<string>(nullable: true),
                    College = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countryinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Coursesinfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_Name = table.Column<string>(nullable: true),
                    Para_1 = table.Column<string>(nullable: true),
                    Para_2 = table.Column<string>(nullable: true),
                    Para_3 = table.Column<string>(nullable: true),
                    Para_14 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coursesinfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "embassyinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    embassyname = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    dates = table.Column<string>(nullable: true),
                    embassylogo = table.Column<string>(nullable: true),
                    embassylogobase64 = table.Column<string>(nullable: true),
                    countries = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_embassyinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formdata",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    countries = table.Column<string>(nullable: true),
                    Fieldofstudy = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contactnumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Score = table.Column<string>(nullable: true),
                    BudgetRange = table.Column<string>(nullable: true),
                    Currentedulevel = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Institute_Name = table.Column<string>(nullable: true),
                    dates = table.Column<string>(nullable: true),
                    District_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formdata", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Instituteinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    institutename = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    websitelink = table.Column<string>(nullable: true),
                    Contactno = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    statuscheck = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Qsworldranking = table.Column<string>(nullable: true),
                    Coverpicurlbase64 = table.Column<string>(nullable: true),
                    mainpicurlbase64 = table.Column<string>(nullable: true),
                    mainpicurl = table.Column<string>(nullable: true),
                    Coverpicurl = table.Column<string>(nullable: true),
                    Forbestranking = table.Column<string>(nullable: true),
                    Timeshighereducationranking = table.Column<string>(nullable: true),
                    Locationtitle = table.Column<string>(nullable: true),
                    Locationcountry = table.Column<string>(nullable: true),
                    Locationcity = table.Column<string>(nullable: true),
                    Fulladdress = table.Column<string>(nullable: true),
                    totalreviewscount = table.Column<string>(nullable: true),
                    totalusercount = table.Column<string>(nullable: true),
                    averagecount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituteinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MainViewsCounter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Pagetype = table.Column<string>(nullable: true),
                    Viewscurrentmonth = table.Column<int>(nullable: false),
                    Viewspreviousmonth = table.Column<int>(nullable: false),
                    refreshdatadate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainViewsCounter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "newsandeventinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    shortDiscription = table.Column<string>(nullable: true),
                    Countries = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    dates = table.Column<string>(nullable: true),
                    imageurl = table.Column<string>(nullable: true),
                    activatedate = table.Column<string>(nullable: true),
                    activatetime = table.Column<string>(nullable: true),
                    expiredates = table.Column<string>(nullable: true),
                    expiretime = table.Column<string>(nullable: true),
                    imageurlbase64 = table.Column<string>(nullable: true),
                    statuscheck = table.Column<string>(nullable: true),
                    totalreviewscount = table.Column<string>(nullable: true),
                    totalusercount = table.Column<string>(nullable: true),
                    averagecount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsandeventinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scholarshipinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    shortDiscription = table.Column<string>(nullable: true),
                    Countries = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    dates = table.Column<string>(nullable: true),
                    imageurl = table.Column<string>(nullable: true),
                    totalreviewscount = table.Column<string>(nullable: true),
                    totalusercount = table.Column<string>(nullable: true),
                    averagecount = table.Column<string>(nullable: true),
                    imageurlbase64 = table.Column<string>(nullable: true),
                    statuscheck = table.Column<string>(nullable: true),
                    activatedate = table.Column<string>(nullable: true),
                    activatetime = table.Column<string>(nullable: true),
                    expiredates = table.Column<string>(nullable: true),
                    expiretime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scholarshipinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Studentinfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(nullable: true),
                    Phoneno = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(nullable: true),
                    wanttostudy = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Interestedcountry = table.Column<string>(nullable: true),
                    imageurl = table.Column<string>(nullable: true),
                    imageurlbase64 = table.Column<string>(nullable: true),
                    statuscheck = table.Column<string>(nullable: true),
                    scores = table.Column<string>(nullable: true),
                    course = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Testsinfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About = table.Column<string>(nullable: true),
                    Fees = table.Column<string>(nullable: true),
                    TestandPreparation = table.Column<string>(nullable: true),
                    Centers = table.Column<string>(nullable: true),
                    Registration = table.Column<string>(nullable: true),
                    TypesofTest = table.Column<string>(nullable: true),
                    Test_name = table.Column<string>(nullable: true),
                    Imageipfs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testsinfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verify_login",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    identifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verify_login", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ViewsCounter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Pagetype1 = table.Column<string>(nullable: true),
                    ViewcurrentmonthPagetype1 = table.Column<int>(nullable: false),
                    ViewpreviousmonthPagetype1 = table.Column<int>(nullable: false),
                    Pagetype2 = table.Column<string>(nullable: true),
                    ViewcurrentmonthPagetype2 = table.Column<int>(nullable: false),
                    ViewpreviousmonthPagetype2 = table.Column<int>(nullable: false),
                    Pagetype3 = table.Column<string>(nullable: true),
                    ViewcurrentmonthPagetype3 = table.Column<int>(nullable: false),
                    ViewpreviousmonthPagetype3 = table.Column<int>(nullable: false),
                    Pagetype4 = table.Column<string>(nullable: true),
                    ViewcurrentmonthPagetype4 = table.Column<int>(nullable: false),
                    ViewpreviousmonthPagetype4 = table.Column<int>(nullable: false),
                    refreshdatadate1 = table.Column<string>(nullable: true),
                    refreshdatadate2 = table.Column<string>(nullable: true),
                    refreshdatadate3 = table.Column<string>(nullable: true),
                    refreshdatadate4 = table.Column<string>(nullable: true),
                    refreshdatadate5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewsCounter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addsinfo");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "commentsinfo");

            migrationBuilder.DropTable(
                name: "Consultantinfo");

            migrationBuilder.DropTable(
                name: "countryinfo");

            migrationBuilder.DropTable(
                name: "Coursesinfo");

            migrationBuilder.DropTable(
                name: "embassyinfo");

            migrationBuilder.DropTable(
                name: "formdata");

            migrationBuilder.DropTable(
                name: "Instituteinfo");

            migrationBuilder.DropTable(
                name: "MainViewsCounter");

            migrationBuilder.DropTable(
                name: "newsandeventinfo");

            migrationBuilder.DropTable(
                name: "scholarshipinfo");

            migrationBuilder.DropTable(
                name: "Studentinfo");

            migrationBuilder.DropTable(
                name: "Testsinfo");

            migrationBuilder.DropTable(
                name: "Verify_login");

            migrationBuilder.DropTable(
                name: "ViewsCounter");
        }
    }
}
