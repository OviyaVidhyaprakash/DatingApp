using System;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]

    public async Task<ActionResult <IEnumerable<AppUser>>> GetUsers()
    {
            var users=await context.Users.ToListAsync();
            return users;
    }
    [HttpGet("{id:int}")]

    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
            var user=await context.Users.FindAsync(id);
            if(user==null) return NotFound();
            return user;
    }
}
