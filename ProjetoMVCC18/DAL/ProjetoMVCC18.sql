CREATE DATABASE ProjetoMVCC18;
USE ProjetoMVCC18;

CREATE TABLE tbl_clienteC18 (
id_cliente int(11) NOT NULL,
nome_cliente VARCHAR(45) NOT NULL,
sobrenome_cliente VARCHAR(45) NOT NULL,
email_cliente VARCHAR(50) NOT NULL,
senha_cliente VARCHAR(45) NOT NULL,
cpf_cliente VARCHAR(11) NOT NULL,
nome_mae VARCHAR(50) NOT NULL,
tp_usuario int(1) default NULL
);

select * from tbl_clienteC18;
INSERT INTO `ProjetoMVCC18`.`tbl_clienteC18` (`id_cliente`, `nome_cliente`,`sobrenome_cliente`,`email_cliente`,`senha_cliente`,
`cpf_cliente`,`nome_mae`,`tp_usuario`) VALUES ('1', 'Lucas','Mendonça','lucas@cotemig.com','123456','11111111111','Valeria','1');
select * from usuario;