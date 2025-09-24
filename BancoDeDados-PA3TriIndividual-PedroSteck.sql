CREATE DATABASE sistema_financeiro;
USE sistema_financeiro;

CREATE TABLE Produto (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    tipo ENUM('Produto', 'Serviço'),
    preco DECIMAL(65,2) NOT NULL,
    quantidade_estoque INT NOT NULL
);

create TABLE Funcionario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cargo ENUM('Funcionário', 'Administrador'),
    salario DECIMAL(65,2),
    senha VARCHAR(100) NOT NULL
);

CREATE TABLE Financeiro (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_lancamento DATE NOT NULL,
    tipo ENUM('Receita', 'Despesa') NOT NULL,
    valor DECIMAL(65,2) NOT NULL,
    descricao TEXT,
    quantidade INT NOT NULL
);
;

SELECT * from financeiro