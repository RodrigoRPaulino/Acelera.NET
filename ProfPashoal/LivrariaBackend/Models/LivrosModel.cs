using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaBackend.Models
{
    [Table("livro")]
    public class LivrosModel
    {
        [Key()]
        public int COD { get; set; }
        [Column]
        public string Livro { get; set; }
        [Column]
        public string PG { get; set; }
        [Column]
        public int Valor { get; set; }

        public LivrosModel() { }
        public LivrosModel(int cod, string livro, string pg, int valor)
        {
            this.COD = cod;
            this.Livro = livro;
            this.PG = pg;
            this.Valor = valor;


        }
         
    }
}
