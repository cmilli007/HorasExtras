
using System;
 
class Program
{
    static void Main()
    {
        Console.Write("Informe o salário-base: ");
        decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
 
        Console.Write("Informe o total de horas trabalhadas: ");
        decimal horasTrabalhadas = Convert.ToDecimal(Console.ReadLine());
 
        Console.Write("Informe o número de horas extras realizadas: ");
        decimal horasExtras = Convert.ToDecimal(Console.ReadLine());
 
        decimal salarioTotal = CalcularSalario(salarioBase, horasTrabalhadas, horasExtras);
 
        Console.WriteLine($"O salário total é: {salarioTotal:C}");
    }
 
    static decimal CalcularSalario(decimal salarioBase, decimal horasTrabalhadas, decimal horasExtras)
    {
        
        decimal salarioHoraExtra = salarioBase * 1.4m;
 
        // Cálculo do salário total
        decimal salarioTotal = (horasTrabalhadas * salarioBase) + (horasExtras * salarioHoraExtra);
 
        return salarioTotal;
    }
}

