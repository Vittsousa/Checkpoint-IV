using System;

public class CalculadoraINSS
{
    // Calcula o desconto do INSS com base no salário bruto
    public decimal CalcularINSS(decimal salarioBruto)
    {
        // Exemplo de cálculo simplificado do INSS (baseado em faixas hipotéticas)
        if (salarioBruto <= 1100)
            return salarioBruto * 0.075m;  // Alíquota de 7.5%
        else if (salarioBruto <= 2203.48m)
            return salarioBruto * 0.09m;  // Alíquota de 9%
        else if (salarioBruto <= 3305.22m)
            return salarioBruto * 0.12m;  // Alíquota de 12%
        else
            return salarioBruto * 0.14m;  // Alíquota de 14%
    }
}
