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

        //Método para voltar a tela de login
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Método para Cadastrar o usuário
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            clsConexao conexao = new clsConexao(); 

            bool checa = conexao.ChecarCadastro(txtNome.Text);

            // Verificando se as senhas sao distintas e se o usuário não existe
            if (txtSenha.Text == txtConfirmaSenha.Text && !string.IsNullOrWhiteSpace(txtNome.Text) && !checa)
            {
                
                bool resulte = conexao.Cadastrar(txtNome.Text, txtSenha.Text); //Cadastra o usuário
                if (resulte)
                {

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar");
                }
            }
            else if(checa)
            {
                MessageBox.Show("Nome de usuário não disponível");
            }
            else 
            { 
                MessageBox.Show("Senhas divergentes ou campo não preenchido"); 
            }
            
        }
    }
}
