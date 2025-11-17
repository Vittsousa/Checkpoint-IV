public class TabelaIRRF
{
    // Método para calcular o IRRF com base no salário base
    public decimal CalcularIRRF(decimal salarioBase)
    {
        decimal aliquota = 0;
        decimal deducao = 0;

        // Determinar a faixa e aplicar a alíquota e dedução
        if (salarioBase <= 2428.80m)
        {
            // Isento
            return 0;
        }
        else if (salarioBase <= 2826.65m)
        {
            // Alíquota de 7,5%
            aliquota = 0.075m;
            deducao = 182.16m;
        }
        else if (salarioBase <= 3751.05m)
        {
            // Alíquota de 15%
            aliquota = 0.15m;
            deducao = 394.16m;
        }
        else if (salarioBase <= 4664.68m)
        {
            // Alíquota de 22,5%
            aliquota = 0.225m;
            deducao = 675.49m;
        }
        else
        {
            // Alíquota de 27,5%
            aliquota = 0.275m;
            deducao = 908.73m;
        }

        // Calcular IRRF
        decimal irrf = salarioBase * aliquota - deducao;

        // Se o valor for negativo, o IRRF é 0
        return irrf < 0 ? 0 : irrf;
    }
}