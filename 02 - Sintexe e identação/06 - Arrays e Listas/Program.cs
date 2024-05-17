// int[] arraysInteiros = new int[4];

// arraysInteiros[0] = 1;
// arraysInteiros[1] = 2;
// arraysInteiros[2] = 3;

// int[] arraysInteiros2 = new int[arraysInteiros.Length * 2];
// Array.Copy(arraysInteiros, arraysInteiros2, arraysInteiros.Length);
// Console.WriteLine( arraysInteiros2);

// Array.Resize(ref arraysInteiros, arraysInteiros.Length *2);

// for (int i = 0; i < 3; i++) {
//     Console.WriteLine($"{i} + {arraysInteiros[i]}");
// }

// foreach (int i in arraysInteiros)
// {
//     Console.WriteLine(i);
// }

List<string> ListaString = new List<string>();

ListaString.Add("SP");
ListaString.Add("BA");
ListaString.Add("MG");


Console.WriteLine($"Itens na minha lista: {ListaString.Count} - capacidade {ListaString.Capacity}");

ListaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {ListaString.Count} - capacidade {ListaString.Capacity}");

ListaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {ListaString.Count} - capacidade {ListaString.Capacity}");

ListaString.Add("PR");

// for (int i = 0; i<ListaString.Count;i++){
//     Console.WriteLine($"Posição Nº {i} + {ListaString[i]}");
// }

// Console.WriteLine("Contador FOREACH");
// int contador = 0;
// foreach (string i in ListaString)
// {
//     Console.WriteLine($"Posição Nº {contador} - {i}");
//     contador++;
// }