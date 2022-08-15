use SellPointFinal

create table Entidades(
	IdEntidad int primary key identity(1,1),
	Descripcion varchar(120) not null,
	Direccion text not null,
	Localidad varchar(40) not null,
	TipoEntidad varchar(8) not null default 'Jurídica',
	TipoDocumento varchar(9) not null default 'RNC',
	NumeroDocumento bigint not null,
	Telefonos varchar(60) not null,
	URLPaginaWeb varchar(120),
	URLFacebook varchar(120),
	URLInstagram varchar(120),
	URLTwitter varchar(120),
	URLTikTok varchar(120),
	CodigoPostal text ,
	CoordenadasGPS text,
	LimiteCredito decimal(15,2) default 0,
	UserNameEntidad varchar(60) not null,
	PassworEntidad varchar(30) not null,
	RolUserEntidad varchar(10) default 'User',
	Comentario text,
	Status varchar(10) default 'Activa',
	NoEliminable bit default 0,
	FechaRegistro date default getdate()
);


create proc MostrarEntidades 
as 
select * from [SellPointFinal].[dbo].[Entidades]
go




--Insertar un registro a la tabla Entidades


CREATE PROCEDURE InsertarEntidades
@Descripcion AS VARCHAR(120),
@Direccion AS TEXT,
@Localidad AS VARCHAR(40),
@TipoEntidad AS VARCHAR(8),
@TipoDocumento AS VARCHAR(9),
@NumeroDocumento AS bigint,
@Telefonos AS VARCHAR(60),
@URLPaginaWeb AS VARCHAR(120),
@URLFacebook AS VARCHAR(120),
@URLInstagram AS VARCHAR(120),
@URLTwitter AS VARCHAR(120),
@URLTikTok AS VARCHAR(120),
@CodigoPostal AS TEXT,
@CoordenadasGPS AS TEXT,
@LimiteCredito AS DECIMAL(15,2),
@UserNameEntidad AS VARCHAR(60),
@PassworEntidad AS VARCHAR(30),
@RolUserEntidad AS VARCHAR(10),
@Comentario AS TEXT,
@Status AS VARCHAR(10),
@NoEliminable AS BIT
AS
BEGIN
INSERT INTO Entidades (Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento,
	NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,
	URLTikTok,CodigoPostal,CoordenadasGPS,LimiteCredito,UserNameEntidad,PassworEntidad,
	RolUserEntidad,Comentario,Status,NoEliminable)

VALUES (@Descripcion,@Direccion,@Localidad,@TipoEntidad,@TipoDocumento,
	@NumeroDocumento,@Telefonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,
	@URLTikTok,@CodigoPostal,@CoordenadasGPS,@LimiteCredito,@UserNameEntidad,@PassworEntidad,
	@RolUserEntidad,@Comentario,@Status,@NoEliminable)
END
Go


exec InsertarEntidades 
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	1,
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'prueba2',
	'prueba2',
	2.89,
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	'Prueba2',
	1;
create PROCEDURE EditarEntidad
@Descripcion AS VARCHAR(120),
@Direccion AS TEXT,
@Localidad AS VARCHAR(40),
@TipoEntidad AS VARCHAR(8),
@TipoDocumento AS VARCHAR(9),
@NumeroDocumento AS bigint,
@Telefonos AS VARCHAR(60),
@URLPaginaWeb AS VARCHAR(120),
@URLFacebook AS VARCHAR(120),
@URLInstagram AS VARCHAR(120),
@URLTwitter AS VARCHAR(120),
@URLTikTok AS VARCHAR(120),
@CodigoPostal AS TEXT,
@CoordenadasGPS AS TEXT,
@LimiteCredito AS DECIMAL(15,2),
@UserNameEntidad AS VARCHAR(60),
@PassworEntidad AS VARCHAR(30),
@RolUserEntidad AS VARCHAR(10),
@Comentario AS TEXT,
@Status AS VARCHAR(10),
@NoEliminable AS BIT,
@IdEntidad int
	as
	Update Entidades set Descripcion=@Descripcion,Direccion=@Direccion,Localidad=@Localidad,TipoEntidad=@TipoEntidad,TipoDocumento=@TipoDocumento,
	NumeroDocumento=@NumeroDocumento,Telefonos=@Telefonos,URLPaginaWeb=@URLPaginaWeb,URLFacebook=@URLFacebook,URLInstagram=@URLInstagram,
	URLTwitter=@URLTwitter,URLTikTok=@URLTikTok,CodigoPostal=@CodigoPostal,CoordenadasGPS=@CoordenadasGPS,LimiteCredito=@LimiteCredito,
	UserNameEntidad=@UserNameEntidad,PassworEntidad=@PassworEntidad,RolUserEntidad=@RolUserEntidad,Comentario=@Comentario,
	Status=@Status,NoEliminable=@NoEliminable
	where IdEntidad=@IdEntidad
	go
		
	exec EditarEntidad 	
	'Juan Perez',
	'Santo Domingo',
	'Santo Domingo Este',
	'De prueba',
	'RNE',
	004,
	'809-506-0000',
	'Prueba',
	'Prueba',
	'Prueba',
	'Prueba',
	'Prueba',
	'prueba',
	'prueba',
	1.12,
	'Prueba',
	'Prueba',
	'Prueba',
	'Prueba',
	'Prueba',
	3,
	3;
	exec MostrarEntidades
	
	create proc EliminarEntidad
	@idEnt int
	as
	delete from Entidades 
	where IdEntidad=@idEnt
	go

	exec EliminarEntidad 7;