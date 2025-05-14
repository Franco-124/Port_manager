CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre_usuario NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    contraseña NVARCHAR(150) NOT NULL,
    rol NVARCHAR(50) CHECK (rol IN ('Administrador', 'Usuario')) NOT NULL DEFAULT 'Usuario'
);

CREATE TABLE Incidencias(
	numero_incidencia INT PRIMARY KEY IDENTITY(1,1),
	serial_buque VARCHAR(20) FOREIGN KEY REFERENCES IngresoBuque(serial_buque),
	tipo_incidencia VARCHAR(50) NOT NULL,
	ubicacion VARCHAR(50) NOT NULL,
	descripcion VARCHAR(100),
	estado VARCHAR(30) NOT NULL DEFAULT 'PENDIENTE',
    nombre_admin VARCHAR(100) NOT NULL,
	id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario)
);


select * from usuarios

CREATE TABLE RegistroLlegadaBuque (
	codigo_registro INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	capacidad FLOAT NOT NULL,
	tipo_carga VARCHAR(30) NOT NULL,
	fecha_llegada DATETIME NOT NULL,
	origen VARCHAR(20) NOT NULL,
	id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario),
	accion VARCHAR(30) NOT NULL,
	serial_buque VARCHAR(20) FOREIGN KEY REFERENCES IngresoBuque(serial_buque),
 
);

CREATE TABLE IngresoBuque ( 
    serial_buque VARCHAR(20) PRIMARY KEY NOT NULL,
    capitan VARCHAR(50) NOT NULL,
    empresa VARCHAR(50) NOT NULL,
    origen VARCHAR(50) NOT NULL,
    fecha_ingreso DATETIME NOT NULL,
    capacidad FLOAT NOT NULL,
    id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario)
    
)


CREATE TABLE Muelle (
	id_muelle VARCHAR(30) NOT NULL PRIMARY KEY,
	capacidad_muelle INT NOT NULL ,
	tipo_muelle VARCHAR(30) NOT NULL,
	estado INT NOT NULL
);


CREATE TABLE muelle_buque (
	codigo_registro INT NOT NULL,
    id_muelle VARCHAR(30) NOT NULL,
    PRIMARY KEY (codigo_registro, id_muelle),
    FOREIGN KEY (codigo_registro) REFERENCES RegistroLlegadaBuque(codigo_registro), 
    FOREIGN KEY (id_muelle) REFERENCES muelle(id_muelle) 
);


--NUEVO
CREATE TABLE Registro_Operacion(
	id_operacion INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	serial_buque VARCHAR(20) FOREIGN KEY REFERENCES IngresoBuque(serial_buque),
	id_muelle VARCHAR(30) FOREIGN KEY REFERENCES Muelle(id_muelle),
	descripcion VARCHAR(150) NOT NULL,
	fecha_operacion DATETIME NOT NULL,
	capacidad FLOAT NOT NULL,
	tipo_carga VARCHAR(30) NOT NULL,
	accion VARCHAR(30) NOT NULL
);

--NUEVO
CREATE PROCEDURE Registro_Incidencia    
    @serial_buque VARCHAR(20), 
    @ubicacion VARCHAR(50),
    @descripcion VARCHAR(100),
    @tipo_incidencia VARCHAR(50), 
    @estado VARCHAR(30),
    @nombre_admin VARCHAR(100),
    @id_usuario INT,
    @resultado INT OUTPUT  
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO Incidencias (
             serial_buque, tipo_incidencia, 
            ubicacion, descripcion, estado, nombre_admin, id_usuario
        )
        VALUES (
             @serial_buque, @tipo_incidencia, 
            @ubicacion, @descripcion, @estado, @nombre_admin, @id_usuario
        );
        
        SET @resultado = 1;  -- Éxito
    END TRY
    BEGIN CATCH
        SET @resultado = 0;  -- Error
    END CATCH
END;


ALTER TABLE RegistroLlegadaBuque
ADD serial_buque VARCHAR(20) FOREIGN KEY REFERENCES IngresoBuque(serial_buque);

CREATE PROCEDURE Registro_llegada_buque    
    @capacidad float, 
    @tipo_carga VARCHAR(30),    
    @fecha_llegada DATETIME, 
    @origen VARCHAR(20),    
    @id_usuario INT,
	@accion VARCHAR(30),
	@serial_buque VARCHAR(20),
    @resultado INT OUTPUT  
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO RegistroLlegadaBuque(
             capacidad, tipo_carga, 
            fecha_llegada, origen, id_usuario, accion, serial_buque
        )
        VALUES (
             @capacidad, @tipo_carga, 
             @fecha_llegada, @origen, @id_usuario,@accion, @serial_buque
        );
        SET @resultado = 1;  -- Éxito
    END TRY
    BEGIN CATCH
        SET @resultado = 0;  -- Error
    END CATCH
END;


CREATE PROCEDURE agregar_usuario
    @nombre NVARCHAR(100), 
    @email NVARCHAR(100),
    @contraseña NVARCHAR(100),
    @rol NVARCHAR(50) = 'Usuario',  
    @resultado INT OUTPUT  
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        
        INSERT INTO usuarios (nombre_usuario, email, contraseña, rol)
        VALUES (@nombre, @email, @contraseña, @rol);
        
        SET @resultado = 1;  -- Éxito
    END TRY
    BEGIN CATCH
        SET @resultado = 0;  -- Error
    END CATCH
END;


DROP PROCEDURE agregar_usuario


CREATE PROCEDURE verificar_login
    @nombre VARCHAR(100),
    @email VARCHAR(250),
    @contraseña VARCHAR(100)
