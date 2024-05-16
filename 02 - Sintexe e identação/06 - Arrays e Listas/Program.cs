int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;   
arrayInteiros[2] = 3;
//arrayInteiros[3] = 4;

for  (int i = 0; i < arrayInteiros.Length; i++){
    Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
}