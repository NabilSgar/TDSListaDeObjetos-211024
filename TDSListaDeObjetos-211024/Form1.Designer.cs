namespace TDSListaDeObjetos_211024
{
    partial class Form1
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
            txtId = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            txtQtd = new TextBox();
            lblQtd = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 109);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(73, 109);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(73, 143);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(117, 209);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 2;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(73, 209);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(117, 180);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(100, 23);
            txtQtd.TabIndex = 4;
            // 
            // lblQtd
            // 
            lblQtd.AccessibleDescription = "lblQtd";
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(73, 180);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(27, 15);
            lblQtd.TabIndex = 7;
            lblQtd.Text = "Qtd";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(117, 143);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(117, 238);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(100, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(247, 109);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(356, 152);
            dgvProdutos.TabIndex = 9;
            // 
            // Form1
            // 
            AcceptButton = btnAdicionar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 328);
            Controls.Add(dgvProdutos);
            Controls.Add(btnAdicionar);
            Controls.Add(lblQtd);
            Controls.Add(txtNome);
            Controls.Add(lblValor);
            Controls.Add(txtQtd);
            Controls.Add(lblNome);
            Controls.Add(txtValor);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label lblNome;
        private TextBox txtValor;
        private Label lblValor;
        private TextBox txtQtd;
        private Label lblQtd;
        private TextBox txtNome;
        private Button btnAdicionar;
        private DataGridView dgvProdutos;
    }
}