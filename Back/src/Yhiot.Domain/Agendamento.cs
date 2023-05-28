using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yhiot.Domain
{
    public class Agendamento
    {


        public int Id {get; set; }
        public string? ExameName {get; set; }
        public string? Date {get; set; }
        public string? Medico {get; set;}
        public string? cpf {get; set; }
        public string? foto {get; set; }
        public string? email {get; set;}
        public string? userInterface {get; set;}
        public string? userAut {get; set;}

    }
}