# backend
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementApp.Models
{
    public enum UserRole { Admin, BranchRep, Alumni, Member }
    public enum UserStatus { Active, Inactive, Pending, Banned }

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required, MaxLength(255)]
        public string FullName { get; set; }

        [Required]
        public Guid UnivarsityId { get; set; }

        public UserRole Role { get; set; } = UserRole.Member;
        public bool IsBecMember { get; set; } = false;
        public string? NecPosition { get; set; }
        public string? BecPosition { get; set; }
        public UserStatus Status { get; set; } = UserStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("UnivarsityId")]
        public Univarsity? Univarsity { get; set; }
    }

    public class University
    {
        [Key]
        [MaxLength(10)]
        // e.g., 1, 1A, 1B
        public Guid Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? CampusName { get; set; }

        [MaxLength(100)]
        public string? Province { get; set; }
    }
    public class Campus
    {
      [Key]
      public Guid Id { get; set; }
  
      [Required]
      public Guid UnivarsityId { get; set; }
  
      [MaxLength(10)]
      public string CampusCode { get; set; }
  
      [MaxLength(255)]
      public string Name { get; set; }
  
      [ForeignKey("UnivarsityId")]
      public Univarsity Univarsity { get; set; }
    }
}


using Microsoft.EntityFrameworkCore;
using UserManagementApp.Models;

