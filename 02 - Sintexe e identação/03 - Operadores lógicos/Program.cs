Console.WriteLine("Você é maior de idade? responda com sim ou não");
string idade = Console.ReadLine();

Console.WriteLine("Caso não seja, possui autorização dos seus responsáveis?");
string autorizacao = Console.ReadLine();

if (idade == "sim" || autorizacao == "sim")
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada negada");
}











// bool maiorDeIdade = true;
// bool autorizacaoDosResponsaveis = false;

// Console.WriteLine("Você é maior de idade, responda sim ou não");
// Console.ReadLine();

// Console.WriteLine("Tem autorização dos responsáveis");
