using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yhiot.Domain
{
    public class User
    {
        

        public enum UserInterfaceEnum
        {
            doc,
            user,
            adm,
        }

        public enum UserAutenticationEnum
        {
            yes,
            no
        }
        public int id {get; set;}
        public string? userName {get; set;}
        public string? userPassword {get; set;}

        [Column(TypeName = "VARCHAR(3)")]
        public UserAutenticationEnum userAut {get; set;}
        public DateTime? data {get; set;}
        public string? userEmail {get; set;}
        public string? userCpf {get; set;}

        [Column(TypeName = "VARCHAR(3)")]
        public UserInterfaceEnum userInterface {get; set;}
        public IEnumerable<Schedule>? Schedules {get; set;}
    }
}
