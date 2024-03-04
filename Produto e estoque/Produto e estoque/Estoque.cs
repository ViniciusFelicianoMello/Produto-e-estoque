class Estoque
{
    private List<Produto> Produtos {  get; set; } = new List<Produto>();
    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque com sucesso");
    }

    public void ExibirProdutos()
    {
        if ( Produtos.Count == 0 )
        {
            Console.WriteLine("Estoque está vazio, por favor, adicione produtos ao estoque");
        } else
        {
            Console.WriteLine("Lista de produtos em estoque:");
            foreach( var produto in Produtos )
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}