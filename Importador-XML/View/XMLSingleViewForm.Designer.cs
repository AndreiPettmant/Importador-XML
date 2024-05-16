namespace Importador_XML.View
{
    partial class XMLSingleViewForm
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
            txtNumeroTitulo = new TextBox();
            txtDocumentoCredor = new TextBox();
            txtNomeCredor = new TextBox();
            txtDocumentoApresentante = new TextBox();
            txtProtocolo = new TextBox();
            txtNomeDevedor = new TextBox();
            txtDocumentoDevedor = new TextBox();
            txtNomeApresentante = new TextBox();
            txtValorTitulo = new TextBox();
            txtDataEmissao = new TextBox();
            txtEspecieTitulo = new TextBox();
            txtCodigoCartorio = new TextBox();
            txtDataApresentacao = new TextBox();
            txtValorCustas = new TextBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // txtNumeroTitulo
            // 
            txtNumeroTitulo.Location = new Point(147, 98);
            txtNumeroTitulo.Name = "txtNumeroTitulo";
            txtNumeroTitulo.ReadOnly = true;
            txtNumeroTitulo.Size = new Size(129, 23);
            txtNumeroTitulo.TabIndex = 0;
            // 
            // txtDocumentoCredor
            // 
            txtDocumentoCredor.Location = new Point(147, 70);
            txtDocumentoCredor.Name = "txtDocumentoCredor";
            txtDocumentoCredor.ReadOnly = true;
            txtDocumentoCredor.Size = new Size(129, 23);
            txtDocumentoCredor.TabIndex = 1;
            // 
            // txtNomeCredor
            // 
            txtNomeCredor.Location = new Point(147, 41);
            txtNomeCredor.Name = "txtNomeCredor";
            txtNomeCredor.ReadOnly = true;
            txtNomeCredor.Size = new Size(129, 23);
            txtNomeCredor.TabIndex = 2;
            // 
            // txtDocumentoApresentante
            // 
            txtDocumentoApresentante.Location = new Point(147, 12);
            txtDocumentoApresentante.Name = "txtDocumentoApresentante";
            txtDocumentoApresentante.ReadOnly = true;
            txtDocumentoApresentante.Size = new Size(129, 23);
            txtDocumentoApresentante.TabIndex = 3;
            // 
            // txtProtocolo
            // 
            txtProtocolo.Location = new Point(12, 12);
            txtProtocolo.Name = "txtProtocolo";
            txtProtocolo.ReadOnly = true;
            txtProtocolo.Size = new Size(129, 23);
            txtProtocolo.TabIndex = 7;
            // 
            // txtNomeDevedor
            // 
            txtNomeDevedor.Location = new Point(12, 41);
            txtNomeDevedor.Name = "txtNomeDevedor";
            txtNomeDevedor.ReadOnly = true;
            txtNomeDevedor.Size = new Size(129, 23);
            txtNomeDevedor.TabIndex = 6;
            // 
            // txtDocumentoDevedor
            // 
            txtDocumentoDevedor.Location = new Point(12, 70);
            txtDocumentoDevedor.Name = "txtDocumentoDevedor";
            txtDocumentoDevedor.ReadOnly = true;
            txtDocumentoDevedor.Size = new Size(129, 23);
            txtDocumentoDevedor.TabIndex = 5;
            // 
            // txtNomeApresentante
            // 
            txtNomeApresentante.Location = new Point(12, 99);
            txtNomeApresentante.Name = "txtNomeApresentante";
            txtNomeApresentante.ReadOnly = true;
            txtNomeApresentante.Size = new Size(129, 23);
            txtNomeApresentante.TabIndex = 4;
            // 
            // txtValorTitulo
            // 
            txtValorTitulo.Location = new Point(288, 12);
            txtValorTitulo.Name = "txtValorTitulo";
            txtValorTitulo.ReadOnly = true;
            txtValorTitulo.Size = new Size(129, 23);
            txtValorTitulo.TabIndex = 11;
            // 
            // txtDataEmissao
            // 
            txtDataEmissao.Location = new Point(288, 41);
            txtDataEmissao.Name = "txtDataEmissao";
            txtDataEmissao.ReadOnly = true;
            txtDataEmissao.Size = new Size(129, 23);
            txtDataEmissao.TabIndex = 10;
            // 
            // txtEspecieTitulo
            // 
            txtEspecieTitulo.Location = new Point(288, 70);
            txtEspecieTitulo.Name = "txtEspecieTitulo";
            txtEspecieTitulo.ReadOnly = true;
            txtEspecieTitulo.Size = new Size(129, 23);
            txtEspecieTitulo.TabIndex = 9;
            // 
            // txtCodigoCartorio
            // 
            txtCodigoCartorio.Location = new Point(288, 99);
            txtCodigoCartorio.Name = "txtCodigoCartorio";
            txtCodigoCartorio.ReadOnly = true;
            txtCodigoCartorio.Size = new Size(129, 23);
            txtCodigoCartorio.TabIndex = 8;
            // 
            // txtDataApresentacao
            // 
            txtDataApresentacao.Location = new Point(423, 12);
            txtDataApresentacao.Name = "txtDataApresentacao";
            txtDataApresentacao.ReadOnly = true;
            txtDataApresentacao.Size = new Size(129, 23);
            txtDataApresentacao.TabIndex = 12;
            // 
            // txtValorCustas
            // 
            txtValorCustas.Location = new Point(423, 41);
            txtValorCustas.Name = "txtValorCustas";
            txtValorCustas.ReadOnly = true;
            txtValorCustas.Size = new Size(129, 23);
            txtValorCustas.TabIndex = 13;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(423, 69);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(129, 52);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Ok";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // XMLSingleViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 133);
            Controls.Add(btnFechar);
            Controls.Add(txtValorCustas);
            Controls.Add(txtDataApresentacao);
            Controls.Add(txtValorTitulo);
            Controls.Add(txtDataEmissao);
            Controls.Add(txtEspecieTitulo);
            Controls.Add(txtCodigoCartorio);
            Controls.Add(txtProtocolo);
            Controls.Add(txtNomeDevedor);
            Controls.Add(txtDocumentoDevedor);
            Controls.Add(txtNomeApresentante);
            Controls.Add(txtDocumentoApresentante);
            Controls.Add(txtNomeCredor);
            Controls.Add(txtDocumentoCredor);
            Controls.Add(txtNumeroTitulo);
            Name = "XMLSingleViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XML";
            Load += XMLSingleViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroTitulo;
        private TextBox txtDocumentoCredor;
        private TextBox txtNomeCredor;
        private TextBox txtDocumentoApresentante;
        private TextBox txtProtocolo;
        private TextBox txtNomeDevedor;
        private TextBox txtDocumentoDevedor;
        private TextBox txtNomeApresentante;
        private TextBox txtValorTitulo;
        private TextBox txtDataEmissao;
        private TextBox txtEspecieTitulo;
        private TextBox txtCodigoCartorio;
        private TextBox txtDataApresentacao;
        private TextBox txtValorCustas;
        private Button btnFechar;
    }
}