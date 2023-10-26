using Dapper;
using Infra.Repository.DbContext;
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
            var query = "INSERT INTO SeguroVeiculo (nome, cpf, valorveiculo, marcamodeloveiculo, valorseguro) VALUES(@nome, @cpf, @valorveiculo, @marcamodeloveiculo, @valorseguro)";

            var parameters = new DynamicParameters();
            parameters.Add("nome", Seguro.Nome, System.Data.DbType.String);
            parameters.Add("cpf", Seguro.CPF, System.Data.DbType.String);
            parameters.Add("valorveiculo", Seguro.ValorVeiculo, System.Data.DbType.Decimal);
            parameters.Add("marcamodeloveiculo", Seguro.MarcaModeloVeiculo, System.Data.DbType.String);
            parameters.Add("valorseguro", Seguro.ValorSeguro, System.Data.DbType.Decimal);


            using var connection = _dbContext.CreateConnection();

            connection.Execute(query, parameters);
        }
    }
}