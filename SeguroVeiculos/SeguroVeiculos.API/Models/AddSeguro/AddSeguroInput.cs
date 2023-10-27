namespace SeguroVeiculos.API.Models.AddSeguro
{
    public class AddSeguroInput
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public int Idade { get; set; } = 0;
        public double ValorVeiculo { get; set; } = 0;
        public string MarcaModeloVeiculo { get; set; } = string.Empty;

    }
}
