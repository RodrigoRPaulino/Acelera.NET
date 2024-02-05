using Livraria;

namespace ControlLivraria
{
    public partial class Form1 : Form
    {
        ListaDeUsuarios LUsuarios;
        ListaDeLivros Livros;

        public Form1()
        {
            InitializeComponent();
            Livros = new ListaDeLivros(); // Inicialize o objeto Livros

        }
        public enum TipoCadastro
        {
            // Adicione outros tipos de dados, se necessário
            Usuario,
            Livro
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //IMPLEMENTAR SE CAMPOS VAZIOS
            if (txbNome.Text != String.Empty && txbLogin.Text != String.Empty && txbSenha.Text != String.Empty)
            {
                LUsuarios.AdicionaUsuarios(new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text));
            }


            atualizaDGVUsuarios();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LUsuarios = new ListaDeUsuarios();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarCsv(TipoCadastro.Usuario);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .JSON (.json) | *.json";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                LUsuarios.SalvaLocalJSON(nomeArquivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LUsuarios.CarregaLocal(openFileDialog1.FileName);
            }

            atualizaDGVUsuarios();
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void atualizaDGVUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LUsuarios.GetUsuarios();
            dgvUsuarios.DataSource = bs;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void btn_AddLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txb_Livro.Text) ||
                    string.IsNullOrWhiteSpace(txb_Pgs.Text) ||
                    string.IsNullOrWhiteSpace(txb_Cod.Text) ||
                    string.IsNullOrWhiteSpace(txb_Valor.Text))
                {
                    MessageBox.Show("Preencher todos os campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica se os campos numéricos podem ser convertidos com sucesso
                int paginas;
                double codigo;
                decimal valor;

                if (!int.TryParse(txb_Pgs.Text, out paginas) ||
                    !double.TryParse(txb_Cod.Text, out codigo) ||
                    !decimal.TryParse(txb_Valor.Text, out valor))
                {
                    MessageBox.Show("Por favor, insira valores numéricos válidos para páginas, código e valor.", "Erro de Conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Livros livro = new Livros(txb_Livro.Text, paginas, codigo, valor);
                Livros.CadastraLivro(livro);

                MessageBox.Show("Livro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a lista de livros após o cadastro bem-sucedido
                AtualizarListaDeLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao cadastrar o livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListaDeLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Livros.ListaLivros();
            Dgv_ListaLivros.DataSource = bs;
        }

        private void Dgv_ListaLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ExportarArquivo_Click_1(object sender, EventArgs e)
        {
            ExportarCsv(TipoCadastro.Livro);
        }

        public void ExportarJSON(TipoCadastro tipoDado)
        {
            saveFileDialog1.Filter = "Arquivo .JSON (.json) | *.json";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                Livros.SalvaLocalJSON(nomeArquivo);
            }

        }

        /// <summary>
        /// Método dinamico para exportação de arquivos csv
        /// passado por um Enum
        /// </summary>
        /// <param name="tipoDado"></param>
        /// <exception cref="ArgumentException"></exception>
        public void ExportarCsv(TipoCadastro tipoDado)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                using (StreamWriter writer = new StreamWriter(nomeArquivo))
                {
                    switch (tipoDado)
                    {
                        case TipoCadastro.Usuario:
                            writer.WriteLine("Nome,Login,Senha");
                            foreach (var usuario in LUsuarios.GetUsuarios())
                            {
                                writer.WriteLine($"{usuario.Nome},{usuario.Login},{usuario.Senha}");
                            }
                            MessageBox.Show("Usuário exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case TipoCadastro.Livro:
                            writer.WriteLine("Livro,Paginas,Codigo,Valor");
                            foreach (var livro in Livros.ListaLivros())
                            {
                                writer.WriteLine($"{livro.Livro},{livro.Paginas},{livro.Codigo},{livro.Valor}");
                            }
                            MessageBox.Show("Livro exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;


                        default:
                            throw new ArgumentException("Tipo de dado inválido.");
                    }


                }
            }
        }
       

        private void txb_Pgs_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txb_Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ExportJSON_Click(object sender, EventArgs e)
        {
            ExportarJSON(TipoCadastro.Livro);
        }
    }
}