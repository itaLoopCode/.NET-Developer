int quantidadeEmEstoque = 3;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine("Quantidade em Estoque " + quantidadeEmEstoque ) ;
Console.WriteLine("Quantidade Compra " + quantidadeCompra);
Console.WriteLine("é possível realizar a venda? " + possivelVenda) ;

if (quantidadeEmEstoque >= quantidadeCompra) {
    Console.WriteLine("Venda realizada");
}else{
    Console.WriteLine("Venda não realizada");
}