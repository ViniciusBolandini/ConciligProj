using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoConci
{
    public partial class frmPrincipal : Form
    {
        public string nomeDoUsuario;
        public frmPrincipal(string nomeUsuario)
        {
            nomeDoUsuario = nomeUsuario;
            InitializeComponent();
        }

        //Método para abrir o explorar para escolher o arquivo
        private void btnEscolherArquivo_Click(object sender, EventArgs e)
        {
            // Cria uma instância do OpenFileDialog que é o responsável por abrir o explorar 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define as propriedades do OpenFileDialog
            openFileDialog.Title = "Selecione um arquivo";
            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            // Exibe o explorar para permitir que o usuário escolha um arquivo e verifica se conseguiu escolher
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // variavel para guardar o caminho do arquivo
                string caminhoArquivo = openFileDialog.FileName;

                // Coloca o caminho do arquivo lá no campo do form
                txtCaminho.Text = caminhoArquivo;
            }
        }

        //Método para atualizar o dataGridView genérico e o dataGridView de arquivos importados
        public void AtualizarDataGrid()
        {
            clsConexao conexao = new clsConexao();
            // Comando SQL que vai trazer os dados para o dataGridView genérico
            string consultaSql = "SELECT NOME,CPF,NOME_ARQUIVO AS ARQ, USUARIO_IMP AS [IMPORTADO POR] FROM GERAL;";

            grdGeral.DataSource = conexao.BuscaDados(consultaSql); //chamada do método que aplica o comando no SQL

            txtCaminho.Text = ""; //limpeza da caixa de texto que aparece o caminho do arquivo

            // Comando SQL que vai trazer os dados para o dataGridView dos arquivos importados
            consultaSql = "SELECT DISTINCT NOME_ARQUIVO,USUARIO_IMP AS [IMPORTADO POR] FROM GERAL;";

            grdArquivos.DataSource = conexao.BuscaDados(consultaSql); //chamada do método que aplica o comando no SQL
        }





        //Método para importar o arquivo selecionado para o SQL
        private void btnImportar_Click(object sender, EventArgs e)
        {
            clsConexao conexao = new clsConexao();
            if (string.IsNullOrWhiteSpace(txtCaminho.Text)) // Verifica se realmente temos o caminho do arquivo
            {
                MessageBox.Show("escolha um arquivo");
            }
            else
            {
                conexao.ImportarTabela(txtCaminho.Text, nomeDoUsuario);
            }

            AtualizarDataGrid();
        }
        
        //Método que carrega as informações no dataGridView genérico assim que o formulário principal é aberto
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        //Método para atualizar os dataGrid quando o botão de Atualizar é clicado
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            AtualizarDataGrid();
            Console.WriteLine("Atualizado!");
        }


        
        //Método que leva as informaçoes do cliente que foi clicado para o dataGrid
        //que mostra as informações específicas do cliente
        private void grdGeral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeCli;
            string cpfCli;
            string nomeArq;
            string importadoPor;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtém a linha clicada
                DataGridViewRow row = grdGeral.Rows[e.RowIndex];

                // C os valores das células da linha clicada
                nomeCli = row.Cells["NOME"].Value.ToString();
                cpfCli = row.Cells["CPF"].Value.ToString();
                nomeArq = row.Cells["ARQ"].Value.ToString();
                importadoPor = row.Cells["IMPORTADO POR"].Value.ToString();

                txtNome.Text = nomeCli;

                // mostra os dados específicos no dataGrid do cliente
                clsConexao conexao = new clsConexao();

                string consultaSql = $"SELECT CONTRATO,PRODUTO, REPLACE((FORMAT(VALOR, 'N2')),'.',',') AS VALOR, DATEDIFF(day, VENCIMENTO, GETDATE()) AS [ATRASO EM DIAS] FROM GERAL WHERE NOME = '{nomeCli}' AND CPF = '{cpfCli}';";

                grdCliente.DataSource = conexao.BuscaDados(consultaSql);

                // Obtém o valor da soma dos contratos do cliente
                decimal somaD = conexao.PegarSoma(nomeCli, cpfCli);
                txtSoma.Text = "R$ " + somaD.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));

                // Obtém o valor em dias do contrato mais atrasado
                int diasDif = conexao.PegarDifDias(nomeCli, cpfCli);
                txtDiasDif.Text = diasDif.ToString() + " dias";

            }

        }

        //Método para encerrar o programa quando o Form principal for fechado
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Método para quando uma célula do dataGrid for clicada selecionar a linha toda 
        private void grdGeral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique ocorreu em uma célula válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Muda o modo de seleção 
                grdGeral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Seleciona a linha inteira
                grdGeral.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
