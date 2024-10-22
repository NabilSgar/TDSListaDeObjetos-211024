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

            //Chama o m�todo para carregamento dos produtos
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

            if (produto != null) {
                produtos.Remove(produto);
            }

            CarregaProdutos();
        }
    }
}