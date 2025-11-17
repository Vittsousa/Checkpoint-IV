public class TabelaIRRF
{
    // Método para calcular o IRRF a partir do salário base
    public decimal CalcularIRRF(decimal salarioBase)
    {
        decimal aliquota = 0.075m;   // Alíquota de 7.5% (exemplo)
        decimal deducao = 169.44m;   // Dedução (exemplo)

        // Calcular o IRRF
        decimal irrf = salarioBase * aliquota - deducao;

        // Se o resultado for negativo, o IRRF é 0
        return irrf < 0 ? 0 : irrf;
    }
}