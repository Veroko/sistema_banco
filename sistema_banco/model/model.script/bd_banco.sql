CREATE DATABASE banco
GO
USE banco
GO

CREATE TABLE usuario(
	id INT IDENTITY(1,1) PRIMARY KEY,
	rut VARCHAR(12),
	nombre VARCHAR(150),
	correo VARCHAR(50),
	direccion VARCHAR(150),
	fono VARCHAR(15),
	clave VARCHAR(10),
);

CREATE TABLE tarjetaTransferencia(
	id INT IDENTITY,
	codigo VARCHAR(250),
	user_fk INT,
	PRIMARY KEY(id),
	FOREIGN KEY(user_fk) REFERENCES usuario(id)
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
	montoMaxGiro INT
);

insert into usuario values();
insert into cuenta values();

CREATE TABLE solicitarCredito(
	id INT IDENTITY,
	fecha DATE,
	numCuenta INT,
	monto INT,
	PRIMARY KEY(id),
	FOREIGN KEY(numCuenta) REFERENCES usuario(id)
);


--drop database banco