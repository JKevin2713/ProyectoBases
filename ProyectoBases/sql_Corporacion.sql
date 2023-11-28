USE BD_Corporacion;


--===========================================================================================================================
--INSERT
--===========================================================================================================================


-- Agregar datos a la tabla Planta
INSERT INTO Planta (nombre, conexion) VALUES ('La Romana', 1);

-- Agregar datos a la tabla TipoEmpleado
INSERT INTO TipoEmpleado (nombreTipoEmpleado) VALUES ('Tiempo completo');
INSERT INTO TipoEmpleado (nombreTipoEmpleado) VALUES ('Medio tiempo');

-- Agregar datos a la tabla Departamento
INSERT INTO Departamento (Nombre) VALUES ('Recursos Humanos');
INSERT INTO Departamento (Nombre) VALUES ('Contabilidad');

-- Agregar datos a la tabla CalendarioLaboral
INSERT INTO CalendarioLaboral (Nombre, PagoHora, PagoHoraExtra, PagoHoraDoble, HoraInicio, HoraFinal, tipoPago)
VALUES ('Calendario 1', 10.5, 15, 20, '08:00:00', '17:00:00', 1);

-- Agregar datos a la tabla Empleado
INSERT INTO Empleado (nombre, fecha_ingreso, tipo_empleado_id, id_calendario, departamento, supervisor, planta)
VALUES ('Juan Perez', '2023-01-01', 1, 2, 'Recursos Humanos', 0, 1);

-- Agregar datos a la tabla Planillas
INSERT INTO Planillas (idEmpleado, idPlanta, estado, salarioBruto, salarioNeto, PorcentajeObligaciones)
VALUES (3, 1, 0, 1500, 1200, 20.0);

INSERT INTO Planillas (idEmpleado, idPlanta, estado, salarioBruto, salarioNeto, PorcentajeObligaciones)
VALUES (7, 1, 0, 1500, 1200, 20.0);
-- update de datos planillas

UPDATE Empleado
SET
    horaInicio = 8,  
    horaFinal = 17,  
    fecha_salida = '2023-12-31'  
WHERE
    idEmpleado = 3;  -- Ajusta el valor seg�n el ID del empleado que deseas actualizar

INSERT INTO Empleado (nombre, fecha_ingreso, horaInicio, horaFinal, tipo_empleado_id, id_calendario, departamento, supervisor, planta)
VALUES ('Mar�a L�pez', '2023-02-15', 9, 18, 2, 2, 'Contabilidad', 0, 1);
UPDATE Empleado
SET

    fecha_salida = '2023-12-31'  
WHERE
    idEmpleado = 7;
--===========================================================================================================================
--FUNCIONES PARA APLICACION 
--===========================================================================================================================

-- 1. Funcion usada en corporacion para ver todas las planillas que envia planta a corporacion 
CREATE PROCEDURE VerPlanillas
AS
BEGIN
    SELECT * FROM Planillas;
END;

--2. Funcion usada en corporacion para ver todas las planillas que se encuentran pagas para imprimir luego un comprobante de pago
CREATE PROCEDURE verPlanillasPagas
AS
BEGIN
    SELECT * FROM PagoPlanillas;
END;

-- 3. Funcion usada para verificar el idPlanilla y setea el estado de la planilla, 0 si no esta pago y 1 si esta pago
ALTER PROCEDURE PagarPlanilla
    @idPlanilla INT,
    @fechaPago DATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar si la planilla existe y obtener su estado
        DECLARE @estadoPlanilla BIT;
        SELECT @estadoPlanilla = estado
        FROM Planillas
        WHERE idPlanilla = @idPlanilla;

        IF @estadoPlanilla IS NULL
        BEGIN
            THROW 51001, 'La planilla especificada no existe.', 1;
        END

        IF @estadoPlanilla = 1
        BEGIN
            THROW 51000, 'La planilla ya ha sido pagada y no se puede pagar nuevamente.', 1;
        END

        UPDATE Planillas
        SET estado = 1  -- 1 indica que la planilla ha sido pagada
        WHERE idPlanilla = @idPlanilla;

        --Agrega la info a PagoPlanillas
        INSERT INTO PagoPlanillas (idPlanilla, idEmpleado, fechaPago, Cancelado)
        VALUES (@idPlanilla, (SELECT idEmpleado FROM Planillas WHERE idPlanilla = @idPlanilla), @fechaPago, 'Y');

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;


