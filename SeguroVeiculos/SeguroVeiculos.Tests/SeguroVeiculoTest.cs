using FluentValidation;
using SeguroVeiculos.Domain.Entities;

namespace SeguroVeiculos.Tests
{
    public class SeguroVeiculoTest
    {
        [Fact(DisplayName ="Dado campos segurado e dados do veiculo, quando informado corretamente, então terá sucesso")]
        public void DadosSeguradoVeiculoComSucesso()
        {

            //arrange           
            const double resultadoEsperado = 270.37;
            const string nome = "Usuario1";
            const string cpf = "11111";
            const int idade = 30;
            const double valorVeiruclo = 10000.00;
            const string marcaModelo = "FIAT - UNO";


            //act
            var seg = new Seguro(nome, cpf,idade, valorVeiruclo,marcaModelo);
            seg.CalcularSeguro();
            var resultadoAtual = seg.ValorSeguro;

            //assert
            Assert.Equal(resultadoEsperado, resultadoAtual);
        }
    }
}