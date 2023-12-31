﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Copy_Master;

namespace Project_Copy_Master.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230828054853_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project_Copy_Master.Models.Blogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imageipfs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_7")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Commentsinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Messagess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subjects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dates")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("commentsinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Coursesinfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Course_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para_3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coursesinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Formdata", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BudgetRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contactnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currentedulevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fieldofstudy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institute_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Score")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<string>("countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dates")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("formdata");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Instituteinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contactno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coverpicurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coverpicurlbase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Forbestranking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fulladdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locationcity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locationcountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locationtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qsworldranking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timeshighereducationranking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("averagecount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("institutename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainpicurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainpicurlbase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statuscheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalreviewscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalusercount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("websitelink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Instituteinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.MainViewsCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagetype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Viewscurrentmonth")
                        .HasColumnType("int");

                    b.Property<int>("Viewspreviousmonth")
                        .HasColumnType("int");

                    b.Property<int>("refreshdatadate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MainViewsCounter");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Studentinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interestedcountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phoneno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurlbase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statuscheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wanttostudy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Studentinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Testsinfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Centers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imageipfs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Test_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestandPreparation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypesofTest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Testsinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.Verify_login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identifier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Verify_login");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.ViewsCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagetype1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagetype2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagetype3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagetype4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewcurrentmonthPagetype1")
                        .HasColumnType("int");

                    b.Property<int>("ViewcurrentmonthPagetype2")
                        .HasColumnType("int");

                    b.Property<int>("ViewcurrentmonthPagetype3")
                        .HasColumnType("int");

                    b.Property<int>("ViewcurrentmonthPagetype4")
                        .HasColumnType("int");

                    b.Property<int>("ViewpreviousmonthPagetype1")
                        .HasColumnType("int");

                    b.Property<int>("ViewpreviousmonthPagetype2")
                        .HasColumnType("int");

                    b.Property<int>("ViewpreviousmonthPagetype3")
                        .HasColumnType("int");

                    b.Property<int>("ViewpreviousmonthPagetype4")
                        .HasColumnType("int");

                    b.Property<string>("refreshdatadate1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("refreshdatadate2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("refreshdatadate3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("refreshdatadate4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("refreshdatadate5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ViewsCounter");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.addsinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Educationlevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activatedate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activatetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiredates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiretime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurlbase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statuscheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("addsinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.consultantinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conatctno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heads_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phoneno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("averagecount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companylogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companylogobase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consultancyservices")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mapaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("service")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statuscheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalreviewscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalusercount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("websitelink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Consultantinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.countryinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Climate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryLogo_Ipfs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Economy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationIn_Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education_System")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Five_Points")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Government")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History_Population")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Immigration_Visa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImpGovernment_Agencies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoSpecific_Student")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Living_Cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local_Control")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location_Geo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInfo_Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Society_Culture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Structure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("countryinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.embassyinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("embassylogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("embassylogobase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("embassyname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("embassyinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.eventsinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activatedate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activatetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("averagecount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiredates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiretime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurlbase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDiscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statuscheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalreviewscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalusercount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("newsandeventinfo");
                });

            modelBuilder.Entity("Project_Copy_Master.Models.scholarshipinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activatedate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activatetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("averagecount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiredates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiretime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurlbase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDiscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statuscheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalreviewscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalusercount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("scholarshipinfo");
                });
#pragma warning restore 612, 618
        }
    }
}
