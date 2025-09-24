using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UserManagementApp.Data;
using UserManagementApp.DTOs;
using UserManagementApp.Models;


namespace UserManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly UserManagementAppDbContext _context;
        public EventsController(UserManagementAppDbContext context) => _context = context;

        private int GetUserId() =>
            int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");

        private string GetUserRole() =>
            User.FindFirst(ClaimTypes.Role)?.Value ?? "member";

        // GET /api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents([FromQuery] Guid? branchId, [FromQuery] bool? upcoming)
        {
            var q = _context.Events.Include(e => e.Branch).Include(e => e.Creator).AsQueryable();
            if (branchId.HasValue) q = q.Where(e => e.BranchId == branchId.Value);
            if (upcoming == true) q = q.Where(e => e.Date >= DateTime.UtcNow);
            return Ok(await q.ToListAsync());
        }

        // GET /api/events/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var ev = await _context.Events.Include(e => e.Branch).Include(e => e.Creator).FirstOrDefaultAsync(e => e.Id == id);
            return ev == null ? NotFound() : Ok(ev);
        }

        // POST /api/events
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Event>> CreateEvent([FromBody] EventCreateDto dto)
        {
            var userId = GetUserId();
            var role = GetUserRole();

            if (role != "nec" && role != "bec") return Forbid();

            var ev = new Event
            {
                Title = dto.Title,
                Description = dto.Description,
                EventType = dto.EventType,
                Date = dto.Date,
                Location = dto.Location,
                BranchId = dto.BranchId,
                CreatedBy = userId
            };

            _context.Events.Add(ev);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEvent), new { id = ev.Id }, ev);
        }

        // PATCH /api/events/{id}
        [HttpPatch("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] EventUpdateDto dto)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev == null) return NotFound();

            var userId = GetUserId();
            var role = GetUserRole();
            if (!(role == "nec" || ev.CreatedBy == userId)) return Forbid();

            if (!string.IsNullOrEmpty(dto.Title)) ev.Title = dto.Title;
            if (!string.IsNullOrEmpty(dto.Description)) ev.Description = dto.Description;
            if (!string.IsNullOrEmpty(dto.EventType)) ev.EventType = dto.EventType;
            if (dto.Date.HasValue) ev.Date = dto.Date.Value;
            if (!string.IsNullOrEmpty(dto.Location)) ev.Location = dto.Location;

            ev.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE /api/events/{id}
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev == null) return NotFound();

            var userId = GetUserId();
            var role = GetUserRole();
            if (!(role == "nec" || ev.CreatedBy == userId)) return Forbid();

            _context.Events.Remove(ev);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
