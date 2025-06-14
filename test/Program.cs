using Microsoft.EntityFrameworkCore;
using test.Configuration;
using test.Interface;
using test.Model;
using test.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register repositories
builder.Services.AddScoped<IFlatRepo, FlatRepo>();
builder.Services.AddScoped<IContactUsRequests, ContactUsRepo>();
builder.Services.AddScoped<IRegisterRepo, RegisterRepo>();
builder.Services.AddScoped<ISocialHouse, SocialHouseRepo>();
builder.Services.AddScoped<IAdmin, AdminRepo>();

// Database configuration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure CORS - IMPORTANT UPDATE
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>  // Using default policy for simplicity
    {
        policy.AllowAnyOrigin()    // Allow all origins
              .AllowAnyMethod()     // Allow all HTTP methods
              .AllowAnyHeader()     // Allow all headers
              .SetIsOriginAllowed(origin => true); // Extra origin permission
    });
});

var app = builder.Build();

// Middleware pipeline configuration
app.UseSwagger();
app.UseSwaggerUI();

// Listen on all network interfaces
app.Urls.Add("http://0.0.0.0:5000");  // HTTP port
app.Urls.Add("https://0.0.0.0:5001"); // HTTPS port

// CRITICAL MIDDLEWARE ORDER
app.UseRouting();                      // Must come first

app.UseCors();                         // Enable CORS immediately after routing

// TEMPORARILY DISABLE HTTPS REDIRECTION FOR TESTING
// app.UseHttpsRedirection();          // Comment out during initial testing

app.UseAuthorization();

app.MapControllers();

app.Run();