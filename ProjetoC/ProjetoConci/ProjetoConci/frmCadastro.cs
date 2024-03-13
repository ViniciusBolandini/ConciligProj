using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConci
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmaSenha.Text)
            {
                clsConexao conexao = new clsConexao();
                bool resulte = conexao.Cadastrar(txtNome.Text, txtSenha.Text);
                if (resulte)
                {

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nao foi possivel cadastrar");
                }
            }
            else
            {
                MessageBox.Show("Senhas divergentes");
            }
        }
    }
}
