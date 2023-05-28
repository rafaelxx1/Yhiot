using Microsoft.AspNetCore.Mvc;
using Yhiot.Persistence;
using Yhiot.Domain;
using Yhiot.Persistence.Context;

namespace Yhiot.API.Controllers;

[ApiController]
[Route("api/fracasso")]
public class EventoController : ControllerBase
{
  
        private readonly YhiotContext _context;

    public EventoController(YhiotContext context)
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
        return _context.agendamentos.FirstOrDefault(Agendamento => Agendamento.Id == id);
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
