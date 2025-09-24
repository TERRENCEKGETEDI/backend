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
        // Register logic
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        // Login logic
    }
}


Configuration and Startup


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Database connection
builder.Services.AddDbContext<UserManagementAppDb
