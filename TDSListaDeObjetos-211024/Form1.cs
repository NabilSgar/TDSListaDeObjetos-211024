using System.ComponentModel;

namespace TDSListaDeObjetos_211024
{
    public partial class Form1 : Form
    {
        private static List<Produto> produtos = new List<Produto>(); //Criando Lista

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Instanciar classe (Criar um objeto)
            Produto produto = new Produto(); //Classe objeto = new Classe()

            produto.id = Convert.ToInt32(txtId.Text);
            produto.nome = txtNome.Text;
            produto.quantidade = Convert.ToInt32(txtQtd.Text);
            produto.valor = float.Parse(txtValor.Text);

            //adicionar o objeto na lista
            produtos.Add(produto);

            //Carregar os dados no DataGridView
            dgvProdutos.DataSource = produtos;

            txtValor.Clear();
            txtId.Clear();
            txtQtd.Clear();
            txtNome.Clear();

            //Chama o método para carregamento dos produtos
            CarregaProdutos();
        }

        private void CarregaProdutos()
        {
            BindingList<Produto> listaProdutos = new BindingList<Produto>();

            foreach (Produto produto in produtos)
            {
                listaProdutos.Add(produto);
            }

            dgvProdutos.DataSource = listaProdutos;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtId.Text);
            //onde
            Produto produto = produtos.Find(x => x.id == idProduto);//produto => produto.id == id.inputado

            if (produto != null)
            {
                produtos.Remove(produto);
            }

            CarregaProdutos();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)//identifica as propriedades, numeros, celula, posiçã etc
        {
            if (e.RowIndex >=0 && e.ColumnIndex >=0) 
            {  //acima identificamos se o indice da coluna da classe ou seja (e.rowindex >= 0) é maior ou igual a zero
                int id = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["id"].Value);
                string operation = dgvProdutos.Columns[e.ColumnIndex].Name;

                if (operation == "btnDelete")
                {
                    DialogResult = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Confirma exclusão

                    if (DialogResult == DialogResult.Yes) { //se clicar sim então roda o cod de exclusão
                        int idx = produtos.FindIndex(x => x.id == id);
                        produtos.RemoveAt(idx);

                        CarregaProdutos();
                    }
                }

                else if (operation == "btnEditar")
                {
                    //codigo
                }
            }
        }
    }
}