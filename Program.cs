using AutoMapper;
using GenshinApplication.DataContext;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Microsoft.OpenApi.Models;
using System.Reflection;
using GenshinApplication.Helpers;
using GenshinApplication.Services;
using GenshinApplication.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    opt.SerializerSettings.Converters.Add(new StringEnumConverter());
});
builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"));
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

IMapper mapper = new Mappers().Configuration().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUnitOfWorkService, UnitOfWorkService>();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo()
    {
        Version = "v1",
        Title = "GenshinApi",
        Description = "Api de consulta de personagens do genshin.",
        Contact = new OpenApiContact
        { Name = "Informaçõs de contato", Email = "contactemailaddress@domain.com" }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    opt.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "development",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200");
                      });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("development");

app.Run();
