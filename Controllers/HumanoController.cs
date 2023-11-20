namespace Projeto.Controllers;

using Microsoft.AspNetCore.Mvc;
using Projeto.Data;
using Projeto.Models;

[ApiController]
[Route("api/[controller]")]
public class HumanoController : ControllerBase
{
    private readonly AppDataContext _context;

    public HumanoController(AppDataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Listar()
    {
        try
        {
            List<Humano> humanos = _context.Humanos.ToList();
            return Ok(humanos);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    [Route("Cadastrar")]
    public IActionResult Cadastrar([FromBody] Humano humano)
    {
        try
        {
            _context.Add(humano);
            _context.SaveChanges();
            return Created("", humano);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}

