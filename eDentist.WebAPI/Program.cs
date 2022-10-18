using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using eDentist.WebAPI.Interface;
using eDentist.WebAPI.Security;
using eDentist.WebAPI.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add builder.Services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});



builder.Services.AddScoped<IBaseService<MRoles, object>, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICRUDService<MAppointments, AppointmentsSearchRequest, AppointmentsUpsertRequest, AppointmentsUpsertRequest>, AppointmentsService>();
builder.Services.AddScoped<ICRUDService<MCountries, CountriesSearchRequest, CountriesUpsertRequest, CountriesUpsertRequest>, CountriesService>();
builder.Services.AddScoped<ICRUDService<MCities, CitiesSearchRequest, CitiesUpsertRequest, CitiesUpsertRequest>, CitiesService>();
builder.Services.AddScoped<ICRUDService<MMaterials, MaterialsSearchRequest, MaterialsUpsertRequest, MaterialsUpsertRequest>, MaterialsService>();
builder.Services.AddScoped<ICRUDService<MManufacturers, ManufacturersSearchRequest, ManufacturersUpsertRequest, ManufacturersUpsertRequest>, ManufacturersService>();
builder.Services.AddScoped<ICRUDService<MTreatments, TreatmentSearchRequest, TreatmentsUpsertRequest, TreatmentsUpsertRequest>, TreatmentsService>();
builder.Services.AddScoped<ICRUDService<MTreatmentsMaterials, TreatmentsMaterialsSearchRequest, TreatmentsMaterialsUpsertRequest, TreatmentsMaterialsUpsertRequest>, TreatmentsMaterialsService>();
builder.Services.AddScoped<ICRUDService<MExaminations, ExaminationsSearchRequest, ExaminationUpsertRequest, ExaminationUpsertRequest>, ExaminationsService>();


builder.Services.AddAutoMapper(typeof(IUserService));

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var connectionString = builder.Configuration.GetConnectionString("eDentist");
builder.Services.AddDbContext<eDentistContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<eDentistContext>();
    dataContext.Database.EnsureCreated();
}

app.Run();