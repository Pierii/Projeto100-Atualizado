using System;
using System.Collections.Generic;
using System.IO;
using FinalProject.Models;

namespace FinalProject.Repositorios {
    public class UsuarioRepositorio : BaseRepositorio {

        private List<Usuario> usuario = new List<Usuario> ();

        public static uint CONT = 0;
        private const string PATH = "Database/Usuario.csv";
        private const string PATH_INDEX = "Database/Usuario_Id.csv";
        private List<Usuario> usuarios = new List<Usuario>();

        public UsuarioRepositorio () {
            if (!File.Exists (PATH_INDEX)) {
                File.Create (PATH_INDEX).Close ();
            }

            var lastInd = File.ReadAllText (PATH_INDEX);
            uint indice = 0;
            uint.TryParse (lastInd, out indice);
            CONT = indice;
        }

        public bool Inserir (Usuario usuario) {
            CONT++;
            File.WriteAllText (PATH_INDEX, CONT.ToString ());

            string linha = PrepararRegistroCSV (usuario);
            File.AppendAllText (PATH, linha);

            return true;
        }


        public Usuario ObterPor (ulong id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (ExtrairCampo (id.ToString (), item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public Usuario ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (email.Equals (ExtrairCampo ("email", item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public List<Usuario> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                Usuario usuario = ConverterEmObjeto (item);

                this.usuarios.Add (usuario);
            }
            return this.usuarios;
        }

        private Usuario ConverterEmObjeto (string registro) {

            Usuario usuario = new Usuario ();
            System.Console.WriteLine ("REGISTRO:" + registro);
            usuario.Id = ulong.Parse (ExtrairCampo ("id", registro));
            usuario.Nome = ExtrairCampo ("nome", registro);
            usuario.Email = ExtrairCampo ("email", registro);
            usuario.Senha = ExtrairCampo ("senha", registro);
            usuario.DataDeNascimento = DateTime.Parse (ExtrairCampo ("dataNascimento", registro));

            return usuario;
        }
        private string PrepararRegistroCSV (Usuario usuario) {
            return $"id={CONT};nome={usuario.Nome};email={usuario.Email};senha={usuario.Senha};dataNascimento={usuario.DataDeNascimento}\n";
        }
    }
}