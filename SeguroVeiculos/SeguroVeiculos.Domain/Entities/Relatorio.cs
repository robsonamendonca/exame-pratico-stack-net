namespace SeguroVeiculos.API.Models.AddSeguro
{
    public class Relatorio
    {
      
        public double mediaValorVeiculo { get; set; } = 0;
        public double mediaValorSeguro { get; set; } = 0;


        Relatorio() { }
        Relatorio(double mediaValorVeiculo, double mediaValorSeguro)
        {
            this.mediaValorVeiculo = mediaValorVeiculo;
            this.mediaValorSeguro = mediaValorSeguro;
        }

    }
}
