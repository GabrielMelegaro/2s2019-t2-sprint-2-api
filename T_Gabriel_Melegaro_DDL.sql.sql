create database T_Peoples

use T_Peoples

create table Funcionarios
(
	IdFuncionario int primary key identity
	,Nome varchar(255) not null 
	,Sobrenome varchar(255) not null
);