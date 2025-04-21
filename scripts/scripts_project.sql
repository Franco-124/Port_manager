

CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre_usuario NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    contraseña NVARCHAR(150) NOT NULL,
    rol NVARCHAR(50) CHECK (rol IN ('Administrador', 'Usuario')) NOT NULL DEFAULT 'Usuario'
);

CREATE TABLE Incidencias(
	numero_incidencia INT PRIMARY KEY IDENTITY(1,1),
	serial_buque VARCHAR(20) FOREIGN KEY REFERENCES RegistroBuque(serial_buque),
	tipo_incidencia VARCHAR(50) NOT NULL,
	ubicacion VARCHAR(50) NOT NULL,
	descripcion VARCHAR(100),
	estado VARCHAR(30) NOT NULL DEFAULT 'PENDIENTE',
	id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario)
);



CREATE TABLE RegistroBuque (
	serial_buque VARCHAR(20) PRIMARY KEY NOT NULL,
	capacidad FLOAT NOT NULL,
	tipo_carga VARCHAR(30) NOT NULL,
	fecha_llegada DATETIME NOT NULL,
	origen VARCHAR(20) NOT NULL,
	id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario),
	codigo_registro INT NOT NULL IDENTITY (1,1),
	accion VARCHAR(30) NOT NULL,

);


CREATE TABLE Muelle (
	id_muelle INT NOT NULL PRIMARY KEY,
	capacidad_muelle INT NOT NULL ,
	tipo_muelle VARCHAR(30) NOT NULL,
	estado INT NOT NULL
);


CREATE TABLE muelle_buque (
	serial_buque VARCHAR(20) NOT NULL,
    id_muelle INT NOT NULL,
    PRIMARY KEY (serial_buque, id_muelle),
    FOREIGN KEY (serial_buque) REFERENCES RegistroBuque(serial_buque), 
    FOREIGN KEY (id_muelle) REFERENCES muelle(id_muelle) 
);


CREATE TABLE carga_descarga (
    id_operacion INT PRIMARY KEY IDENTITY,
    serial_buque VARCHAR(20) NOT NULL,
    id_muelle INT NOT NULL,
    cantidad DECIMAL(10,2) NOT NULL,
    fecha_operacion DATETIME NOT NULL,
    descripcion TEXT,
    FOREIGN KEY (serial_buque) REFERENCES RegistroBuque(serial_buque),
    FOREIGN KEY (id_muelle) REFERENCES muelle(id_muelle)
);




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
