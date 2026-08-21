using MedicalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using MedicalApp.Application.Interfaces;
using MedicalApp.Application.Services;
using MedicalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using MedicalApp.Infrastructure.Repositories;
using MedicalApp.Application.Interfaces;
using MedicalApp.Application.Services;
using MedicalApp.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MedicalDbContext>(options =>
    options.UseNpgsql(connectionString));

#region DEPENDENCIAS
builder.Services.AddScoped<ISpecialityService, SpecialityService>();
builder.Services.AddScoped<ISpecialityRepository, SpecialtyRepository>();

builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();

builder.Services.AddScoped<IAvailabilityService, AvailabilityService>();
builder.Services.AddScoped<IAvailabilityRepository, AvailabilityRepository>();


#endregion DEPENDENCIAS
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();