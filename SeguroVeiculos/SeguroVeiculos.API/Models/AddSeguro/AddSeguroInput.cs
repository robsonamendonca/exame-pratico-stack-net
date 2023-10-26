namespace SeguroVeiculos.API.Models.AddSeguro
{
    public class AddSeguroInput
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string ValorVeiculo { get; set; } = string.Empty;
        public string MarcaModeloVeiculo { get; set; } = string.Empty;
        public string ValorSeguro { get; set; } = string.Empty;

    }
}
