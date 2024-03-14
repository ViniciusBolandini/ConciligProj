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
            clsConexao conexao = new clsConexao();

            bool checa = conexao.ChecarCadastro(txtNome.Text);

            if (txtSenha.Text == txtConfirmaSenha.Text && !string.IsNullOrWhiteSpace(txtNome.Text) && !checa)
            {
                
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
            else if(checa)
            {
                MessageBox.Show("Nome de usuário não disponíve");
            }
            else 
            { 
                MessageBox.Show("Senhas divergentes ou campo não preenchido"); 
            }
            
        }
    }
}
