using AutoMapper;
using GenshinApplication.DataContext;
using GenshinApplication.DataContext.Interfaces;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"));
});
var configuration = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Users, PostUsersDto>();
    cfg.CreateMap<PostUsersDto, Users>();
    cfg.CreateMap<Characters, CharactersPostDto>();
    cfg.CreateMap<CharactersPostDto, Characters>();

});
IMapper mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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

app.Run();
