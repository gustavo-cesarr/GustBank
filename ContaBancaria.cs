//Aula 1 de Orientação a Objetos com C# - 2026

//Exercício 1 - Conta bancária

using System.Dynamic;
class ContaBancaria
{
    public int NumeroIndicador {get; set;}
    public string Titular {get; set;}
    public double Saldo {get; set;}
    public string Senha {get; set;}

    public ContaBancaria (int numeroIndicador, string titular, double saldo, string senha)
    {
        NumeroIndicador = numeroIndicador;
        Titular = titular;
        Saldo = saldo;
        Senha = senha;

    }
    public void MostrarConta()
    {
        Console.WriteLine($"Número da conta: {NumeroIndicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }

}

