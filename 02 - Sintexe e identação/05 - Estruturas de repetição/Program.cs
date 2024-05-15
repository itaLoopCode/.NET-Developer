 int numero = 5;
 int contador = 0;

// Console.WriteLine($"{numero} x 1 = {numero * 1}");


// for (int contador = 0; contador <= 10; contador++){
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// for (int contador = 0; contador <= 10; contador++) {
//     Console.WriteLine($"{contador} + {numero} = {contador + numero}");
// }

//While

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }

// DO While

int soma = 0;


do{
    Console.WriteLine("Digite um numero (zero para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

}while(numero != 0);

Console.WriteLine($"Total da soma dos numero digitáveis é: {soma}");

