CREATE DATABASE banco;
GO
USE banco;
--DROP DATABASE banco;
GO

CREATE TABLE usuario
(
	id INT PRIMARY KEY IDENTITY(1,1) ,
	rut VARCHAR(12),
	nombre VARCHAR(150),
	correo VARCHAR(50),
	direccion VARCHAR(150),
	fono VARCHAR(15),
	clave VARCHAR(10)
);--SELECT * FROM usuario

INSERT INTO usuario VALUES('19083318-6','mati','asd','asd','+6985','12345');

CREATE TABLE tarjetaTransferencia
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	codigo VARCHAR(250),
	user_fk INT FOREIGN KEY REFERENCES usuario(id)
);--SELECT * FROM tarjetaTransferencia

CREATE TABLE tipoCuenta
(
	id INT PRIMARY KEY IDENTITY(1,1),
	tipoCuenta VARCHAR(20)
);

INSERT INTO tipoCuenta VALUES('Cuenta Corriente'),
('Cuenta Rut'),
('Cuenta de Ahorro');

CREATE TABLE cuenta
(
	id INT PRIMARY KEY IDENTITY(1,1),
	usuario INT REFERENCES usuario(id),
	tipoCuenta INT REFERENCES tipoCuenta(id),
	saldo INT,
	montoMaxGiro VARCHAR(500)
);--select * from cuenta

--INSERT INTO usuario VALUES();
--INSERT INTO cuenta VALUES();

CREATE TABLE solicitarCredito
(
	id INT PRIMARY KEY IDENTITY(1,1),
	fecha DATE,
	numCuenta INT FOREIGN KEY REFERENCES usuario(id),
	monto INT
);


--SELECT COUNT(*) FROM usuario  WHERE rut = '19083318-6' AND clave = '12345'