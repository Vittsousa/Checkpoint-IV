public class Funcionario
{
    public decimal SalarioBruto { get; set; }
    
    public Funcionario(decimal salarioBruto)
    {
        SalarioBruto = salarioBruto;
    }

    // Método para calcular o salário base (Salário Bruto - Desconto INSS)
    public decimal CalcularSalarioBase(CalculadoraINSS inss)
    {
        decimal descontoINSS = inss.CalcularINSS(SalarioBruto);
        return SalarioBruto - descontoINSS;
    }
}
