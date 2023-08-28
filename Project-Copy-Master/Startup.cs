using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Project_Copy_Master.Models;
using Project_Copy_Master.Repository;
using Project_Copy_Master.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Copy_Master
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        [Authorize]
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddControllers();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.UTF8.GetBytes(appSettings.Key);

            services.AddAuthentication(au =>
            {

                au.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                au.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwt =>
            {
                jwt.RequireHttpsMetadata = false;
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false

                };
            });
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<IconsultantinfoRepository, consultantinfoRepository>();
            services.AddScoped<IaddsinfoRepository, addsinfoRepository>();
            services.AddScoped<ICommentsinfoRepository, CommentsinfoRepository>();
            services.AddScoped<IcountryinfoRepository, countryinfoRepository>();
            services.AddScoped<IembassyinfoRepository, embassyinfoRepository>();
            services.AddScoped<Ieventsinforepository, eventsinforepository>();
            services.AddScoped<IInstituteinfoRepository, InstituteinfoRepository>();
            services.AddScoped<IFormdataRepository, FormdataRepository>();
            services.AddScoped<IscholarshipinfoRepository, scholarshipinfoRepository>();
            services.AddScoped<IStudentinfoRepository, StudentinfoRepository>();
            services.AddScoped<IVerify_loginRepository, Verify_loginRepository>();
            services.AddScoped<IViewsCounterRepository, ViewsCounterRepository>();
            services.AddScoped<ITestsinfoRepository, TestsinfoRepository>();
            services.AddScoped<ICoursesinfoRepository, CoursesinfoRepository>();
            services.AddScoped<IBlogsRepository, BlogsRepository>();
            services.AddScoped<ICities_infoRepository, Cities_infoRepository>(); //District_infoRepository
            services.AddScoped<IDistrict_infoRepository, District_infoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
