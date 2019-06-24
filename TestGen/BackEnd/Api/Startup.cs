using Core.Managers;
using Core.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Persistence.Repository;

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
                options.UseMySQL(connectionString, builder => builder.MigrationsAssembly("Api")));

            //REPOSITORY DEPENDENCIES
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionTypeRepository, QuestionTypeRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            
            //MANAGERS DEPENDENCIES
            services.AddScoped<ExamManager, ExamManager>();
            services.AddScoped<QuestionTypeManager, QuestionTypeManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}