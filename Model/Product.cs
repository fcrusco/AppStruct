namespace AppStruct.Model;

public class Product
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public Price ProdutoPreco { get; set; }

    public Product(string nome, int quantidade, Price produtoPreco)
    {
        Nome = nome;
        Quantidade = quantidade;
        ProdutoPreco = produtoPreco;
    }

    public string Display()
    {
        return $"Produto: {Nome} Quantidade: {Quantidade.ToString("N0")} " + ProdutoPreco.Display();
    }
}
