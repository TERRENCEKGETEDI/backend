using Microsoft.AspNetCore.Mvc;
using UserManagementApp.Data;
using UserManagementApp.DTOs;
using UserManagementMyApp.Models;
using UserManagementApp.Services;
using UserManagementApp.Helpers;
using System.Linq;

namespace UserManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManagementAppDbContext _context;
        private readonly JwtService _jwt;

        public AuthController(UserManagementAppDbContext context, JwtService jwt)
        {
            _context = context;
            _jwt = jwt;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            if (_context.Users.Any(u => u.Email == dto.Email))
                return BadRequest("Email already exists.");

            if (!PasswordValidator.IsValid(dto.Password))
                return BadRequest("Password must be 8–15 characters, include at least one uppercase letter and one special character.");

            var user = new User
            {
                Email = dto.Email,
                FullName = dto.FullName,
                UniversityId = dto.UniversityId,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Status = UserStatus.Active
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new { message = "User registered successfully." });
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == dto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
                return Unauthorized("Invalid credentials.");

            var token = _jwt.GenerateToken(user);
            return Ok(new { token });
        }
    }
}
using Microsoft.EntityFrameworkCore;
using UserManagementApp.Data;
using UserManagementApp.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database connection
builder.Services.AddDbContext<UserManagementAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// JWT
builder.Services.AddScoped<JwtService>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "UserManagementApp",
            ValidAudience = "UserManagementApp",
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=UserManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Jwt": {
    "Key": "super_secret_key_12345"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}


Configuration and Startup


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Database connection
builder.Services.AddDbContext<UserManagementAppDb
