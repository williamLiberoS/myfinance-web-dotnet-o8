create database myfinance;

use myfinance;

create table planoconta (
id int identity(1,1) not null,
nome varchar(50) not null,
tipo char(1) not null,
primary key (id)
)

create table transacao (
id int identity(1,1) not null,
historico varchar(100) null,
data datetime null,
valor decimal(9, 2),
planocontaid int not null,
primary key (id),
foreign key (planocontaid) references planoconta(id)
);

insert into planoconta(nome, tipo) values ('Combustivel', 'D')
insert into planoconta(nome, tipo) values ('Alimenta��o', 'D')
insert into planoconta(nome, tipo) values ('Sa�de', 'D')
insert into planoconta(nome, tipo) values ('Manunten��o carro', 'D')
insert into planoconta(nome, tipo) values ('Viagens', 'D')
insert into planoconta(nome, tipo) values ('Sal�rio', 'R')
insert into planoconta(nome, tipo) values ('Juros recebidos', 'R')
insert into planoconta(nome, tipo) values ('Cr�ditos de dividendos', 'R')
insert into planoconta(nome, tipo) values ('Restitui��o de IR', 'R')

select * from planoconta

SET DATEFORMAT dmy;
insert into transacao(historico, data, valor, planocontaid) values ('Combustivel Blazer', getdate(), 489, 1)
insert into transacao(historico, data, valor, planocontaid) values ('Almo�o de Domingo', '18-05-2025 12:00', 150, 2)
insert into transacao(historico, data, valor, planocontaid) values ('Pe�as da Blazer', '10-05-2025 03:00', 18000, 4)
insert into transacao(historico, data, valor, planocontaid) values ('Sal�rio', '12-05-2025 10:00', 10000, 6)
insert into transacao(historico, data, valor, planocontaid) values ('ITAUSA', getdate(), 678, 8)

select * from transacao