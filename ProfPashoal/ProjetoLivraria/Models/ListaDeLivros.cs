using System.Data;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ControlLivraria.Models
{
    public class ListaDeLivros
    {
        List<Livros> book;

        public ListaDeLivros()
        {
            book = new List<Livros>();
        }

        public void CadastraLivro(Livros livro)
        {
            book.Add(livro);
        }

        public List<Livros> ListaLivros()
        {
            return book;
        }
        public void SalvaLocalJSON(string arquivo)
        {
            string json = JsonSerializer.Serialize(book);
            File.WriteAllText(arquivo, json);

        }

    }
}
