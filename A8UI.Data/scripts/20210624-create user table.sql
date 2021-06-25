create table users (
id int primary key identity not null,
email varchar(255) not null unique,
nombre varchar(255) not null,
apellido_paterno varchar(255) not null,
apellido_materno varchar(255) not null,
contrasena varchar(100) not null,
status varchar(2) not null default 'AC'
)
go

select *
  from users;