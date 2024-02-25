using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLivraria.Domain
{
    public class Livros
    {
        /// <summary>
        /// Nome do Livro
        /// </summary>
        public string Livro { get; set; }
        /// <summary>
        /// Quantidade de Páginas
        /// </summary>
        public int Paginas { get; set; }
        /// <summary>
        /// CODIGO ISBN (International Standard Book Number)
        /// </summary>
        public double Codigo { get; set; }
        /// <summary>
        /// Valor do Livro em Reais (BRL)
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Construtor para Livro padrão 
        /// </summary>
        /// <param name="livro">Nome do Livro</param>
        /// <param name="paginas">Numero de Paginas</param>
        /// <param name="codigo">Código ISBN</param>
        /// <param name="valor"> Preço (BRL)</param>
        public Livros(string livro, int paginas, double codigo, decimal valor)
        {
            Livro = livro;

            Paginas = paginas;

            Codigo = codigo;

            Valor = valor;
        }
        public Livros()
        {

        }




        public override string ToString()
        {
            return Livro;
        }







    }
}
