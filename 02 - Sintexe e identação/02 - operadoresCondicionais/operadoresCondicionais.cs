int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

Console.WriteLine("Quantidade em Estoque " + quantidadeEmEstoque);
Console.WriteLine("Quantidade Compra " + quantidadeCompra);
Console.WriteLine("é possível realizar a venda? " + possivelVenda);


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Venda não realizada");
}

//Siwtch Case

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();


switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "p":
    Console.WriteLine($"{letra} É uma vogal");
    break;

    default:
    Console.WriteLine($"{letra} Não é uma vogal");
    break;
}


// if (letra == "a" ||
// letra == "e" ||
// letra == "i" ||
// letra == "o" ||
// letra == "u")
// {
//     Console.WriteLine("Vogal");

// }
// else
// {
//     Console.WriteLine("Consoante");
// }

