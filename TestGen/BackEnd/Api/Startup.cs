using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Api.Mappings;
using AutoMapper;
using Core.Managers;
using Core.Models;
using Core.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Persistence;
using Persistence.Repository;
using UserStore = Core.Managers.UserStore;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("OzunaConnection");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //DB CONTEXT DEPENDENCY
            services.AddDbContext<GeneratorDbContext>(options =>
                options.UseMySql(connectionString, builder => builder.MigrationsAssembly("Api")));
            
            //REPOSITORY DEPENDENCIES
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionTypeRepository, QuestionTypeRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            //MANAGERS DEPENDENCIES
            services.AddScoped<ExamManager, ExamManager>();
            services.AddScoped<QuestionTypeManager, QuestionTypeManager>();
            services.AddScoped<QuestionManager, QuestionManager>();
            services.AddScoped<SectionManager, SectionManager>();
            
            //IDENTITY
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            });
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddDefaultTokenProviders();

            //IDENTITY SERVICES
            services.AddTransient<IUserStore<ApplicationUser>, UserStore>();
            services.AddTransient<IUserEmailStore<ApplicationUser>, UserStore>();
            services.AddTransient<IUserPasswordStore<ApplicationUser>, UserStore>();
            services.AddTransient<IRoleStore<IdentityRole>, MockRoleStore>();

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); // => remove default claims
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    
                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = Configuration["JwtIssuer"],
                        ValidAudience = Configuration["JwtIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtKey"])),
                        ClockSkew = TimeSpan.Zero // remove delay of token when expire
                    };
                });

            
            //MAPPER INITIALIZATION
            Mapper.Initialize(cfg => cfg.AddProfile<MappingProfile>());
            services.AddAutoMapper();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            var userResult = userManager.FindByEmailAsync("admin@admin.com");
            var user = userResult.Result;

            if (user == null)
            {
                var newuser = new ApplicationUser
                {
                    UserName = "admin@admin.com",
                    NormalizedUserName = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com",
                    Email = "admin@admin.com"
                };

                userManager.CreateAsync(newuser, "admin");
            }
            
            
            app.UseHttpsRedirection();

            app.UseAuthentication();
            
            app.UseMvc();
        }
    }
}