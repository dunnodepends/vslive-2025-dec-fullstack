// Copyright Information
// ==================================
// AutoLot8 - AutoLot.ShortApi - Program.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

using AutoLot.ShortApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => 
    options.AddDefaultPolicy(c => c.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.MapGet("/api/cars/{id}", (int id)
    => Results.Ok(BaseDataService.CarList.FirstOrDefault(c => c.Id == id)));
app.MapGet("/api/cars/bymake/{makeId}", (int makeId)
    => Results.Ok(BaseDataService.CarList.Where(c => c.MakeId == makeId)));
app.MapGet("/api/cars", () => Results.Ok(BaseDataService.CarList));
app.MapPost("/api/cars", () => Results.Ok());
app.MapPut("/api/cars/{id}", (int id) => Results.Ok());
app.MapDelete("/api/cars/{id}", (int id) => Results.Ok());
app.MapGet("/api/makes/{id}", (int id)
    => Results.Ok(BaseDataService.Makes.FirstOrDefault(c => c.Id == id)));
app.MapGet("/api/makes", () => Results.Ok(BaseDataService.Makes));
app.MapPost("/api/makes", () => Results.Ok());
app.MapPut("/api/makes/{id}", (int id) => Results.Ok());
app.MapDelete("/api/makes/{id}", (int id) => Results.Ok());

app.Run();

