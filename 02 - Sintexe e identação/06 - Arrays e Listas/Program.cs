int[] arraysInteiros = new int[4];

arraysInteiros[0] = 1;
arraysInteiros[1] = 2;
arraysInteiros[2] = 3;

int[] arraysInteiros2 = new int[arraysInteiros.Length * 2];
Array.Copy(arraysInteiros, arraysInteiros2, arraysInteiros.Length);
Console.WriteLine( arraysInteiros2);

Array.Resize(ref arraysInteiros, arraysInteiros.Length *2);

for (int i = 0; i < 3; i++) {
    Console.WriteLine($"{i} + {arraysInteiros[i]}");
}

foreach (int i in arraysInteiros)
{
    Console.WriteLine(i);
}