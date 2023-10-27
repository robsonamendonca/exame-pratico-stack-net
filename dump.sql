CREATE TABLE [dbo].[SeguroVeiculo] (
    [Nome]               VARCHAR (255)   NULL,
    [CPF]                VARCHAR (11)    NULL,
	[Idade]              INT(11)         NULL, 
    [ValorVeiculo]       DECIMAL (10, 2) NULL,
    [MarcaModeloVeiculo] VARCHAR (255)   NULL,
    [ValorSeguro]        DECIMAL (10, 2) NULL
);
