create table users (
id int primary key identity not null,
email varchar(255) not null unique,
nombre varchar(255) not null,
apellido_paterno varchar(255) not null,
apellido_materno varchar(255) not null,
contrasena varchar(100) not null,
status varchar(2) not null default 'AC'
)

 create table paciente (
 id int primary key identity not null,
 nombre varchar(100) not null,
 apellidopaterno varchar(255) not null,
 apellidomaterno varchar(255) not null,
 fechanaciemiento datetime not null,
 fechaingreso datetime not null default(getdate()),
 status varchar(3) not null default('AC')
 )
 
 
 create table cita (
 id int primary key identity not null,
 idpaciente int not null,
 sintomas varchar(1024) not null,
 status varchar(3) not null default('AC'),
 foreign key (idpaciente) references paciente(id)
 )

