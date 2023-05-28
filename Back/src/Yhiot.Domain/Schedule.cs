using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yhiot.Domain
{
    public class Schedule
    {
        public enum ActiveSchedule
        {
            yes,
            no
        }


        public int Id { get; set; }
        public string? SchedulePatient { get; set; }
        public string? SchedulePatientCpf { get; set; }
        public ActiveSchedule ScheduleActive { get; set; } // ENUM
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleRegistration { get; set; }
        public int UserId {get; set;}
        public User? User {get; set;}
    }
}