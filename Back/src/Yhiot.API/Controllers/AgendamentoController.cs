using Microsoft.AspNetCore.Mvc;
using Yhiot.API.Data;
using Yhiot.API.Models;

namespace Yhiot.API.Controllers;

[ApiController]
[Route("api/fracasso")]
public class EventoController : ControllerBase
{
  
        private readonly DataContext _context;

    public EventoController(DataContext context)
    {
            this._context = context;

    }

    [HttpGet]
    public IEnumerable<Agendamento>? Get()
    {
        return _context.agendamentos;

    }

    [HttpGet("{id}")]
    public Agendamento GetById(int id)
    {
        return _context.agendamentos.FirstOrDefault(Agendamento => Agendamento.AgendamentoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Put id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo deletee id = {id}";
    }
}