-- 4. Funcion usada para tomar ls datos del empleado para imprimir el comprobante de pago, verifica si la planilla esta pagada para proceder a imprimir (revisar)
ALTER PROCEDURE VerificarPagoPlanilla
    @idPago INT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM PagoPlanillas
        WHERE idPago = @idPago
          AND Cancelado = 'Y'
    )
    BEGIN
        PRINT 'El pago ya ha sido cancelado.';
    END
    ELSE IF EXISTS (
        SELECT 1
        FROM PagoPlanillas pp
        INNER JOIN Empleado e ON pp.idEmpleado = e.idEmpleado
        WHERE pp.idPago = @idPago
    )
    BEGIN
        -- Obtener datos del empleado asociado al pago
        SELECT 
            e.idEmpleado,
            e.nombre,
            e.fecha_ingreso,
            e.fecha_salida,
            e.horaInicio,
            e.horaFinal,
            e.tipo_empleado_id,
            e.id_calendario,
            e.departamento,
            e.supervisor,
            e.planta
        FROM PagoPlanillas pp
        INNER JOIN Empleado e ON pp.idEmpleado = e.idEmpleado
        WHERE pp.idPago = @idPago;
    END
    ELSE
    BEGIN
        PRINT 'No se encontr�.';
    END
END;

-- 5. Funcion usada para tomar ls datos de departamento y usarla para el combobox de departamento

CREATE PROCEDURE verDepartamentos
AS 
BEGIN
	SELECT Nombre 
	FROM Departamento
END;


-- 6. Funcion usada para tomar ls datos de tipo empleado y usarla para el combobox de cargo

CREATE PROCEDURE verTipoEmpleados
AS 
BEGIN
	SELECT  nombreTipoEmpleado
	FROM TipoEmpleado
END;

-- 7. Funcion usada para insertar datos de empleado a la base de datos

CREATE PROCEDURE InsertarDatosEmpleado
    @nombre VARCHAR(500),
    @fecha_ingreso DATE,
    @fecha_salida DATE,
    @horaInicio INT,
    @horaFinal INT,
    @tipo_empleado_id INT,
    @id_calendario INT,
    @departamento VARCHAR(500),
    @supervisor INT,
    @planta INT
AS
BEGIN
    INSERT INTO Empleado (nombre, fecha_ingreso, fecha_salida, horaInicio, horaFinal, tipo_empleado_id, id_calendario, departamento, supervisor, planta)
    VALUES (@nombre, @fecha_ingreso, @fecha_salida, @horaInicio, @horaFinal, @tipo_empleado_id, @id_calendario, @departamento, @supervisor, @planta);
END;

CREATE PROCEDURE ModificarDatosEmpleado
    @idEmpleado INT,
    @nombre VARCHAR(500),
    @fecha_ingreso DATE,
    @fecha_salida DATE,
    @horaInicio INT,
    @horaFinal INT,
    @tipo_empleado_id INT,
    @id_calendario INT,
    @departamento VARCHAR(500),
    @supervisor INT,
    @planta INT
AS
BEGIN
    UPDATE Empleado
    SET
        nombre = @nombre,
        fecha_ingreso = @fecha_ingreso,
        fecha_salida = @fecha_salida,
        horaInicio = @horaInicio,
        horaFinal = @horaFinal,
        tipo_empleado_id = @tipo_empleado_id,
        id_calendario = @id_calendario,
        departamento = @departamento,
        supervisor = @supervisor,
        planta = @planta
    WHERE idEmpleado = @idEmpleado;
END;



-- 8. Funcion usada para tomar ls datos de calendario y usarla para el combobox de CALENDARIO

CREATE PROCEDURE verCalendarioLaboral
AS 
BEGIN
	SELECT Nombre
	FROM CalendarioLaboral
