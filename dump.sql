CREATE TABLE Segurado (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(255),
    CPF VARCHAR(11),
    Idade INT
);

CREATE TABLE Veiculo (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    ValorVeiculo DECIMAL(10, 2),
    MarcaModeloVeiculo VARCHAR(255)
);

CREATE TABLE SeguroVeiculo (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    SeguradoId INT,
    VeiculoId INT,
    ValorSeguro DECIMAL(10, 2),
    FOREIGN KEY (SeguradoId) REFERENCES Segurado(Id),
    FOREIGN KEY (VeiculoId) REFERENCES Veiculo(Id)
);

CREATE TABLE SeguroVeiculo (
    Nome VARCHAR(255),
    CPF VARCHAR(11),
    ValorVeiculo DECIMAL(10, 2),
    MarcaModeloVeiculo VARCHAR(255)
ValorSeguro DECIMAL(10, 2)
);


===

CREATE TABLE SeguroVeiculo (
 Id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(255),
    CPF VARCHAR(11),
    ValorVeiculo DECIMAL(10, 2),
    MarcaModeloVeiculo VARCHAR(255),
ValorSeguro DECIMAL(10, 2)
);