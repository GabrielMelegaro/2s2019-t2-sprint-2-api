create database T_Ekips

use T_Ekips

create table Usuario
(
	IdUsuario int primary key identity
	,Email varchar(250) not null 
	,Senha varchar(400) not null
	,Permissao varchar(190) not null 
)
	
create table Departamentos
(
	IdDepartamento int primary key identity
	,Nome varchar(255) not null 
)

create table Cargos
(
	IdCargo int primary key identity
	,Nome varchar(230) not null 
	,Situacao varchar (280) not null 
)

create table Funcionarios
(
	IdFuncionario int primary key identity
	,Nome varchar (240) not null
	,CPF bigint not null 
	,DataNascimento Date not null
	,Salario  money not null
	,IdDepartamento int foreign key references Departamentos(IdDepartamento)
	,IdCargo int foreign key references Cargos (IdCargo)
	,IdUsuario int foreign key references Usuario (IdUsuario)
)