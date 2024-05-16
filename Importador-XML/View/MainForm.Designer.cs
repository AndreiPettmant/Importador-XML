using System.Windows.Forms;

namespace Importador_XML
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportarXML = new Button();
            btnSelecionarArquivo = new Button();
            txtNomeArquivo = new TextBox();
            dataGridView1 = new DataGridView();
            lblCodigoCartorio = new Label();
            lblDataApresentacao = new Label();
            lblValorCustas = new Label();
            txtCodigoCartorio = new TextBox();
            txtLogo = new Label();
            dtSelecionarData = new DateTimePicker();
            numPorcentagemCustas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPorcentagemCustas).BeginInit();
            SuspendLayout();
            // 
            // btnImportarXML
            // 
            btnImportarXML.Enabled = false;
            btnImportarXML.Location = new Point(640, 378);
            btnImportarXML.Name = "btnImportarXML";
            btnImportarXML.Size = new Size(105, 28);
            btnImportarXML.TabIndex = 0;
            btnImportarXML.Text = "Importar XML";
            btnImportarXML.UseVisualStyleBackColor = true;
            btnImportarXML.Click += btnImportarXml_Click;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.Location = new Point(12, 12);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(141, 59);
            btnSelecionarArquivo.TabIndex = 1;
            btnSelecionarArquivo.Text = "Selecionar Arquivo";
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            btnSelecionarArquivo.Click += btnSelecionarArquivo_Click;
            // 
            // txtNomeArquivo
            // 
            txtNomeArquivo.Location = new Point(12, 77);
            txtNomeArquivo.Name = "txtNomeArquivo";
            txtNomeArquivo.ReadOnly = true;
            txtNomeArquivo.Size = new Size(352, 23);
            txtNomeArquivo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(733, 175);
            dataGridView1.TabIndex = 3;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // lblCodigoCartorio
            // 
            lblCodigoCartorio.AutoSize = true;
            lblCodigoCartorio.Location = new Point(12, 118);
            lblCodigoCartorio.Name = "lblCodigoCartorio";
            lblCodigoCartorio.Size = new Size(112, 15);
            lblCodigoCartorio.TabIndex = 4;
            lblCodigoCartorio.Text = "Código do Cartório:";
            // 
            // lblDataApresentacao
            // 
            lblDataApresentacao.AutoSize = true;
            lblDataApresentacao.Location = new Point(12, 143);
            lblDataApresentacao.Name = "lblDataApresentacao";
            lblDataApresentacao.Size = new Size(125, 15);
            lblDataApresentacao.TabIndex = 5;
            lblDataApresentacao.Text = "Data da Apresentação:";
            // 
            // lblValorCustas
            // 
            lblValorCustas.AutoSize = true;
            lblValorCustas.Location = new Point(12, 168);
            lblValorCustas.Name = "lblValorCustas";
            lblValorCustas.Size = new Size(116, 15);
            lblValorCustas.TabIndex = 6;
            lblValorCustas.Text = "Valor das Custas (%):";
            // 
            // txtCodigoCartorio
            // 
            txtCodigoCartorio.Location = new Point(130, 110);
            txtCodigoCartorio.MaxLength = 7;
            txtCodigoCartorio.Name = "txtCodigoCartorio";
            txtCodigoCartorio.Size = new Size(234, 23);
            txtCodigoCartorio.TabIndex = 7;
            txtCodigoCartorio.Text = "1234567";
            txtCodigoCartorio.TextChanged += txtCodigoCartorio_TextChanged;
            // 
            // txtLogo
            // 
            txtLogo.AutoSize = true;
            txtLogo.Font = new Font("Bahnschrift Condensed", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLogo.Location = new Point(530, 43);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(215, 115);
            txtLogo.TabIndex = 10;
            txtLogo.Text = "Tec21";
            // 
            // dtSelecionarData
            // 
            dtSelecionarData.Format = DateTimePickerFormat.Short;
            dtSelecionarData.Location = new Point(143, 139);
            dtSelecionarData.Name = "dtSelecionarData";
            dtSelecionarData.Size = new Size(185, 23);
            dtSelecionarData.TabIndex = 11;
            // 
            // numPorcentagemCustas
            // 
            numPorcentagemCustas.Location = new Point(143, 166);
            numPorcentagemCustas.Name = "numPorcentagemCustas";
            numPorcentagemCustas.Size = new Size(120, 23);
            numPorcentagemCustas.TabIndex = 12;
            numPorcentagemCustas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numPorcentagemCustas.ValueChanged += numPorcentagemCustas_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 411);
            Controls.Add(numPorcentagemCustas);
            Controls.Add(dtSelecionarData);
            Controls.Add(txtLogo);
            Controls.Add(txtCodigoCartorio);
            Controls.Add(lblValorCustas);
            Controls.Add(lblDataApresentacao);
            Controls.Add(lblCodigoCartorio);
            Controls.Add(dataGridView1);
            Controls.Add(txtNomeArquivo);
            Controls.Add(btnSelecionarArquivo);
            Controls.Add(btnImportarXML);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importador XML";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPorcentagemCustas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImportarXML;
        private Button btnSelecionarArquivo;
        private TextBox txtNomeArquivo;
        private DataGridView dataGridView1;
        private Label lblCodigoCartorio;
        private Label lblDataApresentacao;
        private Label lblValorCustas;
        private Label txtLogo;
        private DateTimePicker dtSelecionarData;
        private NumericUpDown numPorcentagemCustas;
        public TextBox txtCodigoCartorio;
    }
}