AS 
BEGIN 
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 FROM Usuarios 
        WHERE (email = @email OR nombre_usuario = @nombre) 
        AND contraseña = @contraseña
    )
        SELECT 1;  -- Login exitoso
    ELSE
        SELECT 0;  -- Login fallido
END;




select * from usuarios

DELETE FROM usuarios where id_usuario  = 4


INSERT INTO usuarios(nombre_usuario, email, contraseña)
VALUES ('johan', 'johanfranco1522.com', 2122)

SELECT name, type_desc 
FROM sys.procedures 
WHERE name = 'agregar_usuario';


DECLARE @resultado INT;
EXEC agregar_usuario 'Juan Perez', 'juan@email.com', '1234', @resultado OUTPUT;
SELECT @resultado AS Resultado;


----Procedure para verificar si existen usuarios con el mismo de usuario

CREATE PROCEDURE verificar_nombre_usuario
    @nombre NVARCHAR(100),
    @existe INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM usuarios WHERE nombre_usuario = @nombre)
        SET @existe = 1;
    ELSE
        SET @existe = 0;
END;


SELECT * FROM usuarios


DELETE FROM usuarios WHERE id_usuario= 6;




CREATE PROCEDURE devolver_nombre_usuario  
    @email VARCHAR(200)  
AS  
BEGIN  
    SET NOCOUNT ON;  
      
    SELECT nombre_usuario  
    FROM usuarios  
    WHERE email = @email;  
END;


SELECT * FROM usuarios

truncate table usuarios


CREATE PROCEDURE devolver_rol_current_user
    @nombre VARCHAR(100),
    @contraseña VARCHAR(150),
    @rol VARCHAR(50) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @rol = rol 
    FROM usuarios
    WHERE nombre_usuario = @nombre
      AND contraseña =  @contraseña;
END;


DECLARE @rol_usuario VARCHAR(50);




CREATE PROCEDURE cambiar_contraseña
    @nueva_contraseña NVARCHAR(100),
    @contraseña VARCHAR(100),
    @nombre VARCHAR(150),
    @cambiado INT OUTPUT
AS  
BEGIN  
    SET NOCOUNT ON;  

    UPDATE usuarios 
    SET contraseña = @nueva_contraseña
    WHERE contraseña = @contraseña AND nombre_usuario = @nombre;
    
    SET @cambiado = CASE WHEN @@ROWCOUNT > 0 THEN 1 ELSE 0 END;
END;

CREATE PROCEDURE actualizar_contraseña_temp 
    @Temp_password NVARCHAR(100),
    @User_name NVARCHAR(100),
    @Email NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verifica si el usuario existe
    IF EXISTS (
        SELECT 1 FROM usuarios
        WHERE nombre_usuario = @User_name OR email = @Email
    )
    BEGIN
        -- Actualiza la contraseña con la temporal proporcionada
        UPDATE usuarios
        SET contraseña = @Temp_password
        WHERE nombre_usuario = @User_name OR email = @Email;

        RETURN 0; -- Éxito
    END
    ELSE
    BEGIN
        RETURN 1; -- Usuario no encontrado
    END
END;


CREATE PROCEDURE agregar_buque
    @serial_buque VARCHAR(100), 
    @capitan VARCHAR(100),
    @empresa VARCHAR(100),
    @origen VARCHAR(50),  
	@fecha_ingreso DATETIME,
	@capacidad FLOAT,
	@id_usuario INT,
    @resultado INT OUTPUT 
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        
        INSERT INTO IngresoBuque(serial_buque, capitan, empresa, origen, fecha_ingreso, capacidad, id_usuario)
        VALUES (@serial_buque, @capitan, @empresa, @origen, @fecha_ingreso, @capacidad, @id_usuario);
        
        SET @resultado = 1;  -- Éxito
    END TRY
    BEGIN CATCH
        SET @resultado = 0;  -- Error
    END CATCH
END;

CREATE PROCEDURE devolver_id_usuario
    @nombre VARCHAR(100),
    @contraseña VARCHAR(150),
    @id_usuario int OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @id_usuario = id_usuario 
    FROM usuarios
    WHERE nombre_usuario = @nombre
      AND contraseña =  @contraseña;
END;


--NUEVO PROCEDURE 09/05/2025
CREATE PROCEDURE agregar_operacion_registro
    @serial_buque VARCHAR(20), 
    @id_muelle VARCHAR(30),
    @descripcion VARCHAR(150),
    @fecha_operacion DATETIME, 
    @capacidad FLOAT,
    @tipo_carga VARCHAR(30),
    @accion VARCHAR(30),
    @resultado INT OUTPUT  
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO Registro_Operacion(serial_buque, id_muelle, descripcion, fecha_operacion,
		capacidad, tipo_carga, accion    
        )
        VALUES (
		@serial_buque, @id_muelle, @descripcion, @fecha_operacion,
		@capacidad, @tipo_carga, @accion
            
        );
        
        SET @resultado = 1;  -- Éxito
    END TRY
    BEGIN CATCH
        SET @resultado = 0;  -- Error
    END CATCH
END;

---SCRIPTS DE MUELLE

INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona A', 650, 'Graneleros', 'disponible')
INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona B', 750, 'Petroleros', 'disponible')
INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona C', 600, 'Porta Contenedores', 'disponible')
INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona D', 600, 'Porta Contenedores', 'disponible')
INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona E', 550, 'Vehiculos', 'disponible')
INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona F', 450, 'Frigorificos', 'disponible')
INSERT INTO Muelle(id_muelle, capacidad_muelle, tipo_muelle, estado)  VALUES ('Zona G', 480, 'Carga General', 'disponible')

-------------NEW CHANGE
ALTER TABLE Muelle
ALTER COLUMN estado VARCHAR(30) not null


update Muelle set estado = 'disponible'