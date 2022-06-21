using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace paisesinfoapi.Controllers;
[Route("api/[Controller]")]
[ApiController]
public class PaisController : ControllerBase
{
    public readonly DataContext _context;
    public PaisController(DataContext context)
    {
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public async Task<ActionResult<List<PaisData>>> Get()
    {
        return Ok(await _context.PaisesData.ToListAsync());
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<PaisData>> Get(int id)
    {
        var pais = await _context.PaisesData.FindAsync(id);
        if(pais == null)
            return BadRequest("País no encontrado");
        return Ok(pais);
    }
    [HttpGet("nombre={nombre}")]
    public async Task<ActionResult<PaisData>> Get(string nombre)
    {
        var pais = await _context.PaisesData.FirstOrDefaultAsync(m => m.nombre == nombre);
        if(pais == null)
            return BadRequest("País no encontrado");
        return Ok(pais);
    }
}
