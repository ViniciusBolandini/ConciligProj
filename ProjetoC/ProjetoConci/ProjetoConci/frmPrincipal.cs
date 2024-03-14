using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void btnEscolherArquivo_Click(object sender, EventArgs e)
        {
            // Cria uma instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define as propriedades do OpenFileDialog
            openFileDialog.Title = "Selecione um arquivo";
            openFileDialog.Filter = "Todos os arquivos (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            // Exibe o explorar para permitir que o usuário escolha um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // variavel para guardar o caminho do arquivo
                string caminhoArquivo = openFileDialog.FileName;

                // Armazena o caminho do arquivo 
                txtCaminho.Text = caminhoArquivo;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            clsConexao conexao = new clsConexao();
            if (string.IsNullOrWhiteSpace(txtCaminho.Text))
            {
                MessageBox.Show("escolha um arquivo");
            }
            else
            {
                Console.WriteLine("entrou so else");
                conexao.ImportarTabela(txtCaminho.Text, nomeDoUsuario);
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsConexao conexao = new clsConexao();

            string consultaSql = "SELECT NOME,CPF,NOME_ARQUIVO AS ARQ, USUARIO_IMP AS [IMPORTADO POR] FROM GERAL;";

            grdGeral.DataSource = conexao.BuscaDados(consultaSql);
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            clsConexao conexao = new clsConexao();

            string consultaSql = "SELECT NOME,CPF,NOME_ARQUIVO AS ARQ, USUARIO_IMP AS [IMPORTADO POR] FROM GERAL;";

            grdGeral.DataSource = conexao.BuscaDados(consultaSql);
        }


        

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

                // Obtém os valores das células da linha clicada
                nomeCli = row.Cells["NOME"].Value.ToString();
                cpfCli = row.Cells["CPF"].Value.ToString();
                nomeArq = row.Cells["ARQ"].Value.ToString();
                importadoPor = row.Cells["IMPORTADO POR"].Value.ToString();

                txtNome.Text = nomeCli;

                // importa tabela menor
                clsConexao conexao = new clsConexao();

                string consultaSql = $"SELECT CONTRATO,PRODUTO,VALOR FROM GERAL WHERE NOME = '{nomeCli}' AND CPF = '{cpfCli}';";

                grdCliente.DataSource = conexao.BuscaDados(consultaSql);

                // coloca o valor da soma dos contratos do cliente
                decimal somaD = conexao.PegarSoma(nomeCli, cpfCli);
                txtSoma.Text = somaD.ToString("0.00");

                int diasDif = conexao.PegarDifDias(nomeCli, cpfCli);
                txtDiasDif.Text = diasDif.ToString();

            }




        }
    }
}
