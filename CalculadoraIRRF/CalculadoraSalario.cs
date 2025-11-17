public class CalculadoraSalario
{
    private CalculadoraINSS _calculadoraINSS;
    private TabelaIRRF _tabelaIRRF;

    public CalculadoraSalario()
    {
        _calculadoraINSS = new CalculadoraINSS();
        _tabelaIRRF = new TabelaIRRF();
    }

    public decimal CalcularDescontoIRRF(Funcionario funcionario)
    {
        decimal salarioBase = funcionario.CalcularSalarioBase(_calculadoraINSS);
        return _tabelaIRRF.CalcularIRRF(salarioBase);
    }
}
