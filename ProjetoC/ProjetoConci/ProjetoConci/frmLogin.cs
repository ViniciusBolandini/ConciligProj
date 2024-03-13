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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        //evento de click no botao  de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //instancia uma conexao
            clsConexao conexao = new clsConexao();

            //verifica se o usuario existe
            bool resulte = conexao.Login(txtNome.Text, txtSenha.Text);
            if (resulte)
            {
                int usuarioId = conexao.PegarID(txtNome.Text, txtSenha.Text);

                frmPrincipal frmPrincipal = new frmPrincipal();

                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("usuario ou senha incorreta");
            }
        }


        //evento de click no botao de mostrar a senha
        private void chkMostraSenha_Click(object sender, EventArgs e)
        {
            if (chkMostraSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        //evento de click no botao de cadastrar 
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }
    }
}
