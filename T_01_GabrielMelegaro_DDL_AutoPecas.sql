create database T_AutoPecas

use T_AutoPecas

create table Usuarios
(
	IdUsuario int primary key identity
	,Email varchar(215) not null
	,Senha varchar(230) not null
)

create table Fornecedores
(
	IdFornecedor int primary key identity
	,CNPJ bigint not null
	,RazaoSocial varchar(260) not null
	,NomeFantasia varchar(430) not null
	,Endereco varchar(235) not null
	,IdUsuario int foreign key references Usuarios(IdUsuario)
)

create table Pecas
(
	IdPeca int primary key identity
	,Descricao varchar(960) not null
	,Peso  int not null 
	,PrecoCusto int not null
	,PrecoVenda int not null
	,IdFornecedor int foreign key references Fornecedores(IdFornecedor)
)
