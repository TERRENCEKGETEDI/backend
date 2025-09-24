public class JwtService
{
    private readonly string _key;
    public JwtService(IConfiguration config)
    {
        _key = config["Jwt:Key"];
    }

    public string GenerateToken(User user)
    {
        var claims = new[] { new Claim(JwtRegisteredClaimNames.Sub, user.Email), new Claim("id", user.Id.ToString()), new Claim(ClaimTypes.Role, user.Role.ToString()) };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(issuer: "UserManagementApp", audience: "UserManagementApp", claims: claims, expires: DateTime.UtcNow.AddHours(3), signingCredentials: creds);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
