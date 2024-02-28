using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaBackend.Models
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column]
        public string Nome { get; set; }
        [Column]
        public string Login { get; set; }
        [Column]
        public string Senha { get; set; }

        public UsuarioModel(string nome, string login, string senha) 
        {
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;

        }

    }
}
