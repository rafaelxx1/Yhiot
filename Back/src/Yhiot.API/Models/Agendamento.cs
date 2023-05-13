using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yhiot.API.Models
{
    public class Agendamento
    {
        public int AgendamentoId {get; set; }
        public string? ExameName {get; set; }
        public string? DataAgendamento {get; set; }
        public string? Medico {get; set;}
        public string? cpf {get; set; }
        public string? foto {get; set; }
    }
}