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
        public frmPrincipal()
        {
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
            conexao.ImportarTabela(txtCaminho.Text);
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsConexao conexao = new clsConexao();

            string consultaSql = "SELECT * FROM GERAL;";

            grdGeral.DataSource = conexao.BuscaDados(consultaSql);
        }
    }
}
