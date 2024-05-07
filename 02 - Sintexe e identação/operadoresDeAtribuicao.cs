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
//______________________________________________
//conversão para String

int d = int.MaxValue;
string e = d.ToString();
Console.WriteLine(e);

//cast implícito

int f = 5;
double g = f;
Console.WriteLine(g);

//ordem dos operadores

double h = 4 / 2 + 2;
Console.WriteLine(h);