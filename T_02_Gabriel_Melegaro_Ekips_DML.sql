use T_Ekips

insert into Usuario (Email, Senha, Permissao) values ('g@gmail.com', 'g23456', 'COMUM')
	                                                ,('f@gmail.com', 'f56789', 'ADMIN')
							,('b@gmail.com', 'b01234', 'COMUM')

select * FROM Usuario

insert into Departamentos (Nome) values ('Departamento Juridico')
insert into Departamentos (Nome) values ('Departamento Tecnológico')
insert into Departamentos (Nome) values ('Departamento Hospitalar')

select * from Departamentos

insert into Cargos(Nome, Situacao) values ('Advogado Trabalhista', 'Ativo')
insert into Cargos(Nome, Situacao) values ('Product Owner', 'Ativo')
insert into Cargos(Nome, Situacao) values ('Enfermagem', 'Nao Ativo')

select * from Cargos

insert into Funcionarios(Nome, CPF, DataNascimento, Salario, IdDepartamento, IdCargo, IdUsuario) values ('Gabriel', '42395302363', '28/03/2003', '1500', '3' , '3', '3')
insert into Funcionarios(Nome, CPF, DataNascimento, Salario, IdDepartamento, IdCargo, IdUsuario) values ('Fernando', '81221368498', '30/09/1976', '3750', '2' , '2', '2')
insert into Funcionarios(Nome, CPF, DataNascimento, Salario, IdDepartamento, IdCargo, IdUsuario) values ('Bob', '84835471812', '12/12/1985 ', '1250', '1' , '1', '1')

select * from Funcionarios

DELETE FROM Funcionarios
WHERE IdFuncionario = 4;