namespace UserManagementApp.Data
{
    public class UserManagementAppDbContext : DbContext
    {
        public UserManagementAppDbContext(DbContextOptions<UserManagementAppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<University> Univarsities => Set<Univarsity>();
        public DbSet<Campus> Campuses => Set<Campus>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Declare GUIDs for Universities 
            var nwuId     = Guid.NewGuid();
            var uctId     = Guid.NewGuid();
            var ukznId    = Guid.NewGuid();
            var witsId    = Guid.NewGuid();
            var ujId      = Guid.NewGuid();
            var suId      = Guid.NewGuid();
            var cputId    = Guid.NewGuid();
            var uzId      = Guid.NewGuid();
            var nmuId     = Guid.NewGuid();
            var upId      = Guid.NewGuid();
            var tutId     = Guid.NewGuid();
            var vutId     = Guid.NewGuid();
            var dutId     = Guid.NewGuid();
            var unisaId   = Guid.NewGuid();
            var cutId     = Guid.NewGuid();
            var ufhId     = Guid.NewGuid();
            var ufsId     = Guid.NewGuid();
            var ulId      = Guid.NewGuid();
            var univenId      = Guid.NewGuid();
            var muId      = Guid.NewGuid();
            var ruId      = Guid.NewGuid();
            var smuId     = Guid.NewGuid();
            var spuId     = Guid.NewGuid();
            var mutId     = Guid.NewGuid();
            var wsuId     = Guid.NewGuid();
            var uwcId     = Guid.NewGuid();

            // Declare GUIDs for Campuses (only those referenced) 
            // NWU
            var potchId       = Guid.NewGuid();
            var vaalId        = Guid.NewGuid();
            var mahikengId    = Guid.NewGuid();

            // UCT
            var uctMainId     = Guid.NewGuid();

            // UKZN
            var edgewoodId    = Guid.NewGuid();
            var howardId      = Guid.NewGuid();
            var medSchoolId   = Guid.NewGuid();
            var pmbId         = Guid.NewGuid();
            var westvilleId   = Guid.NewGuid();

            // WITS
            var parktownId    = Guid.NewGuid();
            var braamfonteinId= Guid.NewGuid();

            // UJ
            var apkId         = Guid.NewGuid();
            var apbId         = Guid.NewGuid();
            var doornfonteinId= Guid.NewGuid();

            // SU
            var suMainId      = Guid.NewGuid();
            var tygerbergId   = Guid.NewGuid();
            var bellvilleParkId = Guid.NewGuid();
            var saldanhaId    = Guid.NewGuid();

            // CPUT
            var bellvilleId   = Guid.NewGuid();
            var grangerBayId  = Guid.NewGuid();
            var mowbrayId     = Guid.NewGuid();
            var athloneId     = Guid.NewGuid();
            var wellingtonId  = Guid.NewGuid();
            var cptId       = Guid.NewGuid();

            // UZ
            var kwaDlangezwaId= Guid.NewGuid();
            var richardsBayId = Guid.NewGuid();

            // NMU
            var summerstrandId= Guid.NewGuid();
            var secondAvenueId= Guid.NewGuid();
            var birdStreetId  = Guid.NewGuid();
            var missionvaleId = Guid.NewGuid();
            var northCampusId = Guid.NewGuid();
            var southCampusId = Guid.NewGuid();
            var oceanSciencesId = Guid.NewGuid();

            // UP
            var hatfieldId    = Guid.NewGuid();
            var onderstepoortId = Guid.NewGuid();
            var groenkloofId  = Guid.NewGuid();
            var prinshofId    = Guid.NewGuid();
            var hillcrestId = Guid.NewGuid();
            var mamelodiId  = Guid.NewGuid();

            // TUT
            var pretoriaMainId = Guid.NewGuid();
            var arcadiaId   = Guid.NewGuid();
            var artsId      = Guid.NewGuid();
            var garankuwaId = Guid.NewGuid();
            var sNorthId    = Guid.NewGuid();
            var sSouthId    = Guid.NewGuid();
            var emalahleniId= Guid.NewGuid();
            var mbombelaId  = Guid.NewGuid();
            var polokwaneId = Guid.NewGuid();

            // VUT
            var vutMainId     = Guid.NewGuid();

            // DUT
            var brickfieldId  = Guid.NewGuid();
            var cityId        = Guid.NewGuid();
            var indumisoId    = Guid.NewGuid();
            var mlSultanId    = Guid.NewGuid();
            var ritsonId      = Guid.NewGuid();
            var riversideId   = Guid.NewGuid();
            var steveBikoId   = Guid.NewGuid();

            // UNISA
            var unisaMainId   = Guid.NewGuid();

            // CUT
            var cutBloemId    = Guid.NewGuid();
            var cutWelkomId   = Guid.NewGuid();

            // UFH
            var aliceId       = Guid.NewGuid();
            var eastLondonId  = Guid.NewGuid();
            var bishoId       = Guid.NewGuid();

            // UFS
            var ufsBloemId    = Guid.NewGuid();
            var ufsSouthId    = Guid.NewGuid();
            var ufsQwaqwaId   = Guid.NewGuid();

            // UL, UV, SMU, RU (single-campus)
            var ulMainId      = Guid.NewGuid();
            var univenMainId      = Guid.NewGuid();
            var smuMainId      = Guid.NewGuid();
            var ruMainId      = Guid.NewGuid();

            // MU
             var muMainId      = Guid.NewGuid();

            // SPU
            var spuNorthId    = Guid.NewGuid();
            var spuSouthId    = Guid.NewGuid();
            var spuCentralId  = Guid.NewGuid();

            // MUT
            var mutMainId     = Guid.NewGuid();
            var mutNorthId    = Guid.NewGuid();

            // WSU
            var wsuMthathaId  = Guid.NewGuid();
            var wsuButterworthId = Guid.NewGuid();
            var wsuBuffaloCityId = Guid.NewGuid();
            var wsuKomaniId   = Guid.NewGuid();

            // UWC
            var uwcMainId     = Guid.NewGuid();
            var uwcTygerbergId= Guid.NewGuid();

            // Seed Universities 
            modelBuilder.Entity<University>().HasData(
                new Univarsity { Id = nwuId,  Name = "North-West Univarsity" },
                new Univarsity { Id = uctId,  Name = "Univarsity of Cape Town" },
                new Univarsity { Id = ukznId, Name = "Univarsity of KwaZulu-Natal" },
                new Univarsity { Id = witsId, Name = "Univarsity of the Witwatersrand" },
                new Univarsity { Id = ujId,   Name = "Univarsity of Johannesburg" },
                new Univarsity { Id = suId,   Name = "Stellenbosch Univarsity" },
                new Univarsity { Id = cputId, Name = "Cape Peninsula Univarsity of Technology" },
                new Univarsity { Id = uzId,   Name = "Univarsity of Zululand" },
                new Univarsity { Id = nmuId,  Name = "Nelson Mandela Univarsity" },
                new Univarsity { Id = upId,   Name = "University of Pretoria" },
                new Univarsity { Id = tutId,  Name = "Tshwane Univarsity of Technology" },
                new Univarsity { Id = vutId,  Name = "Vaal Univarsity of Technology" },
                new Univarsity { Id = dutId,  Name = "Durban Univarsity of Technology" },
                new Univarsity { Id = unisaId,Name = "Univarsity of South Africa" },
                new Univarsity { Id = cutId,  Name = "Central Univarsity of Technology" },
                new Univarsity { Id = ufhId,  Name = "Univarsity of Fort Hare" },
                new Univarsity { Id = ufsId,  Name = "Univarsity of the Free State" },
                new Univarsity { Id = ulId,   Name = "Univarsity of Limpopo" },
                new Univarsity { Id = univenId,   Name = "Univarsity of Venda" },
                new Univarsity { Id = muId,   Name = "Univarsity of Mpumalanga" },
                new Univarsity { Id = ruId,   Name = "Rhodes Univarsity" },
                new Univarsity { Id = smuId,  Name = "Sefako Makgatho Health Sciences Univarsity" },
                new Univarsity { Id = spuId,  Name = "Sol Plaatje Univarsity" },
                new Univarsity { Id = mutId,  Name = "Mangosuthu Univarsity of Technology" },
                new Univarsity { Id = wsuId,  Name = "Walter Sisulu Univarsity" },
                new Univarsity { Id = uwcId,  Name = "Univarsity of the Western Cape" }
            );

            // Seed Campuses (sample structure) 
            modelBuilder.Entity<Campus>().HasData(
                // North-West Univarsity
                new Campus { Id = potchId, UnivarsityId = nwuId, CampusCode = "1A", Name = "Potchefstroom Campus" },
                new Campus { Id = vaalId, UnivarsityId = nwuId, CampusCode = "1B", Name = "Vaal Triangle Campus" },
                new Campus { Id = mahikengId, UnivarsityId = nwuId, CampusCode = "1C", Name = "Mahikeng Campus" },

                // Univarsity of Cape Town
                new Campus { Id = uctMainId, UnivarsityId = uctId, CampusCode = "2", Name = "Main Campus" },

                // UKZN
                new Campus { Id = edgewoodId, UnivarsityId = ukznId, CampusCode = "3A", Name = "Edgewood Campus" },
                new Campus { Id = howardId, UnivarsityId = ukznId, CampusCode = "3B", Name = "Howard College" },
                new Campus { Id = medSchoolId, UnivarsityId = ukznId, CampusCode = "3C", Name = "Medical School" },
                new Campus { Id = pmbId, UnivarsityId = ukznId, CampusCode = "3D", Name = "Pietermaritzburg Campus" },
                new Campus { Id = westvilleId, UnivarsityId = ukznId, CampusCode = "3E", Name = "Westville Campus" },

                // WITS
                new Campus { Id = parktownId, UnivarsityId = witsId, CampusCode = "4A", Name = "Parktown Campus" },
                new Campus { Id = braamfonteinId, UnivarsityId = witsId, CampusCode = "4B", Name = "Braamfontein Campus" },

                // UJ
                new Campus { Id = apkId, UnivarsityId = ujId, CampusCode = "5A", Name = "Auckland Park Kingsway (APK)" },
                new Campus { Id = apbId, UnivarsityId = ujId, CampusCode = "5B", Name = "Auckland Park Bunting Road (APB)" },
                new Campus { Id = doornfonteinId, UnivarsityId = ujId, CampusCode = "5C", Name = "Doornfontein Campus" },

                // Stellenbosch Univarsity
                new Campus { Id = suMainId, UnivarsityId = suId, CampusCode = "6A", Name = "Main Campus" },
                new Campus { Id = tygerbergId, UnivarsityId = suId, CampusCode = "6B", Name = "tygerberg Campus" },
                new Campus { Id = bellvilleParkId, UnivarsityId = suId, CampusCode = "6C", Name = "Bellville Park Campus" },
                new Campus { Id = saldanhaId, UnivarsityId = suId, CampusCode = "6D", Name = "Saldanha Campus" },

                // Cape Peninsula Univarsity of Technology
                new Campus { Id = bellvilleId, UnivarsityId = CPUTId, CampusCode = "7A", Name = "Bellville Campus" }, 
                new Campus { Id = GrangerBayCampusId, UnivarsityId = CPUTId, CampusCode = "7B", Name = "Granger Bay Campus" }, 
                new Campus { Id = MowbrayId, UnivarsityId = CPUTId, CampusCode = "7C", Name = "Mowbray Campus" }, 
                new Campus { Id = AthloneId, UnivarsityId = CPUTId, CampusCode = "7D", Name = "Athlone Campus" }, 
                new Campus { Id = Wellington CampusId, UnivarsityId = CPUTId, CampusCode = "7E", Name = "Wellington Campus" },

                // Univarsity of Zululand
                new Campus { Id = KwaDlangezwaId, UnivarsityId = UZId, CampusCode = "8A", Name = "KwaDlangezwa Campus" }, 
                new Campus { Id = RichardBayId, UnivarsityId = UZId, CampusCode = "8B", Name = "Richards Bay Campus" },

                // Nelson Mandela Univarsity
                new Campus { Id = SummerstrandId, UnivarsityId = NMUId, CampusCode = "9A", Name = "Summerstrand Campus" }, 
                new Campus { Id = SecondAvenueId, UnivarsityId = NMUId, CampusCode = "9B", Name = "Second Avenue Campus" }, 
                new Campus { Id = BirdStreetId, UnivarsityId = NMUId, CampusCode = "9C", Name = "Bird Street Campus" }, 
                new Campus { Id = MissionvaleId, UnivarsityId = NMUId, CampusCode = "9D", Name = "Missionvale Campus" }, 
                new Campus { Id = NorthId, UnivarsityId = NMUId, CampusCode = "9E", Name = "North Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = NMUId, CampusCode = "9F", Name = "South Campus" }, 
                new Campus { Id = OceanSciencesId, UnivarsityId = NMUId, CampusCode = "9G", Name = "Ocean Sciences Campus" },

                // Univarsity of Pretoria
                new Campus { Id = HatfieldId, UnivarsityId = UPId, CampusCode = "10A", Name = "Hatfield Campus" }, 
                new Campus { Id = OnderstepoortId, UnivarsityId = UPId, CampusCode = "10B", Name = "Onderstepoort Campus" }, 
                new Campus { Id = GroenkloofId, UnivarsityId = UPId, CampusCode = "10C", Name = "Groenkloof Campus" }, 
                new Campus { Id = PrinshofId, UnivarsityId = UPId, CampusCode = "10D", Name = "Prinshof Campus" }, 
                new Campus { Id = HillcrestId, UnivarsityId = UPId, CampusCode = "10E", Name = "Hillcrest Campus" },
                new Campus { Id = MamelodiId, UnivarsityId = UPId, CampusCode = "10E", Name = "Mamelodi Campus" },

                // Tshwane Univarsity of Technology
                new Campus { Id = PretoriaMainId, UnivarsityId = TUTId, CampusCode = "11A", Name = "Pretoria Main Campus" }, 
                new Campus { Id = SoshanguveNorthId, UnivarsityId = TUTId, CampusCode = "11B", Name = "Soshanguve North Campus" }, 
                new Campus { Id = SoshanguveSouthId, UnivarsityId = TUTId, CampusCode = "11C", Name = "Soshanguve South Campus" },
                new Campus { Id = ArcadiaId, UnivarsityId = TUTId, CampusCode = "11D", Name = "Arcadia Campus" },
                new Campus { Id = ArtsId, UnivarsityId = TUTId, CampusCode = "11E", Name = "Arts Campus" },
                new Campus { Id = Ga-rankuwaId, UnivarsityId = TUTId, CampusCode = "11F", Name = "Ga-rankuwa Campus" },
                new Campus { Id = EmalahleniId, UnivarsityId = TUTId, CampusCode = "11G", Name = "Emalahleni Campus" },
                new Campus { Id = MbombelaId, UnivarsityId = TUTId, CampusCode = "11H", Name = "Mbombela Campus" },
                new Campus { Id = PolokwaneId, UnivarsityId = TUTId, CampusCode = "11I", Name = "Polokwane Campus" },

                // Vaal Univarsity of Technology
                new Campus { Id = VUTMainId, UniversityId = VUTId, CampusCode = "12", Name = "Vaal Univarsity of Technology" },

                // Durban Univarsity of Technology
                new Campus { Id = BrickfieldId, UnivarsityId = DUTId, CampusCode = "13A", Name = "Brickfield Campus" }, 
                new Campus { Id = CityId, UnivarsityId = DUTId, CampusCode = "13B", Name = "City Campus" }, 
                new Campus { Id = IndumisoId, UnivarsityId = DUTId, CampusCode = "13C", Name = "Indumiso Campus" }, 
                new Campus { Id = MLSultanId, UnivarsityId = DUTId, CampusCode = "13D", Name = "ML Sultan Campus" }, 
                new Campus { Id = RitsonId, UnivarsityId = DUTId, CampusCode = "13E", Name = "Ritson Campus" }, 
                new Campus { Id = RiversideId, UnivarsityId = DUTId, CampusCode = "13F", Name = "Riverside Campus" }, 
                new Campus { Id = SteveBikoId, UnivarsityId = DUTId, CampusCode = "13G", Name = "Steve Biko Campus" },

                // UNISA
                 new Campus { Id = UNISAId, UnivarsityId = UNISAId, CampusCode = "14", Name = "UNISA" },

                // Central Univarsity of Technology
                new Campus { Id = BloemId, UnivarsityId = CUTId, CampusCode = "15A", Name = "Bloemfontein Campus" },
                new Campus { Id = WelkomId, UnivarsityId = CUTId, CampusCode = "15B", Name = "Welkom Campus" },

                // Univarsity of Fort Hare
                new Campus { Id = AliceId, UnivarsityId = UFHId, CampusCode = "16A", Name = "Alice Campus" }, 
                new Campus { Id = EastLondonId, UnivarsityId = UFHId, CampusCode = "16B", Name = "East London Campus" }, 
                new Campus { Id = BishoId, UnivarsityId = UFHId, CampusCode = "16C", Name = "Bisho Campus" },

                // Univarsity of Free State
                 new Campus { Id = BloemfonteinId, UnivarsityId = UFSId, CampusCode = "17A", Name = "Bloemfontein Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = UFSId, CampusCode = "17B", Name = "South Campus" }, 
                new Campus { Id = QwaqwaId, UnivarsityId = UFSId, CampusCode = "17C", Name = "Qwaqwa Campus" },

                // Univarsity of Limpopo
                new Campus { Id = ulMainId, UnivarsityId = ULId, CampusCode = "18", Name = "Univarsity of Limpopo" }

                // Univarsity of Venda
                new Campus { Id = univenId, UnivarsityId = UVId, CampusCode = "19", Name = "Univarsity of Venda" },

                // Univarsity of Mpumalanga
                new Campus { Id = MbombelaId, UnivarsityId = MUId, CampusCode = "20A", Name = " Mbombela Campus" },
                new Campus { Id = SiyabuswaId, UnivarsityId = MUId, CampusCode = "20B", Name = " Siyabuswa Campus" },

                // Rhodes University
                new Campus { Id = ruMainId, UnivarsityId = RUId, CampusCode = "21", Name = "Rhodes Univarsity" },

                // Sefako Makgatho Health Sciences Univarsity
                new Campus { Id = smuMainId, UnivarsityId = SMUId, CampusCode = "22A", Name = "SMU Main Campus" },

                // Sol Plaatje Univarsity
                new Campus { Id = NorthId, UnivarsityId = SPUId, CampusCode = "23A", Name = "North Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = SPUId, CampusCode = "23B", Name = "South Campus" }, 
                new Campus { Id = CentralId, UnivarsityId = SPUId, CampusCode = "23C", Name = "Central Campus" },

                // Mangosuthu University of Technology
                new Campus { Id = MainId, UniversityId = MUTId, CampusCode = "24A", Name = "Main Campus" }, 
                new Campus { Id = NorthId, UniversityId = MUTId, CampusCode = "24B", Name = "North Campus" },

                // Walter Sisulu Univarsity
                new Campus { Id = MthathaId, UnivarsityId = WSUId, CampusCode = "25A", Name = "Mthatha Campus" }, 
                new Campus { Id = ButterworthId, UnivarsityId = WSUId, CampusCode = "25B", Name = "Butterworth Campus" }, 
                new Campus { Id = BuffaloCityId, UnivarsityId = WSUId, CampusCode = "25C", Name = "Buffalo City Campus" }, 
                new Campus { Id = KomaniId, UnivarsityId = WSUId, CampusCode = "25D", Name = "Komani Campus" }, 
                new Campus { Id = TygerbergId, UnivarsityId = UWCId, CampusCode = "25E", Name = "Tygerberg Campus" },

                // Univarsity of Western Cape
                new Campus { Id = TygerbergId, UnivarsityId = UWCId, CampusCode = "26A", Name = "Tygerberg Campus" },
                new Campus { Id = BellvilleId, UnivarsityId = UWCId, CampusCode = "26B", Name = "Bellville Campus" },
  
            );
        }
    }
}


namespace UserManagementApp.DTOs
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string UniversityId { get; set; }
    }

    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

using System.Text.RegularExpressions;

namespace UserManagementApp.Helpers
{
    public static class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            if (password.Length < 8 || password.Length > 15)
                return false;

            if (!Regex.IsMatch(password, @"[A-Z]")) // Uppercase
                return false;

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>_\-+=]")) // Special char
                return false;

            return true;
        }
    }
}

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using UserManagementApp.Models;

namespace UserManagementApp.Services
{
    public class JwtService
    {
        private readonly string _key;
        public JwtService(IConfiguration config)
        {
            _key = config["Jwt:Key"];
        }

        public string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim("id", user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "UserManagementApp",
                audience: "UserManagementApp",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(3),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
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
