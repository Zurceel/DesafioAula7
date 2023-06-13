string mensagem = "";

try
{
    List<string> listamercado = new List<string>()
    {
        "Tomate",
        "Coca-Cola",
        "Arroz",
        "Feijão",
        "Macarrão",
        "Banana",
        "Agua",
        "Chocolate",
        "Mel"
    };

    string produtosselecionado;

    Console.WriteLine("Digite o produto que gostaria de comprar:");

    produtosselecionado = Console.ReadLine();

    bool validaproduto = listamercado.Where(l => l.Equals(produtosselecionado)).Any();

    if (validaproduto)
    {
        Console.WriteLine("Pode comprar o produto " + produtosselecionado + " pois ele está disponivel");
    }
    else
    {
        Console.WriteLine("O produto " + produtosselecionado + " não está a venda");
    }

    Console.WriteLine("Os produtos disponiveis são:");
    foreach(string produto in listamercado.OrderBy(produto => produto))
    {
        Console.WriteLine(produto);
    }

    mensagem = "Obrigado por ter utilizado o sistema do mercado. Boas compras!";

}catch(Exception e)
{
    mensagem = "Aconteceu o seguinte problema: " + e.Message;
}
finally
{
    Console.WriteLine(mensagem);
}