using AppStruct.Model;

List<Product> produtoList = new List<Product>();

// Definir o número de produtos a serem cadastrados
Console.Write("Quantos produtos você deseja cadastrar? ");
int numProducts = int.Parse(Console.ReadLine());

// Loop para cadastrar os produtos
for (int i = 0; i < numProducts; i++)
{
    Console.WriteLine($"\nCadastro do Produto {i + 1}:");

    // Solicitar nome do produto
    Console.Write("Digite o nome do produto: ");
    string produtoNome = Console.ReadLine();

    // Solicitar quantidade do produto
    Console.Write("Digite a quantidade do produto: ");
    int quantidade = int.Parse(Console.ReadLine());

    // Solicitar preço do produto
    Console.Write("Digite o preço do produto: ");
    decimal precoProduto = decimal.Parse(Console.ReadLine());

    // Solicitar moeda
    Console.Write("Digite a moeda (ex: USD, BRL): ");
    string moeda = Console.ReadLine();

    // Criar o preço e o produto
    Price price = new Price(precoProduto, moeda);
    Product produto = new Product(produtoNome, quantidade, price);

    // Adicionar o produto à lista
    produtoList.Add(produto);
}

// Exibir todos os produtos cadastrados
Console.WriteLine("\nProdutos Cadastrados:");

foreach (var prod in produtoList)
    Console.WriteLine(prod.Display());