END;


-- 9. Funcion usada para ver empleados

CREATE PROCEDURE VerEmpleados
AS
BEGIN
    SELECT * FROM Empleado;
END;

CREATE PROCEDURE BorrarEmpleado
    @idEmpleado INT
AS
BEGIN
    DELETE FROM Empleado WHERE  idEmpleado =  @idEmpleado;
END;


-- 10. Funcion usada para ver obtener los datos de la planilla e imprimirlos


CREATE PROCEDURE DatosPagoPlanilla
    @IdPago INT
AS
BEGIN
    BEGIN TRY
        -- Verificar si el ID de pago existe
        IF NOT EXISTS (SELECT 1 FROM pagoplanillas WHERE idpago = @IdPago)
        BEGIN
            -- Si el idpago no existe, lanzar una excepci�n
            THROW 50000, 'Error: El ID de pago especificado no existe.', 1;
        END

        -- Obtener los datos correspondientes al ID de pago
        SELECT
            pp.idpago,
            e.idEmpleado AS [Id Empleado],
            e.nombre AS Empleado,
            e.id_calendario AS [Id calendario],
            cl.Nombre AS Calendario,
            d.Nombre AS Departamento,
            e.fecha_ingreso,
            e.fecha_salida,
            e.horaInicio,
            e.horaFinal,
            p.nombre AS Planta
        FROM pagoplanillas AS pp
            INNER JOIN Empleado AS e ON e.idEmpleado = pp.idEmpleado
            INNER JOIN CalendarioLaboral AS cl ON cl.idCalendario = e.id_calendario
            INNER JOIN TipoEmpleado AS te ON te.idTipo = e.tipo_empleado_id
            INNER JOIN Departamento AS d ON d.Nombre = e.departamento
            INNER JOIN Planta AS p ON p.idPlanta = e.planta
        WHERE pp.idpago = @IdPago;
    END TRY
    BEGIN CATCH
        -- Capturar la excepci�n y devolver un mensaje de error
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;


-- 11. sp para cambiar el constraint de la tablas para que al eliminar un empleado se elimine en cascade
-- Ejemplo para la tabla PagoPlanillas
ALTER TABLE PagoPlanillas
DROP CONSTRAINT FK_idEmpleado_PagoPlanillas;

ALTER TABLE PagoPlanillas
ADD CONSTRAINT FK_idEmpleado_PagoPlanillas
FOREIGN KEY (idEmpleado)
REFERENCES Empleado(idEmpleado)
ON DELETE CASCADE;

-- Ver tipo empleado 
CREATE PROCEDURE verTipoEmpleado
AS
BEGIN
    SELECT
        idTipo,
        nombreTipoEmpleado
    FROM 
        TipoEmpleado;
END;

-- ver calendario (nombre)
CREATE PROCEDURE VerCalendarioPorNombre
    @NombreCalendario NVARCHAR(500)
AS
BEGIN
    SELECT idCalendario
    FROM CalendarioLaboral
    WHERE Nombre = @NombreCalendario;
END;

-- ver planta por nombre
ALTER PROCEDURE VerPlantaPorNombre
    @NombrePlanta NVARCHAR(500)
AS
BEGIN
    SELECT idPlanta
    FROM Planta
    WHERE Nombre = @NombrePlanta;
END;

--===========================================================================================================================
--QUERIES
--===========================================================================================================================

--3. Monto	total	pagado	por	la	empresa	en	salarios	netos	y	obligaciones	en	un	periodo de	tiempo.
CREATE PROCEDURE Q3_MontoTotalPagado
    @FechaInicio DATE,
    @FechaFin DATE
AS
BEGIN
    SELECT SUM(P.salarioNeto + P.PorcentajeObligaciones) AS MontoTotalPagado
    FROM Planillas AS P
    INNER JOIN PagoPlanillas AS PP ON PP.idPlanilla = P.idPlanilla
    WHERE PP.fechaPago BETWEEN @FechaInicio AND @FechaFin;
END;

select * from departamento





select * from Empleado
select * from planta 
select * from CalendarioLaboral

select * from TipoEmpleado


