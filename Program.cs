using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TripManagmentSystem.Data;
using TripManagmentSystem.Models;

var builder = WebApplication.CreateBuilder(args);

// �������� �� MySQL ���� ���� �����
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// �������� �� Identity
builder.Services.AddDefaultIdentity<ApplicationUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

app.Run();
