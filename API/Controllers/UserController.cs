using API.Database;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // /api/User
public class UserController : ControllerBase
{
    private readonly DataContext _context;
    public UserController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUserList()
    {
        var users = await _context.AppUser.ToListAsync();

        return users;
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _context.AppUser.FindAsync(id);

        return user;
    }
}
