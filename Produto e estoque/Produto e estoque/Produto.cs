class Produto
{
    private double Preco;
    private int Estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }

    public string Descricao =>
        $"{Nome} {Marca} - {Preco} - Estoque: {Estoque}";
}

