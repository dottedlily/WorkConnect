using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using WorkConnect.Models;


[Route("api/[controller]")]
[ApiController]


public class UsersController : ControllerBase
{
    private readonly DatabaseContext _context;

    public UsersController(DatabaseContext context)
    {
        _context = context;
    }


    [HttpGet("GetUsers")]
    public async Task<IActionResult> GetUser()
    {
        var result = await _context.Users.Select(x => new Users
        {
            id = x.id,
            email = x.email
        }).ToListAsync();

        return Ok(result);
    }

    [HttpPost("CreateUser")]
    public async Task<IActionResult> CreateUser([FromBody] Users user)
    {
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok(user);
    
    }

    // [HttpGet("TestDb")]
    // public IActionResult TestDb()
    // {
    //     _context.Database.OpenConnection();
    //     _context.Database.CloseConnection();
    //     return Ok("Connected!");
    // }

}

