using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Usuario
    {

        /// <summary>
        /// Id do Usuario
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nome do Usuário
        /// </summary>
        public string Nome { get; set; }   

        /// <summary>
        /// login de acesso
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Senha de acesso
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Construtor para usuario padrão
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="login">Usuario</param>
        /// <param name="senha">Senha</param>
        public Usuario(string nome, string login, string senha)
        {
            Nome = nome;
            Id = Guid.NewGuid().ToString();
            Login = login;
            Senha = senha;

            Console.WriteLine($"Usuario {Id} cadastrado com sucesso!");
            Console.WriteLine("");
        }

        public Usuario(string id, string nome, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;

            Console.WriteLine($"Usuario {Id} cadastrado com sucesso!");
            Console.WriteLine("");
        }

        public static Usuario FromCsv(string csvLine)
        {
            string[] campos = csvLine.Split(',');
            Usuario usu = new Usuario(campos[0], campos[1], campos[2], campos[3]);
            return usu;
        }

       
    }
}
