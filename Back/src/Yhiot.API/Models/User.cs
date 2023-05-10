using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yhiot.API.Models
{
    public class User
    {
        public int userId {get; set;}
        public string? userName {get; set;}
        public string? userPassword {get; set;}
        public string? userAut {get; set;}
        public string? userInterface {get; set;}
        public string? data {get; set;}
        public string? userEmail {get; set;}
        public string? userCpf {get; set;}
    }
}