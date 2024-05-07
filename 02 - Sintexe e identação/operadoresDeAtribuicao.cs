//operador de atribuição
int a = 10;
int b = 20;

int c = a + b;

Console.WriteLine(c);

// combinando operadores

c += 5;
Console.WriteLine(c);
c -= 6;
Console.WriteLine(c);

// convertendo tipos de variáveis,cast || casting

a = Convert.ToInt32("5");
Console.WriteLine(a);

b = int.Parse("6");
Console.WriteLine(b);

// Diferença entre Parse e Convert

// convert funcioca com valores null
//parse não converte e fecha o programa para o usuário