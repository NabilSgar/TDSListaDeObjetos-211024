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
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(67, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 56);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 90);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(67, 156);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 2;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(23, 156);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(67, 127);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(100, 23);
            txtQtd.TabIndex = 4;
            // 
            // lblQtd
            // 
            lblQtd.AccessibleDescription = "lblQtd";
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(23, 127);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(27, 15);
            lblQtd.TabIndex = 7;
            lblQtd.Text = "Qtd";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(67, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(67, 185);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(100, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { id, nome, quantidade, valor, btnEditar, btnDelete });
            dgvProdutos.Location = new Point(173, 56);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(502, 152);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Identificador";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor";
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 60;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Excluir";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Excluir";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 60;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(67, 214);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(100, 23);
            btnApagar.TabIndex = 10;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdicionar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 269);
            Controls.Add(btnApagar);
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
        private Button btnApagar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnDelete;
    }
}