using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] //api/
public class PropertyController(DataContext context) : ControllerBase
{

    [HttpGet]
    public async Task <ActionResult<IEnumerable<AppUser>>> GetProperties()
    {

        var properties = await context.MyProperty.ToListAsync();
        return properties;


    }


    [HttpGet("{id:int}")]
    public async Task <ActionResult<AppUser>> GetPropery(int id)
    {

        var property = await context.MyProperty.FindAsync(id);

        if (property == null) return NotFound();

        return property;


    }

}
