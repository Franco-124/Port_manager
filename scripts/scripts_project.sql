
CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre_usuario NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    contraseña NVARCHAR(150) NOT NULL,
    rol NVARCHAR(50) CHECK (rol IN ('Administrador', 'Usuario')) NOT NULL DEFAULT 'Usuario'
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

