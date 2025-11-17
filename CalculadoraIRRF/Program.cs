public class Program
{
    public static void Main()
    {
        decimal salarioBruto = 4000.00m;  // Exemplo de salário bruto
        Funcionario funcionario = new Funcionario(salarioBruto);
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();
        
        // Calcular o IRRF
        decimal descontoIRRF = calculadoraSalario.CalcularDescontoIRRF(funcionario);
        
        // Exibir o resultado
        Console.WriteLine($"Salário Bruto: {salarioBruto:C}");
        Console.WriteLine($"Desconto INSS: {funcionario.CalcularSalarioBase(new CalculadoraINSS()) - salarioBruto:C}");
        Console.WriteLine($"IRRF: {descontoIRRF:C}");
    }
}