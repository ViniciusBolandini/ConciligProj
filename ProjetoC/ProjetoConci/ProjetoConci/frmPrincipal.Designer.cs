namespace ProjetoConci
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEscolherArquivo = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.grdGeral = new System.Windows.Forms.DataGridView();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.txtDiasDif = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolherArquivo
            // 
            this.btnEscolherArquivo.Location = new System.Drawing.Point(30, 22);
            this.btnEscolherArquivo.Name = "btnEscolherArquivo";
            this.btnEscolherArquivo.Size = new System.Drawing.Size(139, 23);
            this.btnEscolherArquivo.TabIndex = 0;
            this.btnEscolherArquivo.Text = "Escolher Arquivo";
            this.btnEscolherArquivo.UseVisualStyleBackColor = true;
            this.btnEscolherArquivo.Click += new System.EventHandler(this.btnEscolherArquivo_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(188, 25);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(456, 20);
            this.txtCaminho.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(650, 21);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(138, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // grdGeral
            // 
            this.grdGeral.AllowUserToAddRows = false;
            this.grdGeral.AllowUserToDeleteRows = false;
            this.grdGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGeral.Location = new System.Drawing.Point(30, 105);
            this.grdGeral.Name = "grdGeral";
            this.grdGeral.ReadOnly = true;
            this.grdGeral.Size = new System.Drawing.Size(267, 321);
            this.grdGeral.TabIndex = 3;
            this.grdGeral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGeral_CellDoubleClick);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(30, 72);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(75, 23);
            this.btnRecarregar.TabIndex = 4;
            this.btnRecarregar.Text = "Atualizar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(385, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(385, 232);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.Size = new System.Drawing.Size(335, 150);
            this.grdCliente.TabIndex = 6;
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(526, 105);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(100, 20);
            this.txtSoma.TabIndex = 7;
            // 
            // txtDiasDif
            // 
            this.txtDiasDif.Location = new System.Drawing.Point(664, 104);
            this.txtDiasDif.Name = "txtDiasDif";
            this.txtDiasDif.Size = new System.Drawing.Size(100, 20);
            this.txtDiasDif.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiasDif);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.grdGeral);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnEscolherArquivo);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolherArquivo;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView grdGeral;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.TextBox txtDiasDif;
    }
}