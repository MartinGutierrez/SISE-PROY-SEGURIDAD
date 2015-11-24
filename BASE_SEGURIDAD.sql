USE MASTER
GO
CREATE DATABASE PROY_SISE_SEGURIDAD
GO
USE PROY_SISE_SEGURIDAD
GO
CREATE TABLE USUARIO(
USUARIO_ID INT,
PERSONA_NOMBRES VARCHAR(200),
PERSONA_APELLIDOS VARCHAR(200),
PERSONA_CORREO VARCHAR(300),
USUARIO_USER VARCHAR(20),
USUARIO_PASS VARCHAR(20),
USUARIO_DEFAULT_PASSWORD CHAR(1),
USUARIO_ESTADO CHAR(1)
)
GO
CREATE TABLE PERFIL(
PERFIL_ID INT,
PERFIL_DESCRIPCION VARCHAR(100),
PERFIL_P_RANGO_HORARIO CHAR(1),
PERFIL_P_VIGENCIA VARCHAR(10),
PERFIL_P_RANGO_DIAS CHAR(7),
PERFIL_ESTADO CHAR(1)
)
<<<<<<< HEAD
/*
INSERT INTO PERFIL VALUES(1,'ADMINISTRADOR', '1', '00-00-00','1111111','1')
INSERT INTO PERFIL VALUES(2,'USUARIO', '2', '31-12-15','1111100','1')
SELECT * FROM PERFIL
*/
=======
>>>>>>> 67a7e58c9377b7d3cf57604968625e905460807c
GO
CREATE TABLE APLICACION(
APLICACION_ID CHAR(6),
APLICACION_NOMBRE VARCHAR(50),
APLICACION_DESCRIPCION VARCHAR(100),
APLICACION_PATH VARCHAR(100),
APLICACION_ESTADO CHAR(1)
)
GO
<<<<<<< HEAD
/*
INSERT INTO APLICACION VALUES(1,'INTRANET DOCENTES', 'CAMPUS PARA QUE LOS DOCENTES LLENEN NOTAS ENTRE OTRAS COSAS', './DOCENTES/CAMPUS.ASPX',1)
INSERT INTO APLICACION VALUES(2,'INTRANET ALUMNOS', 'CAMPUS PARA QUE LOS ALUMNOS VEAN SUS NOTAS ENTRE OTRAS COSAS', './ALUMNOS/CAMPUS.ASPX',1)
SELECT * FROM APLICACION
*/
GO
=======
>>>>>>> 67a7e58c9377b7d3cf57604968625e905460807c
CREATE TABLE APLICACION_PERFIL(
APLICACION_PERFIL_ID INT,
PERFIL_ID INT,
APLICACION_ID CHAR(6),
APLICACION_PERFIL_ESTADO CHAR(1)
)
GO
CREATE TABLE USUARIO_APLICACION_PERFIL(
USUARIO_ID INT,
APLICACION_PERFIL_ID INT,
USUARIO_APLICACION_PERFIL_ESTADO CHAR(1)
)
GO
CREATE TABLE MENU(
MENU_ID INT,
PERFIL_ID INT,
MENU_CONTENIDO VARCHAR(50),
MENU_LINK VARCHAR(100)
)
GO
CREATE TABLE SUBMENU_1(
SUBMENU_1_ID INT,
MENU_ID INT,
SUBMENU_1_CONTENIDO VARCHAR(50),
SUBMENU_1_LINK VARCHAR(100)
)
GO
CREATE TABLE SUBMENU_2(
SUBMENU_2_ID INT,
SUBMENU_1_ID INT,
SUBMENU_2_CONTENIDO VARCHAR(50),
SUBMENU_2_LINK VARCHAR(100)
)
<<<<<<< HEAD

-- PROCEDIMIENTO ALMACENADO PARA LISTAR LAS APLICACIONES
CREATE PROCEDURE SP_LISTAR_APLICACION
AS
SELECT * FROM APLICACION

-- PROCEDIMIENTO ALMACENADO PARA LISTAR LOS PERFILES
CREATE PROCEDURE SP_LISTAR_PERFIL
AS
SELECT * FROM PERFIL



=======
>>>>>>> 67a7e58c9377b7d3cf57604968625e905460807c
