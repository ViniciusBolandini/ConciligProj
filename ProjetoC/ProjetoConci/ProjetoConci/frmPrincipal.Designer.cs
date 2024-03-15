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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblValorContratos = new System.Windows.Forms.Label();
            this.lblDiasAtrasados = new System.Windows.Forms.Label();
            this.grdArquivos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolherArquivo
            // 
            this.btnEscolherArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(133)))));
            this.btnEscolherArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherArquivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEscolherArquivo.Location = new System.Drawing.Point(18, 34);
            this.btnEscolherArquivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscolherArquivo.Name = "btnEscolherArquivo";
            this.btnEscolherArquivo.Size = new System.Drawing.Size(208, 37);
            this.btnEscolherArquivo.TabIndex = 0;
            this.btnEscolherArquivo.Text = "Escolher Arquivo";
            this.btnEscolherArquivo.UseVisualStyleBackColor = false;
            this.btnEscolherArquivo.Click += new System.EventHandler(this.btnEscolherArquivo_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(236, 39);
            this.txtCaminho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(728, 29);
            this.txtCaminho.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(133)))));
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportar.Location = new System.Drawing.Point(975, 36);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(207, 37);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // grdGeral
            // 
            this.grdGeral.AllowUserToAddRows = false;
            this.grdGeral.AllowUserToDeleteRows = false;
            this.grdGeral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdGeral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGeral.Location = new System.Drawing.Point(18, 170);
            this.grdGeral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdGeral.Name = "grdGeral";
            this.grdGeral.ReadOnly = true;
            this.grdGeral.RowHeadersVisible = false;
            this.grdGeral.Size = new System.Drawing.Size(633, 519);
            this.grdGeral.TabIndex = 3;
            this.grdGeral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGeral_CellClick);
            this.grdGeral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGeral_CellDoubleClick);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(133)))));
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecarregar.Location = new System.Drawing.Point(18, 123);
            this.btnRecarregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(112, 37);
            this.btnRecarregar.TabIndex = 4;
            this.btnRecarregar.Text = "Atualizar";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(660, 170);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(180, 29);
            this.txtNome.TabIndex = 5;
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(660, 212);
            this.grdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowHeadersVisible = false;
            this.grdCliente.Size = new System.Drawing.Size(522, 242);
            this.grdCliente.TabIndex = 6;
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(850, 170);
            this.txtSoma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.ReadOnly = true;
            this.txtSoma.Size = new System.Drawing.Size(180, 29);
            this.txtSoma.TabIndex = 7;
            // 
            // txtDiasDif
            // 
            this.txtDiasDif.Location = new System.Drawing.Point(1041, 170);
            this.txtDiasDif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiasDif.Name = "txtDiasDif";
            this.txtDiasDif.ReadOnly = true;
            this.txtDiasDif.Size = new System.Drawing.Size(139, 29);
            this.txtDiasDif.TabIndex = 8;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(656, 144);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(56, 21);
            this.lblNomeCliente.TabIndex = 9;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblValorContratos
            // 
            this.lblValorContratos.AutoSize = true;
            this.lblValorContratos.Location = new System.Drawing.Point(846, 144);
            this.lblValorContratos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorContratos.Name = "lblValorContratos";
            this.lblValorContratos.Size = new System.Drawing.Size(182, 21);
            this.lblValorContratos.TabIndex = 10;
            this.lblValorContratos.Text = "Valor total dos contratos:";
            // 
            // lblDiasAtrasados
            // 
            this.lblDiasAtrasados.AutoSize = true;
            this.lblDiasAtrasados.Location = new System.Drawing.Point(1036, 144);
            this.lblDiasAtrasados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasAtrasados.Name = "lblDiasAtrasados";
            this.lblDiasAtrasados.Size = new System.Drawing.Size(103, 21);
            this.lblDiasAtrasados.TabIndex = 11;
            this.lblDiasAtrasados.Text = "Maior Atraso:";
            // 
            // grdArquivos
            // 
            this.grdArquivos.AllowUserToAddRows = false;
            this.grdArquivos.AllowUserToDeleteRows = false;
            this.grdArquivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdArquivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArquivos.Location = new System.Drawing.Point(658, 539);
            this.grdArquivos.Name = "grdArquivos";
            this.grdArquivos.RowHeadersVisible = false;
            this.grdArquivos.Size = new System.Drawing.Size(346, 150);
            this.grdArquivos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Arquivos Importados:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdArquivos);
            this.Controls.Add(this.lblDiasAtrasados);
            this.Controls.Add(this.lblValorContratos);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtDiasDif);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.grdGeral);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnEscolherArquivo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivos)).EndInit();
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
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblValorContratos;
        private System.Windows.Forms.Label lblDiasAtrasados;
        private System.Windows.Forms.DataGridView grdArquivos;
        private System.Windows.Forms.Label label1;
    }
}