CREATE DATABASE DB_ChambaSearch
GO
Use DB_ChambaSearch
GO
CREATE TABLE DB_ChambaSearch.dbo.tipoUsuario (
idtipoUsuario int identity(1,1),
nombreTipoUsuario varchar(45) not null,
constraint pk_idtipoUsuario primary key(idtipoUsuario)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.usuario (
idusuario int identity(1,1),
idtipoUsuario int not null,  --fk
nom_usuario varchar(45) not null,
contraseña varchar(50) not null,
fechaRegistrado datetime,
estado varchar(10) not null, -- hablitado o deshabilitado
constraint pk_idusuario primary key(idusuario),
constraint uq_nom_usuario UNIQUE(nom_usuario)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.documento (
idDocumento int identity(1,1),
descripcion varchar(30) not null,
constraint pk_idDocumento primary key(idDocumento)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.documentoValidacion (
idDocumentoValidacion int identity(1,1),
idpersona  int not null, --fk
idDocumento int not null, --fk
estadoDocumento varchar(8) not null, -- en revision, aprobado, sin revision
constraint pk_idDocumentoValidacion primary key(idDocumentoValidacion)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.departamento (
idDepartamento varchar(2),
nombreDepartamento varchar(25),
constraint pk_idDepartamento primary key(idDepartamento)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.provincia (
idprovincia varchar(5),
idDepartamento varchar(2) not null, --fk
nombreProvincia varchar(25),
constraint pk_idprovincia primary key(idprovincia)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.distrito (
idDistrito varchar(7),
idprovincia varchar(5) not null, --fk
nombreDistrito varchar(45),
constraint pk_idDistrito primary key(idDistrito)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.persona (
idpersona int identity(1,1),
idusuario int not null, --fk
idDistrito varchar(7) not null, --fk
nombres varchar(45) not null,
apePaterno varchar(45) not null,
apeMaterno varchar(45) not null,
fechaNacimiento date not null,
sexo varchar(2) not null, --F(femenino) o M(masculino)
dni varchar(8),
celular varchar(9),
email varchar(45),
imagenPerfil varchar(20),
constraint pk_idpersona primary key(idpersona),
constraint uq_dni UNIQUE(dni)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.imagen (
idimagen int identity(1,1),
ruta varchar(80) not null,
extencion varchar(4),
tamaño int,
constraint pk_idimagen primary key (idimagen),
constraint uq_ruta UNIQUE (ruta)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.comentario (
idcomentario int identity(1,1),
idusuario int not null,
idDetalleServicio int not null, --fk
titulo varchar(20) not null,
contenido varchar(500) not null,
likes decimal(18,0) not null,
dislikes decimal(18,0) not null,
constraint pk_idcomentario primary key (idcomentario)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.detalleServicio (
idDetalleServicio int identity(1,1),
idpersona int not null, --fk
idservicio int not null, --fk
idimagen int, --fk
cantidadcomentario int,
constraint pk_idDetalleServicio primary key(idDetalleServicio)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.tiposervicio (
idtipoServicio int identity(1,1),
nombreTipoServicio varchar(45),
constraint pk_idtipoServicio primary key(idtipoServicio)
)
GO
CREATE TABLE DB_ChambaSearch.dbo.servicio (
idservicio int identity(1,1),
idtipoServicio int not null, --fk
nombreServicio varchar(50),
descripcion varchar(250),
cobroServicio decimal(5,2) not null, --duditativo
constraint pk_idservicio primary key(idservicio)
)
GO
Alter TABLE DB_ChambaSearch.dbo.usuario add constraint fk_usuario_idtipoUsuario 
foreign key (idtipoUsuario) references tipoUsuario(idtipoUsuario)
Alter TABLE DB_ChambaSearch.dbo.persona add constraint fk_persona_idusuario 
foreign key (idusuario) references usuario(idusuario)
Alter TABLE DB_ChambaSearch.dbo.provincia add constraint fk_provincia_idDepartamento 
foreign key (idDepartamento) references departamento(idDepartamento)
Alter TABLE DB_ChambaSearch.dbo.distrito add constraint fk_distrito_idprovincia 
foreign key (idprovincia) references provincia(idprovincia)
Alter TABLE DB_ChambaSearch.dbo.persona add constraint fk_persona_idDistrito 
foreign key (idDistrito) references distrito(idDistrito)
Alter TABLE DB_ChambaSearch.dbo.detalleServicio add constraint fk_detalleServicio_idimagen 
foreign key (idimagen) references imagen(idimagen)
Alter TABLE DB_ChambaSearch.dbo.detalleServicio add constraint fk_detalleServicio_idpersona 
foreign key (idpersona) references persona(idpersona)
Alter TABLE DB_ChambaSearch.dbo.detalleServicio add constraint fk_detalleServicio_idservicio 
foreign key (idservicio) references servicio(idservicio)
Alter TABLE DB_ChambaSearch.dbo.servicio add constraint fk_servicio_idtipoServicio 
foreign key (idtipoServicio) references tipoServicio(idtipoServicio)
Alter TABLE DB_ChambaSearch.dbo.documentoValidacion add constraint fk_documentoValidacion_idpersona 
foreign key (idpersona) references persona(idpersona)
Alter TABLE DB_ChambaSearch.dbo.documentoValidacion add constraint fk_documentoValidacion_idDocumento 
foreign key (idDocumento) references documento(idDocumento)
Alter TABLE DB_ChambaSearch.dbo.comentario add constraint fk_comentario_idusuario 
foreign key (idusuario) references usuario(idusuario)
Alter TABLE DB_ChambaSearch.dbo.comentario add constraint fk_comentario_idDetalleServicio 
foreign key (idDetalleServicio) references detalleServicio(idDetalleServicio)
GO

/*****************************PROCEDIMIENTOS ALMACENADOS***********************************/
CREATE PROCEDURE pd_insertar_servicio(
@idTipoServicio int,@nom_srv varchar(30),
@desc varchar(500),@prec_srv decimal(6,2))
As
Begin
	Insert Into servicio
	Values (@idTipoServicio,@nom_srv,@desc,@prec_srv)
End
GO
/*CREATE PROCEDURE pd_insertar_usuario_normal (
@idusu int,@idDis int,@nombres varchar(50),@apePaterno varchar(50),
@apeMaterno varchar(50),@fechaNac date, @sexo varchar(2))
As
Begin
	Insert Into persona 
	([idusuario],[idDistrito],[nombres],[apePaterno],
	[apeMaterno],[fechaNacimiento],[sexo]) 
	Values(@idusu,@idDis,@nombres,@apePaterno,@apeMaterno,@fechaNac,@sexo)

End*/
CREATE PROCEDURE pd_insertar_usuario_normal (
@tipo_usu int,@nom_usu varchar(45),@password varchar(50),
@idDis int,@nombres varchar(50),@apePaterno varchar(50),
@apeMaterno varchar(50),@fechaNac date, @sexo varchar(2))
AS
BEGIN
    INSERT INTO usuario VALUES(@tipo_usu,@nom_usu,@password,getdate(),'Habilitado')
    
    DECLARE @idusu int

    SELECT @idusu = idusuario FROM usuario
    WHERE nom_usuario = @nom_usu

	INSERT INTO persona 
	([idusuario],[idDistrito],[nombres],[apePaterno],[apeMaterno],[fechaNacimiento],[sexo]) 
	VALUES(@idusu,@idDis,@nombres,@apePaterno,@apeMaterno,@fechaNac,@sexo)
END
GO
/*CREATE PROCEDURE pd_insertar_usuario_maestro (
@idusu int,@idtipoPers int,@idDis int,@image varchar(30),@nombres varchar(50),
@apePaterno varchar(50),@apeMaterno varchar(50),@fechaNac date,@dni varchar(11),
@sexo varchar(2),@celu varchar(8),@email varchar(20))
As
Begin
	Insert Into persona 
		([idusuario],[idDistrito],[nombres],
		[apePaterno],[apeMaterno],[fechaNacimiento],[dni],[sexo],[celular],[email],[imagenPerfil])
	Values
		(@idusu,@idDis,@image,@nombres,@apePaterno,@apeMaterno,
		@fechaNac,@dni,@sexo,@celu,@email)

End*/
GO
alter PROCEDURE pd_insertar_usuario_maestro (
@tipo_usu int,@nom_usu varchar(45),@password varchar(50),@idDis int,
@image varchar(30),@nombres varchar(50),@apePaterno varchar(50),
@apeMaterno varchar(50),@fechaNac date,@dni varchar(11),
@sexo varchar(2),@celu varchar(8),@email varchar(20))
AS
BEGIN
	INSERT INTO usuario VALUES(@tipo_usu,@nom_usu,@password,getdate(),'Habilitado')
    
    DECLARE @idusu int

    SELECT @idusu = idusuario FROM usuario
    WHERE nom_usuario = @nom_usu

	INSERT INTO persona 
		([idusuario],[idDistrito],[nombres],
		[apePaterno],[apeMaterno],[fechaNacimiento],[dni],[sexo],[celular],[email],[imagenPerfil])
	VALUES
		(@idusu,@idDis,@nombres,@apePaterno,@apeMaterno,
		@fechaNac,@dni,@sexo,@celu,@email,@image)

END
GO

/**************************************INSERTS***********************************************/

/*
cerrajero
albañil
carpintero
electricista
fontanero
pintor
limpieza
*/

/*INSERT INTO tipoUsuario VALUES('Administrador')
INSERT INTO tipoUsuario VALUES('Laboral')
INSERT INTO tipoUsuario VALUES('Visitante')*/

--INSERT INTO tiposervicio Values ('pintor')

--SELECT * FROM tipoUsuario

EXECUTE pd_insertar_usuario_maestro 1,'EnriqueEA','123','150117',null,'Enrique','E','A','19-02-2000','63478099','H','87399893','enriqueea@gmail.com'
GO
----------------------------------------------


GO

SELECT d.nombreDepartamento,p.idprovincia,p.nombreProvincia,
di.idDistrito,di.nombreDistrito 
FROM departamento d
INNER JOIN provincia p ON p.idDepartamento=d.idDepartamento
INNER JOIN distrito di ON di.idprovincia=p.idprovincia
WHERE p.nombreProvincia LIKE '%lima%'
GO
SELECT * FROM persona
SELECT * FROM usuario