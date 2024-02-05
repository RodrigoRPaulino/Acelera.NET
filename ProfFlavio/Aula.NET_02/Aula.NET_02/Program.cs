using Livraria;


int opcao = 0;
List<Livros> biblioteca = new List<Livros>();
List<Usuario> usuarios = new List<Usuario>();
List<Emprestimo> emprestimos = new List<Emprestimo>();


do
{
    MenuPrincipal();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastro de Livro");

            CadastrarLivro();

            break;
        case 2:
            Console.WriteLine("Cadastro de Usuario");
            CadastrarUsuario();
            break;
        case 3:
            Console.WriteLine("Novo Empréstimo");
            NovoEmprestimo();
            break;
        case 4:
            Console.WriteLine("Devolver Empréstimo");
            break;
        case 5:
            Console.WriteLine("Consultar Livros");
            ConsultarLivros();

            break;
        case 6:
            Console.WriteLine("Lista de Usuarios Cadastrados");
            ConsultarUsuarios();
            break;
        case 7:
            SairDoPrograma();
            break;
    }

} while (opcao != 7);


void CadastrarLivro()
{
    Console.Write("Nome do Livro: ");
    string livro = Console.ReadLine();
    Console.Write("Codigo: ");
    double codigo = int.Parse(Console.ReadLine());
    Console.Write("Valor: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    Console.Write("Nº Paginas: ");
    int paginas = int.Parse(Console.ReadLine());

    Livros novoLivro = new Livros(livro, paginas, codigo, valor);

    biblioteca.Add(novoLivro);

    Console.WriteLine($"Livro '{novoLivro.Livro}' cadastrado com sucesso!");
}


void NovoEmprestimo()
{
    Console.Write("Login: ");
    string login = Console.ReadLine();

    Usuario buscado = usuarios.Where(x => x.Login.Equals(login)).FirstOrDefault();

    if (buscado != null)
    {
        Console.WriteLine("Usuario Encontrado...");

        Console.Write("Senha:");
        string senha = Console.ReadLine();

        if (buscado.Senha == senha)
        {

            Console.WriteLine("Usuario Logado!");
            Console.WriteLine("");
            Console.Write("Qual livro você deseja?, digite o nome: ");

            string nomeLivro = Console.ReadLine();

            List<Livros> buscalivro = biblioteca.Where(x => x.Livro.StartsWith(nomeLivro)).ToList();
            if (buscalivro.Count == 0) Console.WriteLine("Livro não encontrado");
            else if (buscalivro.Count == 1)
            {
                Console.WriteLine($"{buscalivro[0].Livro} encontrado!");

                //ADICIONA "REGISTRO" NA LISTA EMPRESTIMOS

                Emprestimo novoEmprestimo = new Emprestimo(buscalivro[0], buscado);

                emprestimos.Add(novoEmprestimo);

            }
            else
            {


                //INFORMAR QUAIS LIVROS ENCONTRADOS COM O NOME
                Console.WriteLine($"{buscalivro.Count} livros encontrados com o nome:");

                foreach (var livroEncontrado in buscalivro)
                {
                    Console.WriteLine($"{livroEncontrado.Livro} (Código: {livroEncontrado.Codigo}, Páginas: {livroEncontrado.Paginas}, Valor: {livroEncontrado.Valor})");
                }


            }


        }
        else Console.WriteLine("Senha Incorreta");
    }
    else Console.WriteLine("Usuario não Encontrado...");




}
void MenuPrincipal()
{
    Console.WriteLine("_________________________");
    Console.WriteLine("O QUE VOCE DESEJA?");

    Console.WriteLine("========CADASTROS========");
    Console.WriteLine("1 - CADASTRAR LIVRO");
    Console.WriteLine("2 - CADASTRAR USUARIO");

    Console.WriteLine("========TRANSAÇÕES=======");
    //necessario
    Console.WriteLine("3 - NOVO EMPRÉSTIMO");
    //não é necessario
    Console.WriteLine("4 - DEVOLVER EMPRÉSTIMO");

    Console.WriteLine("========CONSULTAS========");
    //NECESSÁRIO
    Console.WriteLine("5 - CONSULTAR LIVROS");
    //NECESSÁRIO
    Console.WriteLine("6 - CONSULTAR USUARIO");

    Console.WriteLine("======CONFIGURAÇÕES======");
    Console.WriteLine("7 - SAIR");
    Console.WriteLine("");

    opcao = int.Parse(Console.ReadLine());
}

void CadastrarUsuario()
{


    Console.Write("Nome do Usuario: ");
    string usuario = Console.ReadLine();
    Console.Write("Login: ");
    string login = Console.ReadLine();
    Console.Write("Senha: ");
    string senha = Console.ReadLine();

    Usuario novoUser = new Usuario(usuario, login, senha);

    usuarios.Add(novoUser);

    Console.WriteLine(novoUser.Id);
}

void ConsultarUsuarios()
{
    int i = 0;
    foreach (var usuario in usuarios)
    {
        Console.WriteLine($"Item {i}");
        Console.WriteLine($"Lista de Usuarios disponiveis:\n Id do Usuario: {usuario.Id} \n Login: {usuario.Login}");
        Console.WriteLine("");
        i++;
    }
}

void ConsultarLivros()
{

    int i = 0;
    foreach (var livro in biblioteca)
    {
        Console.WriteLine($"Item {i}");
        Console.WriteLine($"Exibindo Livros disponiveis:\n {livro.Livro} \n Código: {livro.Codigo} \n Páginas: {livro.Paginas} \n Valor: {livro.Valor}");
        Console.WriteLine("");
        i++;
    }

    Console.ReadLine();
}


void SairDoPrograma()
{
    Console.WriteLine("Obrigado por ultilizar o nosso sistema");

    Environment.Exit(0);
}
