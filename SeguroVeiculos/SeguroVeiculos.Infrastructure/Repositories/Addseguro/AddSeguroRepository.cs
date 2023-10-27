using Dapper;
using Infra.Repository.DbContext;
using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Domain.Contracts.Repositories.AddSeguro;
using SeguroVeiculos.Domain.Entities;

namespace Infra.Repository.Repositories.AddSeguro
{
    public class AddSeguroRepository : IAddSeguroRepository
    {
        private readonly IDbContext _dbContext;

        public AddSeguroRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddSeguro(Seguro Seguro)
        {
            var cpf = Seguro.CPF.Replace(".","").Replace("-","");

            var query = "INSERT INTO SeguroVeiculo (nome, cpf, valorveiculo, marcamodeloveiculo, valorseguro) VALUES(@nome, @cpf, @valorveiculo, @marcamodeloveiculo, @valorseguro)";

            var parameters = new DynamicParameters();
            parameters.Add("nome", Seguro.Nome, System.Data.DbType.String);
            parameters.Add("cpf", cpf, System.Data.DbType.String);
            parameters.Add("valorveiculo", Seguro.ValorVeiculo, System.Data.DbType.Double);
            parameters.Add("marcamodeloveiculo", Seguro.MarcaModeloVeiculo, System.Data.DbType.String);
            parameters.Add("valorseguro", Seguro.ValorSeguro, System.Data.DbType.Double);


            using var connection = _dbContext.CreateConnection();

            connection.Execute(query, parameters);
        }

        public Seguro CalulcarSeguro(double valorVeiculo)
        {
            var seg = new Seguro("SIMULACAO", "999999999", 99, valorVeiculo, "SIMULACAO_POR_VALOR");
            seg.CalcularSeguro();
            return seg;
        }

        public Relatorio GerarRelatorio()
        {
            var query = $"SELECT \r\n   mediaValorVeiculo.media as mediaValorVeiculo,\r\n   mediaValorSeguro.media as mediaValorSeguro\r\nFROM\r\n\r\n(select sum(ValorVeiculo) ValorVeiculo, count(*) total, ROUND((sum(ValorVeiculo)/count(*)),2) media  from SeguroVeiculo) as mediaValorVeiculo,\r\n(select sum(ValorSeguro) ValorSeguro, count(*) total, ROUND((sum(ValorSeguro)/count(*)),2) media  from SeguroVeiculo) as mediaValorSeguro";

            using var connection = _dbContext.CreateConnection();
            Relatorio relatorio;

            relatorio = connection.Query<Relatorio>(query).FirstOrDefault();
            return relatorio;
        }

        public Seguro PesquisarSeguro(string CPF)
        {
            var pCpf = CPF.Replace(".", "").Replace("-", "");
            var query = $"SELECT Nome, CPF, 0 Idade, ValorVeiculo, MarcaModeloVeiculo, ValorSeguro FROM SeguroVeiculo where CPF = '{pCpf}'";

            using var connection = _dbContext.CreateConnection();
            Seguro seguro = new Seguro();

            seguro = connection.Query<Seguro>(query).FirstOrDefault();
            return seguro;

        }
    }
}