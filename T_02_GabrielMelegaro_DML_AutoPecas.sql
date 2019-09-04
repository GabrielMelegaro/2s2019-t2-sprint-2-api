use T_AutoPecas

insert into Usuarios(Email, Senha) values ('FornecedorA@gmail.com', 'a12345')
										 ,('FornecedorB@gmail.com', 'b67890')

select * from Usuarios

insert into Fornecedores(CNPJ, RazaoSocial, NomeFantasia, Endereco, IdUsuario) values ('40366173000142', 'AutoPecas SA', 'AutoPecas', 'Rua Joaquim da Silva', 1)
insert into Fornecedores(CNPJ, RazaoSocial, NomeFantasia, Endereco, IdUsuario) values ('77808046000166', 'MotoPecas SA', 'MotoPecas', 'Rua Joaquim dos Santos', 2)

select * from Fornecedores

insert into Pecas (Descricao, Peso, PrecoCusto, PrecoVenda, IdFornecedor) values ('Isto é uma peça para o motor', '7', '200', '400', 4)
insert into Pecas (Descricao, Peso, PrecoCusto, PrecoVenda, IdFornecedor) values ('Isto é uma peça para o parachoque', '4', '170', '340', 3)
insert into Pecas (Descricao, Peso, PrecoCusto, PrecoVenda, IdFornecedor) values ('Isto é uma peça para o farol', '10', '435', '870', 4)
insert into Pecas (Descricao, Peso, PrecoCusto, PrecoVenda, IdFornecedor) values ('Isto é uma peça para a carroceria', '20', '700', '1400', 3)

select * from Pecas 

delete Fornecedores
where IdFornecedor = 1;
