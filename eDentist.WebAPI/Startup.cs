using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using eDentist.WebAPI.Filters;
using eDentist.WebAPI.Interface;
using eDentist.WebAPI.Security;
using eDentist.WebAPI.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace eDentist.WebAPI
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
            services.AddScoped<IBaseService<MRoles, object>, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICRUDService<MAppointments, AppointmentsSearchRequest, AppointmentsUpsertRequest, AppointmentsUpsertRequest>, AppointmentsService>();
            services.AddScoped<ICRUDService<MCountries, CountriesSearchRequest, CountriesUpsertRequest, CountriesUpsertRequest>, CountriesService>();
            services.AddScoped<ICRUDService<MCities, CitiesSearchRequest, CitiesUpsertRequest, CitiesUpsertRequest>, CitiesService>();
            services.AddScoped<ICRUDService<MMaterials, MaterialsSearchRequest, MaterialsUpsertRequest, MaterialsUpsertRequest>, MaterialsService>();
            services.AddScoped<ICRUDService<MManufacturers, ManufacturersSearchRequest, ManufacturersUpsertRequest, ManufacturersUpsertRequest>, ManufacturersService>();
            services.AddScoped<ICRUDService<MTreatments, TreatmentSearchRequest, TreatmentsUpsertRequest, TreatmentsUpsertRequest>, TreatmentsService>();
            services.AddScoped<ICRUDService<MTreatmentsMaterials, TreatmentsMaterialsSearchRequest, TreatmentsMaterialsUpsertRequest, TreatmentsMaterialsUpsertRequest>, TreatmentsMaterialsService>();
            services.AddScoped<ICRUDService<MExaminations, ExaminationsSearchRequest, ExaminationUpsertRequest, ExaminationUpsertRequest>, ExaminationsService>();







            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddControllers((x => x.Filters.Add<ErrorFilter>()));
            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<eDentistContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("eDentist")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eDentist API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "basic"
                              }
                          },
                          new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
              .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();

            app.UseAuthentication();


            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eDentist API");
            });
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
