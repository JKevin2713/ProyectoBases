create database BD_Corporacion;
USE BD_Corporacion;

CREATE TABLE Planta(
	idPlanta INT PRIMARY KEY IDENTITY (1,1),
    nombre nvarchar(500),
    conexion bit
);
-- 0 (false)- 1(true)

select * from Planta

INSERT INTO Planta (nombre, conexion) VALUES ('La Romana', 1);

-- TIPO DE PAGO
CREATE TABLE TipoPago (
	idTipo INT PRIMARY KEY IDENTITY(1,1),
    nombre nvarchar(100),
);

select*from TipoPago
INSERT INTO TipoPago (nombre) VALUES ('mensual');
INSERT INTO TipoPago (nombre) VALUES ('quincenal');
INSERT INTO TipoPago (nombre) VALUES ('semanal');

-- CALENDARIO LABORAL
CREATE TABLE CalendarioLaboral (
    idCalendario INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255),
    PagoHora DECIMAL(10,2),
    PagoHoraExtra DECIMAL(10,2),
    PagoHoraDoble DECIMAL(10,2),
    HoraInicio TIME,
    HoraFinal TIME,
    tipoPago int, 
	CONSTRAINT FK_tipoPago_CalendarioLaboral FOREIGN KEY (tipoPago) REFERENCES TipoPago(idTipo)
);


-- TIPO EMPLEADO
CREATE TABLE TipoEmpleado (
    idTipo INT PRIMARY KEY IDENTITY(1,1),
    nombreTipoEmpleado VARCHAR(500),
);

-- CLIENTE
CREATE TABLE Empleado(
    idEmpleado INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(500),
    fecha_ingreso DATE,
    fecha_salida DATE,
	horaInicio INT,
	horaFinal INT,
    tipo_empleado_id INT,
    id_calendario INT,
    departamento VARCHAR(500), 
    supervisor INT,
    planta INT,
    CONSTRAINT FK_tipo_empleado_id_Empleado foreign key (tipo_empleado_id) REFERENCES TipoEmpleado(idTipo),
    CONSTRAINT FK_id_calendario_Empleado foreign key (id_calendario) REFERENCES CalendarioLaboral(idCalendario),
    CONSTRAINT FK_planta_Empleado foreign key (planta) REFERENCES Planta(idPlanta));
    
CREATE TABLE Departamento(
	idDepartamento INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(250),
);

CREATE TABLE Planillas(
	idPlanilla INT PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT,
    idPlanta INT,
    estado bit,
    salarioBruto decimal(10,2),
    salarioNeto decimal(10,2),
    PorcentajeObligaciones decimal(10,2),
    CONSTRAINT FK_idEmpleado_Planillas foreign key (idEmpleado) REFERENCES Empleado(idEmpleado),
    CONSTRAINT FK_idPlanta_Planillas foreign key (idPlanta) REFERENCES Planta(idPlanta)
);
ALTER TABLE Planillas
DROP CONSTRAINT FK_idEmpleado_Planillas;

ALTER TABLE Planillas
ADD CONSTRAINT FK_idEmpleado_Planillas
FOREIGN KEY (idEmpleado)
REFERENCES Empleado(idEmpleado)
ON DELETE CASCADE;

-- Repite este patrón para otras tablas relacionadas, ajustando los nombres y referencias según sea necesario.


CREATE TABLE PagoPlanillas (
    idPago INT PRIMARY KEY IDENTITY(1,1),
    idPlanilla INT,
	idEmpleado INT, 
    fechaPago DATE,
	Cancelado CHAR(1),
	CONSTRAINT CK_PagoPlanillas CHECK(Cancelado='N' OR Cancelado='Y'),
	CONSTRAINT FK_idEmpleado_PagoPlanillas FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
    CONSTRAINT FK_idPlanilla_PagoPlanillas FOREIGN KEY (idPlanilla) REFERENCES Planillas(idPlanilla),
	CONSTRAINT UQ_idPlanilla_PagoPlanillas UNIQUE (idPlanilla)
);
-- Ejemplo para la tabla PagoPlanillas
ALTER TABLE PagoPlanillas
DROP CONSTRAINT FK_idEmpleado_PagoPlanillas;

ALTER TABLE PagoPlanillas
ADD CONSTRAINT FK_idEmpleado_PagoPlanillas
FOREIGN KEY (idEmpleado)
REFERENCES Empleado(idEmpleado)
ON DELETE CASCADE;

-- Repite este patrón para otras tablas relacionadas, ajustando los nombres y referencias según sea necesario.



select * from PagoPlanillas
select * from  Planillas
select * from  Planta
select * from  Empleado
select * from  TipoPago
select * from  TipoEmpleado
select * from  CalendarioLaboral

