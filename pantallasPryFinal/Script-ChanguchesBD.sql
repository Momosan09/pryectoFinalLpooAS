drop database if exists changuuu;

create database changuuu;

use changuuu;

create table clientes(
cod_cli int auto_increment,
nombre varchar(60),
dni varchar(8),
tel varchar(10),
primary key (cod_cli)
);

 create table factura(
cod_fac int auto_increment,
tipo varchar(1),/*Factura B*/
primary key (cod_fac)
);

create table sanguche(
cod_lista int auto_increment,
precio varchar(10),
nom_prod varchar(60),
primary key (cod_lista)
);

create table sanguche_cli(
cod_cli int,
cod_lista int,
fecha_pre date,
constraint foreign key (cod_cli) references clientes (cod_cli),
constraint foreign key (cod_lista) references sanguche (cod_lista)
);

create table ingedientes(
cod_ingre int,
cant_ingre int,
unidad_medida varchar(12),
fecha_elab date,
fecha_venc date,
primary key (cod_ingre)
);

create table sanguche_ing(
cod_cli int,
cod_lista int,
nom_prod varchar(50),
constraint foreign key (cod_cli)references clientes(cod_cli),
constraint foreign key (cod_lista)references sanguche(cod_lista)
);


insert into clientes(nombre, dni, tel) values
('Machimo', 46499222, 1161102015),
('Galuchi', 43576890, 1151092000),
('Huelmuchi', 35678914, 1149583937),
('Walter', 19023456, 113229045),
('Flor', 36798222, 114458945),
('Pinola', 44567895, 1134569264),
('Palermo', 23444555, 1197847567);


 insert into factura (tipo) values
('Tipo B'),
('Tipo B'),
('Tipo B'),
('Tipo B'),
('Tipo B'),
('Tipo B'),
('Tipo B');

 insert into sanguche(precio, nom_prod) values
('700', 'La flaqui'),
('1200', 'LA ATOMICA'),
('800', 'Extasis'),
('950', 'Lomi Lomi Morti Morti'),
('790', 'Otra Ronda'),
('850', 'La Gorda'),
('1100', 'El Engorroso');
