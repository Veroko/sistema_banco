CREATE DATABASE banco
GO
USE banco
GO


CREATE TABLE tar_cordenadas(
	id INT IDENTITY(1,1) PRIMARY KEY,
	serie_a VARCHAR(19),
	serie_b VARCHAR(19),
	serie_c VARCHAR(19),
	serie_d VARCHAR(19),
	serie_e VARCHAR(19),
	serie_f VARCHAR(19),
	serie_g VARCHAR(19),
	serie_h VARCHAR(19),
	serie_i VARCHAR(19),
	serie_j VARCHAR(19)
);



CREATE TABLE usuario(
	id INT IDENTITY(1,1) PRIMARY KEY,
	rut VARCHAR(12),
	nombre VARCHAR(150),
	correo VARCHAR(50),
	direccion VARCHAR(150),
	fono VARCHAR(15),
	clave VARCHAR(10),
	numCuenta int,
	tar_cordenadas INT REFERENCES tar_cordenadas(id)
);


CREATE TABLE tipoCuenta(
	id INT IDENTITY(1,1) PRIMARY KEY,
	tipoCuenta VARCHAR(20)
);

INSERT INTO tipoCuenta VALUES('Cuenta Corriente')
INSERT INTO tipoCuenta VALUES('Cuenta Rut')
INSERT INTO tipoCuenta VALUES('Cuenta de Ahorro')

CREATE TABLE cuenta(
	id INT IDENTITY(1,1) PRIMARY KEY,
	usuario INT REFERENCES usuario(id),
	tipoCuenta INT REFERENCES tipoCuenta(id),
	saldo INT,
	montoMaxGiro INT,
	numCuenta_fk int,
	foreign key(numCuenta_fk) references usuario(id)
);

CREATE TABLE solicitarCredito(
	id INT IDENTITY,
	fecha DATE,
	numCuenta INT,
	monto INT,
	PRIMARY KEY(id),
	FOREIGN KEY(numCuenta) REFERENCES usuario(id)
);


--drop database banco