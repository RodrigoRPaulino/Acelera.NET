
using ControlLivraria.Domain;

namespace ControlLivraria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            Btn_Pesquisar = new Button();
            Tb_Pesquisar = new TextBox();
            Dados = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnAdicionar = new Button();
            txbSenha = new TextBox();
            label3 = new Label();
            txbLogin = new TextBox();
            label2 = new Label();
            txbNome = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            txb_Valor = new TextBox();
            txb_Pgs = new TextBox();
            label9 = new Label();
            btn_ImportCSV = new Button();
            btn_ExportJSON = new Button();
            btn_ExportarArquivo = new Button();
            btn_AddLivro = new Button();
            label5 = new Label();
            txb_Cod = new TextBox();
            label7 = new Label();
            txb_Livro = new TextBox();
            label8 = new Label();
            groupBox5 = new GroupBox();
            Dgv_ListaLivros = new DataGridView();
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label6 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_ListaLivros).BeginInit();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(655, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUsuarios);
            groupBox2.Location = new Point(6, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 285);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Login, Senha });
            dgvUsuarios.Location = new Point(-1, 48);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(628, 247);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Login
            // 
            Login.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Login";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.MinimumWidth = 6;
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            Senha.Visible = false;
            Senha.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_Pesquisar);
            groupBox1.Controls.Add(Tb_Pesquisar);
            groupBox1.Controls.Add(Dados);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txbSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Btn_Pesquisar
            // 
            Btn_Pesquisar.Location = new Point(174, 80);
            Btn_Pesquisar.Name = "Btn_Pesquisar";
            Btn_Pesquisar.Size = new Size(111, 23);
            Btn_Pesquisar.TabIndex = 12;
            Btn_Pesquisar.Text = "Pesquisar";
            Btn_Pesquisar.UseVisualStyleBackColor = true;
            Btn_Pesquisar.Click += Btn_Pesquisar_Click;
            // 
            // Tb_Pesquisar
            // 
            Tb_Pesquisar.Location = new Point(52, 80);
            Tb_Pesquisar.Name = "Tb_Pesquisar";
            Tb_Pesquisar.Size = new Size(93, 23);
            Tb_Pesquisar.TabIndex = 11;
            // 
            // Dados
            // 
            Dados.AutoSize = true;
            Dados.Location = new Point(6, 83);
            Dados.Name = "Dados";
            Dados.Size = new Size(40, 15);
            Dados.TabIndex = 10;
            Dados.Text = "Dados";
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Image = Properties.Resources.import_csv_32px;
            button3.Location = new Point(549, 19);
            button3.Name = "button3";
            button3.Size = new Size(78, 62);
            button3.TabIndex = 9;
            button3.Text = "Imp. CSV";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Image = Properties.Resources.json_download_32px;
            button2.Location = new Point(468, 19);
            button2.Name = "button2";
            button2.Size = new Size(85, 62);
            button2.TabIndex = 8;
            button2.Text = "Exp. JSON";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Image = Properties.Resources.export_csv_32px;
            button1.Location = new Point(387, 19);
            button1.Name = "button1";
            button1.Size = new Size(76, 62);
            button1.TabIndex = 7;
            button1.Text = "Exp. CSV";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = true;
            btnAdicionar.Image = Properties.Resources.usuario2;
            btnAdicionar.Location = new Point(306, 19);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(83, 62);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(199, 48);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(96, 23);
            txbSenha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 51);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(49, 48);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(96, 23);
            txbLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(49, 19);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(246, 23);
            txbNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(655, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Livros";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txb_Valor);
            groupBox6.Controls.Add(txb_Pgs);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(btn_ImportCSV);
            groupBox6.Controls.Add(btn_ExportJSON);
            groupBox6.Controls.Add(btn_ExportarArquivo);
            groupBox6.Controls.Add(btn_AddLivro);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(txb_Cod);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(txb_Livro);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(9, 9);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(640, 85);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            // 
            // txb_Valor
            // 
            txb_Valor.Location = new Point(233, 48);
            txb_Valor.Name = "txb_Valor";
            txb_Valor.Size = new Size(62, 23);
            txb_Valor.TabIndex = 13;
            txb_Valor.TextChanged += txb_Valor_TextChanged;
            // 
            // txb_Pgs
            // 
            txb_Pgs.Location = new Point(149, 48);
            txb_Pgs.Name = "txb_Pgs";
            txb_Pgs.Size = new Size(39, 23);
            txb_Pgs.TabIndex = 12;
            txb_Pgs.TextChanged += txb_Pgs_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(194, 51);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 10;
            label9.Text = "Valor";
            // 
            // btn_ImportCSV
            // 
            btn_ImportCSV.AutoSize = true;
            btn_ImportCSV.Image = Properties.Resources.import_csv_32px;
            btn_ImportCSV.Location = new Point(549, 19);
            btn_ImportCSV.Name = "btn_ImportCSV";
            btn_ImportCSV.Size = new Size(78, 62);
            btn_ImportCSV.TabIndex = 9;
            btn_ImportCSV.Text = "Imp. CSV";
            btn_ImportCSV.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ImportCSV.UseVisualStyleBackColor = true;
            // 
            // btn_ExportJSON
            // 
            btn_ExportJSON.AutoSize = true;
            btn_ExportJSON.Image = Properties.Resources.json_download_32px;
            btn_ExportJSON.Location = new Point(468, 19);
            btn_ExportJSON.Name = "btn_ExportJSON";
            btn_ExportJSON.Size = new Size(85, 62);
            btn_ExportJSON.TabIndex = 8;
            btn_ExportJSON.Text = "Exp. JSON";
            btn_ExportJSON.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ExportJSON.UseVisualStyleBackColor = true;
            btn_ExportJSON.Click += btn_ExportJSON_Click;
            // 
            // btn_ExportarArquivo
            // 
            btn_ExportarArquivo.AutoSize = true;
            btn_ExportarArquivo.Image = Properties.Resources.export_csv_32px;
            btn_ExportarArquivo.Location = new Point(387, 19);
            btn_ExportarArquivo.Name = "btn_ExportarArquivo";
            btn_ExportarArquivo.Size = new Size(76, 62);
            btn_ExportarArquivo.TabIndex = 7;
            btn_ExportarArquivo.Text = "Exp. CSV";
            btn_ExportarArquivo.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ExportarArquivo.UseVisualStyleBackColor = true;
            btn_ExportarArquivo.Click += btn_ExportarArquivo_Click_1;
            // 
            // btn_AddLivro
            // 
            btn_AddLivro.AutoSize = true;
            btn_AddLivro.Image = Properties.Resources.book_32px;
            btn_AddLivro.Location = new Point(306, 19);
            btn_AddLivro.Name = "btn_AddLivro";
            btn_AddLivro.Size = new Size(97, 62);
            btn_AddLivro.TabIndex = 6;
            btn_AddLivro.Text = "Adicionar";
            btn_AddLivro.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_AddLivro.UseVisualStyleBackColor = true;
            btn_AddLivro.Click += btn_AddLivro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 51);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "Pgs";
            // 
            // txb_Cod
            // 
            txb_Cod.Location = new Point(49, 48);
            txb_Cod.Name = "txb_Cod";
            txb_Cod.Size = new Size(62, 23);
            txb_Cod.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 51);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 2;
            label7.Text = "Cód";
            // 
            // txb_Livro
            // 
            txb_Livro.Location = new Point(49, 19);
            txb_Livro.Name = "txb_Livro";
            txb_Livro.Size = new Size(246, 23);
            txb_Livro.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 22);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 0;
            label8.Text = "Livro";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Dgv_ListaLivros);
            groupBox5.Location = new Point(6, 100);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(640, 295);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            // 
            // Dgv_ListaLivros
            // 
            Dgv_ListaLivros.AllowUserToAddRows = false;
            Dgv_ListaLivros.AllowUserToDeleteRows = false;
            Dgv_ListaLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_ListaLivros.Location = new Point(6, 17);
            Dgv_ListaLivros.Name = "Dgv_ListaLivros";
            Dgv_ListaLivros.ReadOnly = true;
            Dgv_ListaLivros.RowHeadersVisible = false;
            Dgv_ListaLivros.RowHeadersWidth = 51;
            Dgv_ListaLivros.RowTemplate.Height = 25;
            Dgv_ListaLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_ListaLivros.Size = new Size(628, 272);
            Dgv_ListaLivros.TabIndex = 0;
            Dgv_ListaLivros.CellContentClick += Dgv_ListaLivros_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(655, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Empréstimos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(3, 97);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(640, 295);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(628, 272);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(3, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(640, 85);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(63, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 23);
            comboBox2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 51);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Livros";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Image = Properties.Resources.import_csv_32px;
            button4.Location = new Point(549, 19);
            button4.Name = "button4";
            button4.Size = new Size(78, 62);
            button4.TabIndex = 9;
            button4.Text = "Imp. CSV";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Image = Properties.Resources.json_download_32px;
            button5.Location = new Point(468, 19);
            button5.Name = "button5";
            button5.Size = new Size(85, 62);
            button5.TabIndex = 8;
            button5.Text = "Exp. JSON";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Image = Properties.Resources.export_csv_32px;
            button6.Location = new Point(387, 19);
            button6.Name = "button6";
            button6.Size = new Size(76, 62);
            button6.TabIndex = 7;
            button6.Text = "Exp. CSV";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Image = Properties.Resources.transfer_s32px;
            button7.Location = new Point(306, 19);
            button7.Name = "button7";
            button7.Size = new Size(83, 62);
            button7.TabIndex = 6;
            button7.Text = "Adicionar";
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 22);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Usuarios";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 446);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Biblioteca";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_ListaLivros).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private TextBox txbSenha;
        private Label label3;
        private TextBox txbLogin;
        private Label label2;
        private TextBox txbNome;
        private Label label1;
        private Button btnAdicionar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Senha;
        private Button button3;
        private Button button2;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label6;
        private GroupBox groupBox6;
        private Label label9;
        private Button btn_ImportCSV;
        private Button btn_ExportJSON;
        private Button btn_ExportarArquivo;
        private Button btn_AddLivro;
        private Label label5;
        private TextBox txb_Cod;
        private Label label7;
        private TextBox txb_Livro;
        private Label label8;
        private GroupBox groupBox5;
        private DataGridView Dgv_ListaLivros;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox txb_Pgs;
        private TextBox txb_Valor;
        private Label Dados;
        private Button Btn_Pesquisar;
        private TextBox Tb_Pesquisar;
    }
}