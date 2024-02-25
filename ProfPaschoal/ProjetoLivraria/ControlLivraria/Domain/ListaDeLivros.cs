using System.Data;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ControlLivraria.Domain
{
    public class ListaDeLivros
    {
        List<Livros> list;

        public ListaDeLivros()
        {
            list = new List<Livros>();
        }

        public void CadastraLivro(Livros livro)
        {
            list.Add(livro);
        }

        public List<Livros> ListaLivros()
        {
            return list;
        }
        public void SalvaLocalJSON(string arquivo)
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(arquivo, json);

        }

    }
}
