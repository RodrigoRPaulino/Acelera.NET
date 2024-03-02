using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaBackend.Models
{
    [Table("")]
    public class EmprestimoModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }


        public EmprestimoModel() { }
        public EmprestimoModel(int id,int idUsuario,int idLivro,DateTime dataEmprestimo,DateTime dataDevolucao)
        {
            this.Id = id;
            this.IdUsuario = idUsuario;
            this.IdLivro = idLivro;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucao = dataDevolucao; 
        }
    }
}
