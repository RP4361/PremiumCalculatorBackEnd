
using DataAccess;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// setting up CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("GlobalCorsPolicy",
        policy =>
        {
            policy.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
                                .AllowAnyHeader().AllowAnyMethod();
        });
});




// Add services to the container.

// Registering the DBContext here
builder.Services.AddDbContext<ApplicationContext>(options =>
options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

// Maintaining lifetimes of various services
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IOccupationRepository, OccupationRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// adding CORS Middleware
app.UseCors("GlobalCorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
