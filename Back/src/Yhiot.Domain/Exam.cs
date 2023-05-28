using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yhiot.Domain
{
    public class Exam
    {

        public enum ExamActiveEnum
        {
            yes,
            no
        }
        
        public int Id {get; set;}
        public string? exName {get; set;}

        [Column(TypeName = "VARCHAR(3)")]
        public ExamActiveEnum exAct {get; set;}
        public DateTime exRegister {get; set;}
        public IEnumerable<Schedule>? Schedules {get; set;}
    }
}