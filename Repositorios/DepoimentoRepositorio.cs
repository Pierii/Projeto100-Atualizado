using System;
using System.Collections.Generic;
using System.IO;
using FinalProject.Models;

namespace FinalProject.Repositorios
{
    public class DepoimentoRepositorio
    {
        private string PATH = "DataBase/Depoimento.csv";

        public List<Depoimento> listaDeDepoimentos = new List<Depoimento>();


        public void SalvarDepoimento(Depoimento depoimento)
        {
             if (File.Exists(PATH))
            {
                depoimento.ID = File.ReadAllLines(PATH).Length + 1;
            }else{
                depoimento.ID = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{depoimento.ID};{depoimento.NomeDeQuemComentou};{depoimento.TextoDepoimento};{depoimento.Escolha};{DateTime.Now}");
            sw.Close();
        }
        public List<Depoimento> ListarDepoimentos(){

            string[] depoimentos = File.ReadAllLines(PATH);

            foreach (var item in depoimentos)
            {
                if(item != null){
                string[] dados = item.Split(";");
                var depoimento = new Depoimento();
                // depoimento.ID = int.Parse(dados[0]);
                depoimento.NomeDeQuemComentou = dados[1];
                depoimento.TextoDepoimento = dados[2];
                depoimento.Escolha = dados[3];
                depoimento.DataDepoimento = DateTime.Parse(dados[4]);
                listaDeDepoimentos.Add(depoimento);
                }
            }
            return listaDeDepoimentos;
        }

        public void Excluir(Depoimento depoimento)
        {
           
        }
    }
}