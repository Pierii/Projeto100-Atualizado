using System;

namespace FinalProject.Models
{
    public class Depoimento
    {
        public int ID {get; set;}
        public string NomeDeQuemComentou {get; set;}
        public string TextoDepoimento {get; set;}
        public DateTime DataDepoimento {get; set;}
        public string Escolha {get; set;}
    }
}