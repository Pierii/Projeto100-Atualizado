using System;

namespace FinalProject.Models
{
    public class Usuario
    {
        public ulong Id {get; set;}
        public string Nome {get; set;}
        public string Senha {get; set;}
        public string Email {get; set;}
        public DateTime DataDeNascimento {get; set;}
    }
}