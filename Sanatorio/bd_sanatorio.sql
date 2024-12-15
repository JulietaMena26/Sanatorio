-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.14-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para bd_sanatorio
CREATE DATABASE IF NOT EXISTS `bd_sanatorio` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `bd_sanatorio`;

-- Volcando estructura para tabla bd_sanatorio.datosmedicos
CREATE TABLE IF NOT EXISTS `datosmedicos` (
  `idDato` int(11) NOT NULL AUTO_INCREMENT,
  `fechaNac` date DEFAULT NULL,
  `horarioAtencion` varchar(150) DEFAULT '',
  `convenio` varchar(255) DEFAULT '',
  `observacion` varchar(255) DEFAULT '',
  `id_medico` int(11) DEFAULT NULL,
  PRIMARY KEY (`idDato`),
  KEY `FK__medicos` (`id_medico`),
  CONSTRAINT `FK__medicos` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`idMedico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.datosmedicos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_sanatorio.especialidades
CREATE TABLE IF NOT EXISTS `especialidades` (
  `idEspecialidad` int(11) NOT NULL AUTO_INCREMENT,
  `especialidad` varchar(50) NOT NULL DEFAULT '0',
  `descripcion` varchar(255) DEFAULT '0',
  PRIMARY KEY (`idEspecialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.especialidades: ~20 rows (aproximadamente)
INSERT INTO `especialidades` (`idEspecialidad`, `especialidad`, `descripcion`) VALUES
	(1, 'Pediatría', 'Atención médica especializada en niños'),
	(2, 'Odontología', 'Tratamiento de la salud bucal'),
	(3, 'Cardiología', 'Estudio y tratamiento de enfermedades del corazón'),
	(4, 'Ginecología', 'Atención médica de la mujer'),
	(5, 'Traumatología', 'Tratamiento de lesiones y enfermedades del aparato locomotor'),
	(6, 'Neurología', 'Estudio de las enfermedades del sistema nervioso'),
	(7, 'Dermatología', 'Estudio y tratamiento de las enfermedades de la piel'),
	(8, 'Oftalmología', 'Estudio y tratamiento de las enfermedades del ojo'),
	(9, 'Psiquiatría', 'Tratamiento de los trastornos mentales'),
	(10, 'Urología', 'Estudio y tratamiento de las enfermedades del aparato urinario'),
	(11, 'Pediatría', 'Atención médica especializada en niños'),
	(12, 'Odontología', 'Tratamiento de la salud bucal'),
	(13, 'Cardiología', 'Estudio y tratamiento de enfermedades del corazón'),
	(14, 'Ginecología', 'Atención médica de la mujer'),
	(15, 'Traumatología', 'Tratamiento de lesiones y enfermedades del aparato locomotor'),
	(16, 'Neurología', 'Estudio de las enfermedades del sistema nervioso'),
	(17, 'Dermatología', 'Estudio y tratamiento de las enfermedades de la piel'),
	(18, 'Oftalmología', 'Estudio y tratamiento de las enfermedades del ojo'),
	(19, 'Psiquiatría', 'Tratamiento de los trastornos mentales'),
	(20, 'Urología', 'Estudio y tratamiento de las enfermedades del aparato urinario');

-- Volcando estructura para tabla bd_sanatorio.especialidad_medico
CREATE TABLE IF NOT EXISTS `especialidad_medico` (
  `id_` int(11) NOT NULL AUTO_INCREMENT,
  `id_especialidad` int(11) DEFAULT NULL,
  `id_medico` int(11) DEFAULT NULL,
  `matricula` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_`),
  KEY `FK_especialidad_medico_especialidades` (`id_especialidad`),
  KEY `FK_especialidad_medico_medicos` (`id_medico`),
  CONSTRAINT `FK_especialidad_medico_especialidades` FOREIGN KEY (`id_especialidad`) REFERENCES `especialidades` (`idEspecialidad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_especialidad_medico_medicos` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`idMedico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.especialidad_medico: ~13 rows (aproximadamente)
INSERT INTO `especialidad_medico` (`id_`, `id_especialidad`, `id_medico`, `matricula`) VALUES
	(1, 1, 1, 'MED001'),
	(2, 2, 2, 'MED002'),
	(3, 3, 3, 'MED003'),
	(4, 4, 4, 'MED004'),
	(5, 5, 65, 'MED065'),
	(6, 1, 66, 'MED066'),
	(7, 2, 67, 'MED067'),
	(8, 3, 68, 'MED068'),
	(9, 4, 69, 'MED069'),
	(10, 5, 70, 'MED070'),
	(11, 8, 75, '3652'),
	(13, 1, 75, '1234'),
	(14, 7, 77, '1452');

-- Volcando estructura para tabla bd_sanatorio.habitaciones
CREATE TABLE IF NOT EXISTS `habitaciones` (
  `idHabitacion` int(11) NOT NULL AUTO_INCREMENT,
  `numero` varchar(4) NOT NULL DEFAULT '0',
  `id_tipo` int(11) DEFAULT 0,
  `piso` int(11) DEFAULT 0,
  `capacidad` int(11) NOT NULL DEFAULT 0,
  `camaOcupada` int(11) DEFAULT 0,
  `estado` varchar(50) NOT NULL DEFAULT '0',
  `precio` decimal(10,2) DEFAULT NULL,
  `comodidad` varchar(255) DEFAULT NULL,
  `observacion` varchar(255) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idHabitacion`),
  UNIQUE KEY `numero` (`numero`),
  KEY `FK_habitaciones_tipohabitacion` (`id_tipo`),
  CONSTRAINT `FK_habitaciones_tipohabitacion` FOREIGN KEY (`id_tipo`) REFERENCES `tipohabitacion` (`idTipo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.habitaciones: ~6 rows (aproximadamente)
INSERT INTO `habitaciones` (`idHabitacion`, `numero`, `id_tipo`, `piso`, `capacidad`, `camaOcupada`, `estado`, `precio`, `comodidad`, `observacion`, `activo`) VALUES
	(1, '101', 1, 2, 1, 1, 'Ocupado', 80.00, 'Vista al jardín', 'Habitación tranquila', 1),
	(2, '203', 2, 3, 2, 2, 'Ocupado', 120.00, 'Con sofá cama', 'Paciente alérgico a los gatos', 1),
	(3, '305', 3, 4, 1, 1, 'Mantenimiento', 150.00, 'Bañera hidromasaje', 'Reparación de la ducha', 1),
	(4, '112', 4, 1, 2, 0, 'Disponible', 123.00, 'Acceso para discapacitados', 'con acompañante', 1),
	(5, '208', 5, 3, 1, 1, 'Ocupado', 90.00, 'Cama articulada', 'Paciente con movilidad reducida', 1),
	(6, '120', 4, 2, 2, 0, 'Disponible', 18000.00, '', '', 1);

-- Volcando estructura para tabla bd_sanatorio.internaciones
CREATE TABLE IF NOT EXISTS `internaciones` (
  `idInternacion` int(11) NOT NULL AUTO_INCREMENT,
  `fechaIngreso` date NOT NULL,
  `horaIngreso` time NOT NULL,
  `id_medico` int(11) NOT NULL DEFAULT 0,
  `id_paciente` int(11) NOT NULL DEFAULT 0,
  `id_habitacion` int(11) NOT NULL DEFAULT 0,
  `motivoInternacion` varchar(255) DEFAULT '0',
  `diagnostico` varchar(255) DEFAULT '0',
  `deuda` tinyint(1) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `fechaEgreso` date DEFAULT NULL,
  `horaEgreso` time DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idInternacion`),
  KEY `FK_internaciones_medicos` (`id_medico`),
  KEY `FK_internaciones_pacientes` (`id_paciente`),
  KEY `FK_internaciones_habitaciones` (`id_habitacion`),
  CONSTRAINT `FK_internaciones_habitaciones` FOREIGN KEY (`id_habitacion`) REFERENCES `habitaciones` (`idHabitacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_internaciones_medicos` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`idMedico`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_internaciones_pacientes` FOREIGN KEY (`id_paciente`) REFERENCES `pacientes` (`idPaciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.internaciones: ~17 rows (aproximadamente)
INSERT INTO `internaciones` (`idInternacion`, `fechaIngreso`, `horaIngreso`, `id_medico`, `id_paciente`, `id_habitacion`, `motivoInternacion`, `diagnostico`, `deuda`, `estado`, `fechaEgreso`, `horaEgreso`, `activo`) VALUES
	(1, '2023-11-22', '10:30:00', 65, 3, 2, 'Dolor abdominal', 'Apendicitis', 0, 'Alta', '2023-11-25', '12:00:00', 0),
	(2, '2023-12-01', '15:45:00', 72, 7, 4, 'Fractura de muñeca', 'Caída', 1, 'Alta', '2024-12-11', '00:15:52', 0),
	(3, '2023-11-28', '09:15:00', 67, 10, 1, 'Infección respiratoria', 'Neumonía', 0, 'Alta', '2023-12-02', '11:30:00', 1),
	(4, '2023-12-05', '18:00:00', 75, 5, 6, 'Quemadura', 'Contacto con líquido caliente', 1, 'Alta', '2024-12-11', '00:16:01', 0),
	(5, '2023-12-03', '13:30:00', 69, 2, 3, 'Dolor de cabeza', 'Migraña', 0, 'Alta', '2023-12-04', '15:00:00', 0),
	(7, '0001-01-01', '17:43:36', 71, 6, 1, 'tos aguda', 'bronqueos', 0, 'Alta', '2024-12-09', '00:40:22', 1),
	(8, '2024-12-09', '00:40:51', 68, 1, 2, 'Enfermedad 1', 'diagnostico 1', 1, 'Alta', '2024-12-11', '00:15:41', 0),
	(9, '2024-12-05', '17:56:46', 71, 6, 2, 'enfermedad 2', 'diagnostico 2', 1, 'Alta', '2024-12-11', '00:15:46', 0),
	(10, '2024-12-03', '10:00:30', 73, 8, 5, 'Enfermedad 3', 'Diagnostico 3', 0, 'Alta', '2024-12-11', '00:15:56', 0),
	(11, '2024-12-10', '23:46:20', 76, 10, 5, 'enfermedad 11', 'diagnistico 11', 0, 'Alta', '2024-12-11', '00:52:18', 0),
	(12, '2024-12-10', '23:49:59', 76, 4, 4, 'dfdfdfdfd', 'dfdfdfdfdf', 0, 'Alta', '2024-12-11', '00:52:10', 0),
	(13, '2024-12-10', '23:55:33', 76, 3, 1, 'enfermedad 13', 'DIAGNISCO 13', 0, 'Alta', '2024-12-11', '00:52:06', 1),
	(14, '2024-12-11', '00:16:49', 73, 1, 4, 'lalalalalaal', 'lalalalalalala', 0, 'Alta', '2024-12-11', '00:52:15', 0),
	(15, '2024-12-12', '00:53:10', 76, 1, 1, 'enfermedad 1', 'Diagnostico 1', 0, 'Internación', '2024-12-12', '00:53:10', 1),
	(16, '2024-12-11', '00:59:27', 1, 4, 2, 'enfermedad 2', 'diagnostico 2', 0, 'Internación', '2024-12-11', '00:59:27', 1),
	(17, '2024-12-11', '01:00:35', 2, 7, 2, 'Enfermedad 3', 'Diagnostico 3', 0, 'Internación', '2024-12-11', '01:00:35', 1),
	(18, '2024-12-11', '18:13:50', 72, 10, 5, 'enfermedad 4', 'Diagnostico 4', 1, 'Internación', '2024-12-11', '18:13:50', 1);

-- Volcando estructura para tabla bd_sanatorio.medicos
CREATE TABLE IF NOT EXISTS `medicos` (
  `idMedico` int(11) NOT NULL AUTO_INCREMENT,
  `dni` varchar(10) NOT NULL DEFAULT '0',
  `cuil` varchar(15) NOT NULL DEFAULT '0',
  `apellido` varchar(50) NOT NULL DEFAULT '0',
  `nombre` varchar(50) NOT NULL DEFAULT '0',
  `celular` varchar(15) DEFAULT '0',
  `telefono` varchar(15) DEFAULT '0',
  `direccion` varchar(50) DEFAULT '0',
  `email` varchar(50) DEFAULT '0',
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idMedico`),
  UNIQUE KEY `dni` (`dni`),
  UNIQUE KEY `cuil` (`cuil`)
) ENGINE=InnoDB AUTO_INCREMENT=78 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.medicos: ~17 rows (aproximadamente)
INSERT INTO `medicos` (`idMedico`, `dni`, `cuil`, `apellido`, `nombre`, `celular`, `telefono`, `direccion`, `email`, `activo`) VALUES
	(1, '27345678', '20345678912', 'Pérez', 'Juan', '1122334455', '44445555', 'Av. Siempreviva 123', 'jperez@email.com', 1),
	(2, '31234567', '27123456789', 'González', 'María', '1166554433', '55556666', 'Calle Las Flores 456', 'mgonzalez@email.com', 1),
	(3, '45678901', '45678901', 'Rodríguez', 'Pedro Canoero', '1188776655', '66667777', 'Calle Los Robles 789', 'prodriguez@email.com', 1),
	(4, '54321098', '30123456789', 'López', 'Ana', '1155443322', '77778888', 'Av. Siempreviva 987', 'alopz@email.com', 1),
	(65, '67890143', '33567890123', 'Martínez', 'Carlos', '1133221100', '88889999', 'Calle Los Tilos 123', 'cmartinez@email.com', 1),
	(66, '78201234', '25456787012', 'Fernández', 'Laura', '1199887766', '99990000', 'Av. Siempreviva 456', 'lfernandez@email.com', 1),
	(67, '89012945', '36123456789', 'García', 'Diego', '1177665544', '11112222', 'Calle Las Flores 789', 'dgarcia@email.com', 1),
	(68, '90123446', '28450789010', 'Gómez', 'Ana', '1155443322', '22223333', 'Av. Siempreviva 987', 'agomez@email.com', 1),
	(69, '12355678', '32123456769', 'López', 'Pablo', '1188776655', '33334444', 'Calle Los Robles 123', 'plopez@email.com', 1),
	(70, '23456689', '24856789012', 'Rodríguez', 'María', '1199887766', '44445555', 'Av. Siempreviva 456', 'mrodriguez@email.com', 1),
	(71, '34516890', '35123451789', 'Pérez', 'Diego', '1177665544', '55556666', 'Calle Las Flores 789', 'dperez@email.com', 1),
	(72, '45978671', '26458789010', 'González', 'Ana', '1155443322', '66667777', 'Av. Siempreviva 987', 'agonzalez@email.com', 1),
	(73, '56789002', '31123756789', 'Martínez', 'Carlos', '1188776655', '77778888', 'Calle Los Robles 123', 'cmartinez2@email.com', 1),
	(74, '67822123', '2945679012', 'Fernández', 'Laura', '1199887766', '88889999', 'Av. Siempreviva 456', 'lfernandez2@email.com', 1),
	(75, '29436853', '294368532', 'Cano', 'marcelo emanuel', '3838403741', '422760', 'barrio cristo rey casa 31', 'mecano@cat', 1),
	(76, '63254521', '20294368532', 'Alata', 'Ponce de leon', '555666', '555666', 'Av visente saadi', '', 1),
	(77, '25632145', '20365214562', 'CAstro', 'Ruben', '2365', '2365', '', '', 1);

-- Volcando estructura para tabla bd_sanatorio.obrassociales
CREATE TABLE IF NOT EXISTS `obrassociales` (
  `idSocial` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(6) DEFAULT '0',
  `nombre` varchar(50) NOT NULL DEFAULT '0',
  `sigla` varchar(15) DEFAULT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idSocial`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.obrassociales: ~4 rows (aproximadamente)
INSERT INTO `obrassociales` (`idSocial`, `codigo`, `nombre`, `sigla`, `activo`) VALUES
	(1, '0', 'Sin Obra Social', NULL, 1),
	(2, '1', 'OSEP', NULL, 1),
	(3, '2', 'OSDE', NULL, 1),
	(4, '106302', 'Obra Social de docnete particular', '', 1);

-- Volcando estructura para tabla bd_sanatorio.pacientes
CREATE TABLE IF NOT EXISTS `pacientes` (
  `idPaciente` int(11) NOT NULL AUTO_INCREMENT,
  `dni` varchar(10) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `fechaNaci` date NOT NULL,
  `domicilio` varchar(50) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `historiClinica` varchar(10) DEFAULT NULL,
  `id_obraSocial` int(11) DEFAULT NULL,
  `afiliadoN` varchar(10) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPaciente`),
  UNIQUE KEY `dni` (`dni`),
  KEY `FK_pacientes_obrassociales` (`id_obraSocial`),
  CONSTRAINT `FK_pacientes_obrassociales` FOREIGN KEY (`id_obraSocial`) REFERENCES `obrassociales` (`idSocial`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.pacientes: ~11 rows (aproximadamente)
INSERT INTO `pacientes` (`idPaciente`, `dni`, `apellido`, `nombre`, `fechaNaci`, `domicilio`, `telefono`, `historiClinica`, `id_obraSocial`, `afiliadoN`, `activo`) VALUES
	(1, '12345678', 'Pérez', 'Juan', '1980-01-15', 'Av. Siempreviva 123', '1122334455', '1001', 1, '1234', 1),
	(2, '87654321', 'González', 'María', '1990-05-20', 'Calle Falsa 456', '1567890123', '2002', 2, '5678', 1),
	(3, '54321987', 'Rodríguez', 'Pedro', '1975-09-10', 'Calle Verdad 789', '1133557799', '3003', 3, '9012', 1),
	(4, '11122233', 'López', 'Ana', '1995-12-25', 'Av. Principal 1', '1543216543', '4004', 1, '1234', 1),
	(5, '44455566', 'Martínez', 'Carlos', '1985-03-10', 'Calle Secundaria 2', '1155779911', '5005', 2, '5678', 1),
	(6, '77788899', 'Fernández', 'Sofía', '2000-07-15', 'Av. Terciaria 3', '1531234567', '6006', 3, '9012', 1),
	(7, '22233344', 'Gómez', 'Diego', '1970-11-05', 'Calle Cuarta 4', '1112345678', '7007', 1, '1234', 1),
	(8, '99988877', 'Díaz', 'Laura', '1982-02-28', 'Av. Quinta 5', '1523456789', '8008', 2, '5678', 1),
	(9, '66677788', 'Romero', 'Lucas', '1998-06-12', 'Calle Sexta 6', '1145678901', '9009', 3, '9012', 1),
	(10, '33344455', 'Santos', 'Valentina', '2005-10-27', 'Av. Séptima 7', '1554321654', '1010', 1, '1234', 1),
	(11, '29436853', 'cano', 'Marcelo Emanuel', '1982-07-25', 'barrio casa 31', '422653', '23652', 1, '5236', 1);

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_habitacion
DELIMITER //
CREATE PROCEDURE `psa_actualizar_habitacion`(
	IN `_id` INT,
	IN `_numero` VARCHAR(4),
	IN `_id_tipo` INT,
	IN `_piso` INT,
	IN `_capacidad` INT,
	IN `_estado` VARCHAR(50),
	IN `_precio` DECIMAL(10,2),
	IN `_comodidad` VARCHAR(255),
	IN `_observacion` VARCHAR(255)
)
BEGIN
UPDATE habitaciones
SET numero = _numero, id_tipo = _id_tipo, piso = _piso, capacidad = _capacidad, estado = _estado, precio = _precio,
comodidad = _comodidad, observacion = _observacion
WHERE idHabitacion = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_internacion
DELIMITER //
CREATE PROCEDURE `psa_actualizar_internacion`(
	IN `id_` INT,
	IN `_fechaIngreso` DATE,
	IN `_horaIngreso` TIME,
	IN `_id_medico` INT,
	IN `_id_paciente` INT,
	IN `_id_habitacion` INT,
	IN `_motivoInternacion` VARCHAR(255),
	IN `_diagnostico` VARCHAR(255),
	IN `_deuda` TINYINT,
	IN `_estado` VARCHAR(50),
	IN `_fechaEgreso` DATE,
	IN `_horaEgreso` TIME,
	IN `_activo` TINYINT
)
BEGIN
UPDATE  internaciones SET fechaIngreso = _fechaIngreso, horaIngreso = _horaIngreso, id_medico = _id_medico, id_paciente = _id_paciente,
id_habitacion = _id_habitacion, motivoInternacion = _motivoInternacion, diagnostico = _diagnostico, deuda = _deuda, estado = _estado,
fechaEgreso = _fechaEgreso, horaEgreso = _horaEgreso, activo = _activo
WHERE  idInternacion = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_libera_cama
DELIMITER //
CREATE PROCEDURE `psa_actualizar_libera_cama`(
	IN `_id` INT
)
BEGIN
UPDATE habitaciones
SET
    camaOcupada = camaOcupada - 1,
    estado = CASE
        WHEN camaOcupada <= capacidad THEN 'Disponible'
        ELSE 'Ocupado'
    END
WHERE idHabitacion = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_medico
DELIMITER //
CREATE PROCEDURE `psa_actualizar_medico`(
	IN `id_` INT,
	IN `dni_` VARCHAR(10),
	IN `cuil_` VARCHAR(15),
	IN `apellido_` VARCHAR(50),
	IN `nombre_` VARCHAR(50),
	IN `celular_` VARCHAR(15),
	IN `telefono_` VARCHAR(15),
	IN `direccion_` VARCHAR(50),
	IN `email_` VARCHAR(50)
)
BEGIN
UPDATE  medicos SET dni=dni_,cuil=cuil_,apellido=apellido_,nombre=nombre_,celular=celular_,
telefono=telefono_,direccion=direccion_,email=email_
WHERE  idMedico = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_obrasocial
DELIMITER //
CREATE PROCEDURE `psa_actualizar_obrasocial`(
	IN `id_` INT,
	IN `codigo_` VARCHAR(6),
	IN `nombre_` VARCHAR(50),
	IN `sigla_` VARCHAR(15)
)
BEGIN
UPDATE obrassociales AS o SET codigo=codigo_,nombre=nombre_,sigla=sigla_
WHERE  idSocial = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_ocupar_cama
DELIMITER //
CREATE PROCEDURE `psa_actualizar_ocupar_cama`(
	IN `_id` INT
)
BEGIN
UPDATE habitaciones
SET
    camaOcupada = camaOcupada + 1,
    estado = CASE
        WHEN camaOcupada >= capacidad THEN 'Ocupado'
        ELSE 'Disponible'
    END
WHERE idHabitacion = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_paciente
DELIMITER //
CREATE PROCEDURE `psa_actualizar_paciente`(
	IN `_id` INT,
	IN `_dni` VARCHAR(10),
	IN `_apellido` VARCHAR(50),
	IN `_nombre` VARCHAR(50),
	IN `_fechaNaci` DATE,
	IN `_domicilio` VARCHAR(50),
	IN `_telefono` VARCHAR(15),
	IN `_historiClinica` VARCHAR(10),
	IN `_id_obraSocial` INT,
	IN `_afiliadoN` VARCHAR(10)
)
BEGIN
UPDATE pacientes
SET dni = _dni, apellido = _apellido, nombre = _nombre, fechaNaci = _fechaNaci, domicilio = _domicilio,
telefono = _telefono, historiClinica = _historiClinica, id_obraSocial = _id_obraSocial, afiliadoN = _afiliadoN
WHERE idPaciente = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_registrosclinico
DELIMITER //
CREATE PROCEDURE `psa_actualizar_registrosclinico`(
	IN `_id` INT,
	IN `fecha_` DATE,
	IN `hora_` TIME,
	IN `motivo_` VARCHAR(255),
	IN `diagnostico_` VARCHAR(255),
	IN `tratamiento_` VARCHAR(255),
	IN `proxima_visita_` DATE,
	IN `observacion_` VARCHAR(255)
)
BEGIN

UPDATE registros_clinicos AS r
SET fecha=fecha_,hora=hora_,
motivo=motivo_,diganostico=diagnostico_,tratamiento=tratamiento_,
proxima_visita=proxima_visita_,observacion=observacion_
WHERE idRegistro = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_actualizar_tipohabitacion
DELIMITER //
CREATE PROCEDURE `psa_actualizar_tipohabitacion`(
	IN `_id` INT,
	IN `_descripcion` VARCHAR(255)
)
BEGIN
UPDATE tipohabitacion
SET descripcion = _descripcion
WHERE idTipo = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_alta_internacion
DELIMITER //
CREATE PROCEDURE `psa_alta_internacion`(
	IN `id_` INT,
	IN `fecha_` DATE,
	IN `hora_` TIME
)
BEGIN
UPDATE internaciones
SET fechaEgreso = fecha_, horaEgreso = hora_, estado = 'Alta' WHERE idInternacion = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_Habitacion_Numero
DELIMITER //
CREATE PROCEDURE `psa_buscar_Habitacion_Numero`(
	IN `_num` VARCHAR(4)
)
BEGIN
SELECT * FROM habitaciones WHERE numero = _num;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_internacion_id
DELIMITER //
CREATE PROCEDURE `psa_buscar_internacion_id`(
	IN `_id` INT
)
BEGIN
SELECT * FROM internaciones  WHERE idInternacion = _id and  activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_medico_dni
DELIMITER //
CREATE PROCEDURE `psa_buscar_medico_dni`(
	IN `_dni` INT
)
BEGIN
SELECT idMedico,dni,cuil,apellido,nombre,celular,telefono,direccion,email 
FROM medicos AS m 
WHERE  dni = _dni;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_medico_id
DELIMITER //
CREATE PROCEDURE `psa_buscar_medico_id`(
	IN `_id` INT
)
BEGIN
SELECT idMedico,dni,cuil,apellido,nombre,celular,telefono,direccion,email 
FROM medicos AS m 
WHERE  m.idMedico = _id AND m.activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_obrasocial_codigo
DELIMITER //
CREATE PROCEDURE `psa_buscar_obrasocial_codigo`(
	IN `codigo_` VARCHAR(4)
)
BEGIN
SELECT * from obrassociales WHERE codigo = codigo_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_obrasocial_id
DELIMITER //
CREATE PROCEDURE `psa_buscar_obrasocial_id`(
	IN `id_` INT
)
BEGIN
SELECT * from obrassociales WHERE idSocial = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_paciente_dni
DELIMITER //
CREATE PROCEDURE `psa_buscar_paciente_dni`(
	IN `_dni` VARCHAR(10)
)
BEGIN
SELECT * FROM pacientes WHERE dni = _dni;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_paciente_id
DELIMITER //
CREATE PROCEDURE `psa_buscar_paciente_id`(
	IN `_id` INT
)
BEGIN
SELECT * FROM pacientes  WHERE idPaciente = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_buscar_paciente_internado
DELIMITER //
CREATE PROCEDURE `psa_buscar_paciente_internado`(
	IN `_id` INT
)
BEGIN
SELECT * FROM internaciones WHERE id_paciente = _id AND estado = 'Internación';
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_habitacion
DELIMITER //
CREATE PROCEDURE `psa_eliminar_habitacion`(
	IN `_id` INT
)
BEGIN
UPDATE habitaciones SET activo = false WHERE idHabitacion = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_internacion
DELIMITER //
CREATE PROCEDURE `psa_eliminar_internacion`(
	IN `id_` INT
)
BEGIN
UPDATE internaciones SET activo = false WHERE idInternacion = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_medico
DELIMITER //
CREATE PROCEDURE `psa_eliminar_medico`(
	IN `_id` INT
)
BEGIN
UPDATE  medicos AS m SET m.activo = 0 WHERE  idMedico = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_obrasocial
DELIMITER //
CREATE PROCEDURE `psa_eliminar_obrasocial`(
	IN `id_` INT
)
BEGIN
UPDATE obrassociales SET activo = false
WHERE  idSocial = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_paciente
DELIMITER //
CREATE PROCEDURE `psa_eliminar_paciente`(
	IN `_id` INT
)
BEGIN
UPDATE pacientes
SET activo = false WHERE idPaciente = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_registroClinico
DELIMITER //
CREATE PROCEDURE `psa_eliminar_registroClinico`(
	IN `id_` INT
)
BEGIN
UPDATE registros_clinicos SET activo = false WHERE idRegistro = id_;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_eliminar_tipohabitacion
DELIMITER //
CREATE PROCEDURE `psa_eliminar_tipohabitacion`(
	IN `_id` INT
)
BEGIN
DELETE FROM tipohabitacion WHERE idTipo = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_especialidad_medico
DELIMITER //
CREATE PROCEDURE `psa_guardar_especialidad_medico`(
	IN `id_especialidad_` INT,
	IN `id_medico_` INT,
	IN `matricula_` VARCHAR(10)
)
BEGIN
INSERT INTO especialidad_medico (id_especialidad,id_medico,matricula)
VALUES (id_especialidad_,id_medico_,matricula_);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_habitacion
DELIMITER //
CREATE PROCEDURE `psa_guardar_habitacion`(
	IN `_numero` VARCHAR(4),
	IN `_id_tipo` INT,
	IN `_piso` INT,
	IN `_capacidad` INT,
	IN `_estado` VARCHAR(50),
	IN `_precio` DECIMAL(10,2),
	IN `_comodidad` VARCHAR(255),
	IN `_observacion` VARCHAR(255)
)
BEGIN
INSERT INTO habitaciones (numero,id_tipo,piso,capacidad,estado,precio,comodidad,observacion,activo)
VALUES (_numero,_id_tipo,_piso,_capacidad,_estado,_precio,_comodidad,_observacion,true);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_internacion
DELIMITER //
CREATE PROCEDURE `psa_guardar_internacion`(
	IN `fechaIngreso_` DATE,
	IN `horaIngreso_` TIME,
	IN `id_medico_` INT,
	IN `id_paciente_` INT,
	IN `id_habitacion_` INT,
	IN `motivoInternacion_` VARCHAR(255),
	IN `diagnostico_` VARCHAR(255),
	IN `deuda_` TINYINT,
	IN `estado_` VARCHAR(50),
	IN `fechaEgreso_` DATE,
	IN `horaEgreso_` TIME
)
BEGIN
INSERT INTO internaciones 
(fechaIngreso,horaIngreso,id_medico,id_paciente,id_habitacion,motivoInternacion,diagnostico,deuda,estado,fechaEgreso,horaEgreso,activo)
VALUES
(fechaIngreso_,horaIngreso_,id_medico_,id_paciente_,id_habitacion_,motivoInternacion_,diagnostico_,deuda_,estado_,fechaEgreso_,horaEgreso_,true);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_medico
DELIMITER //
CREATE PROCEDURE `psa_guardar_medico`(
	IN `dni_` VARCHAR(10),
	IN `cuil_` VARCHAR(15),
	IN `apellido_` VARCHAR(50),
	IN `nombre_` VARCHAR(50),
	IN `celular_` VARCHAR(15),
	IN `telefono_` VARCHAR(15),
	IN `direccion_` VARCHAR(50),
	IN `email_` VARCHAR(50)
)
BEGIN
INSERT INTO medicos (dni,cuil,apellido,nombre,celular,telefono,direccion,email,activo)
VALUES (dni_,cuil_,apellido_,nombre_,celular_,telefono_,direccion_,email_,true);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_obrasocial
DELIMITER //
CREATE PROCEDURE `psa_guardar_obrasocial`(
	IN `codigo_` VARCHAR(6),
	IN `nombre_` VARCHAR(50),
	IN `sigla_` VARCHAR(15)
)
BEGIN
INSERT INTO obrassociales (codigo,nombre,sigla,activo)
VALUES (codigo_,nombre_,sigla_,true);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_paciente
DELIMITER //
CREATE PROCEDURE `psa_guardar_paciente`(
	IN `_dni` VARCHAR(10),
	IN `_apellido` VARCHAR(50),
	IN `_nombre` VARCHAR(50),
	IN `_fechaNaci` DATE,
	IN `_domicilio` VARCHAR(50),
	IN `_telefono` VARCHAR(15),
	IN `_historiClinica` VARCHAR(10),
	IN `_id_obraSocial` INT,
	IN `_afiliadoN` VARCHAR(10)
)
BEGIN
INSERT INTO pacientes(dni,apellido,nombre,fechaNaci,domicilio,telefono,historiClinica,id_obraSocial,afiliadoN,activo)
VALUES(_dni,_apellido,_nombre,_fechaNaci,_domicilio,_telefono,_historiClinica,_id_obraSocial,_afiliadoN,true);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_registro_clinico
DELIMITER //
CREATE PROCEDURE `psa_guardar_registro_clinico`(
	IN `id_paciente_` INT,
	IN `id_medico_` INT,
	IN `fecha_` DATE,
	IN `hora_` TIME,
	IN `motivo_` VARCHAR(255),
	IN `diagnostico_` VARCHAR(255),
	IN `tratamiento_` VARCHAR(255),
	IN `proxima_visita_` DATE,
	IN `observacion_` VARCHAR(255)
)
BEGIN
INSERT INTO registros_clinicos(id_paciente,id_medico,fecha,hora,motivo,diganostico,tratamiento,proxima_visita,observacion,activo)
VALUES (id_paciente_,id_medico_,fecha_,hora_,motivo_,diagnostico_,tratamiento_,proxima_visita_,observacion_,true);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_guardar_tipohabitacion
DELIMITER //
CREATE PROCEDURE `psa_guardar_tipohabitacion`(
	IN `_descripcion` VARCHAR(255)
)
BEGIN
INSERT INTO tipohabitacion(descripcion) VALUE (_descripcion);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listado_habitaciones
DELIMITER //
CREATE PROCEDURE `psa_listado_habitaciones`()
BEGIN
SELECT h.idHabitacion,h.numero,t.descripcion,h.piso,h.capacidad,h.estado,h.precio,h.comodidad,h.observacion,h.id_tipo
FROM habitaciones AS h
INNER JOIN tipohabitacion AS t ON h.id_tipo = t.idTipo AND h.activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listado_obra_sociales
DELIMITER //
CREATE PROCEDURE `psa_listado_obra_sociales`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT idSocial,codigo, sigla ,nombre FROM obrassociales WHERE activo = 1 
AND UPPER(CONCAT(TRIM(nombre),TRIM(codigo))) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listado_pacientes
DELIMITER //
CREATE PROCEDURE `psa_listado_pacientes`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT p.idPaciente,p.historiClinica,p.dni,p.apellido,p.nombre,p.fechaNaci,
YEAR(CURDATE()) - YEAR(p.fechaNaci) - (DATE_FORMAT(CURDATE(), '%m%d') < DATE_FORMAT(p.fechaNaci, '%m%d')) AS edad,
p.domicilio,p.telefono,o.nombre AS obraSocial, p.afiliadoN,o.idSocial
FROM pacientes AS p INNER JOIN obrassociales AS o ON p.id_obraSocial= o.idSocial
WHERE p.activo = 1
AND UPPER(CONCAT(TRIM(p.dni), TRIM(p.apellido))) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listado_registro_clinico
DELIMITER //
CREATE PROCEDURE `psa_listado_registro_clinico`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT r.idRegistro, CONCAT(p.apellido, ' ' ,p.nombre) AS paciente,CONCAT(m.apellido, ' ' ,m.apellido) AS medico,r.fecha,r.hora,r.motivo,r.diganostico,r.tratamiento,r.proxima_visita,r.observacion,
p.idPaciente,m.idMedico
FROM registros_clinicos AS r INNER JOIN pacientes AS p ON r.id_paciente = p.idPaciente INNER JOIN medicos AS m ON r.id_medico = m.idMedico
WHERE r.activo = 1 AND UPPER(CONCAT(TRIM(CONCAT(p.apellido, ' ' ,p.nombre)), TRIM(CONCAT(m.apellido, ' ' ,m.apellido)))) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listado_tipoHabitacion
DELIMITER //
CREATE PROCEDURE `psa_listado_tipoHabitacion`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT idTipo, descripcion FROM tipohabitacion WHERE  UPPER(TRIM(descripcion)) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listar_especialidad
DELIMITER //
CREATE PROCEDURE `psa_listar_especialidad`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT idEspecialidad,especialidad,descripcion
FROM especialidades 
WHERE  UPPER(CONCAT(TRIM(especialidad), TRIM(descripcion))) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listar_habitacion_cama_disponible
DELIMITER //
CREATE PROCEDURE `psa_listar_habitacion_cama_disponible`()
BEGIN
SELECT idHabitacion,numero,(h.capacidad - h.camaOcupada )  AS camaDisponible,piso,estado 
FROM habitaciones AS h  WHERE  estado = 'Disponible' AND activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listar_internados
DELIMITER //
CREATE PROCEDURE `psa_listar_internados`(
	IN `_estado` VARCHAR(50),
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT i.idInternacion,i.fechaIngreso,i.horaIngreso,CONCAT(p.apellido, ' ',p.nombre) AS paciente,
CONCAT(m.apellido, ' ',m.nombre) AS medico, h.numero AS habitacion, i.motivoInternacion,i.estado,i.fechaEgreso, h.idHabitacion
FROM internaciones AS i
INNER JOIN medicos AS m ON i.id_medico = m.idMedico
INNER JOIN pacientes AS p ON i.id_paciente = p.idPaciente
INNER JOIN habitaciones AS h ON i.id_habitacion = h.idHabitacion
WHERE i.activo = 1 AND i.estado = _estado
AND UPPER(CONCAT(p.apellido,' ',p.nombre)) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listar_Medicos
DELIMITER //
CREATE PROCEDURE `psa_listar_Medicos`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT m.idMedico, m.cuil, m.apellido, m.nombre, m.celular, m.telefono, MIN(e.matricula), esp.especialidad
FROM medicos AS m
INNER JOIN especialidad_medico AS e ON m.idMedico = e.id_medico
INNER JOIN especialidades AS esp ON e.id_especialidad = esp.idEspecialidad
WHERE m.activo = 1
AND UPPER(CONCAT(TRIM(m.apellido), TRIM(m.nombre), TRIM(esp.especialidad))) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%')
GROUP BY m.idMedico, m.cuil, m.apellido, m.nombre, m.celular, m.telefono, esp.especialidad;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listar_pacientes_internados
DELIMITER //
CREATE PROCEDURE `psa_listar_pacientes_internados`(
	IN `cTexto` VARCHAR(50)
)
BEGIN
SELECT p.idPaciente,p.dni,p.apellido,p.nombre,p.fechaNaci,p.domicilio,p.telefono,p.historiClinica,p.id_obraSocial,p.afiliadoN
FROM pacientes AS p INNER JOIN internaciones AS i ON p.idPaciente = i.id_paciente
WHERE i.estado = 'Internación' AND UPPER(CONCAT(TRIM(p.dni), TRIM(p.apellido),TRIM(p.nombre))) LIKE CONCAT('%', UPPER(TRIM(cTexto)), '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sanatorio.psa_listar_todos_Medicos
DELIMITER //
CREATE PROCEDURE `psa_listar_todos_Medicos`()
BEGIN
SELECT * FROM medicos as m
WHERE m.activo = 1;
END//
DELIMITER ;

-- Volcando estructura para tabla bd_sanatorio.registros_clinicos
CREATE TABLE IF NOT EXISTS `registros_clinicos` (
  `idRegistro` int(11) NOT NULL AUTO_INCREMENT,
  `id_paciente` int(11) NOT NULL DEFAULT 0,
  `id_medico` int(11) NOT NULL DEFAULT 0,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `motivo` varchar(255) DEFAULT '',
  `diganostico` varchar(255) DEFAULT '',
  `tratamiento` varchar(255) DEFAULT '',
  `proxima_visita` date DEFAULT NULL,
  `observacion` varchar(255) DEFAULT '',
  `activo` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idRegistro`),
  KEY `FK_registros_clinicos_pacientes` (`id_paciente`),
  KEY `FK_registros_clinicos_medicos` (`id_medico`),
  CONSTRAINT `FK_registros_clinicos_medicos` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`idMedico`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_registros_clinicos_pacientes` FOREIGN KEY (`id_paciente`) REFERENCES `pacientes` (`idPaciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.registros_clinicos: ~2 rows (aproximadamente)
INSERT INTO `registros_clinicos` (`idRegistro`, `id_paciente`, `id_medico`, `fecha`, `hora`, `motivo`, `diganostico`, `tratamiento`, `proxima_visita`, `observacion`, `activo`) VALUES
	(1, 1, 3, '2024-12-13', '17:11:51', 'sin novedades', 'con el mismo', 'sin novedades', '2024-12-14', '', 1),
	(2, 4, 4, '2024-12-04', '18:22:03', 'varias observaciones', 'con el mismo', 'sin novedad', '2024-12-14', 'varias observaciones', 1);

-- Volcando estructura para tabla bd_sanatorio.tipohabitacion
CREATE TABLE IF NOT EXISTS `tipohabitacion` (
  `idTipo` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(255) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idTipo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla bd_sanatorio.tipohabitacion: ~6 rows (aproximadamente)
INSERT INTO `tipohabitacion` (`idTipo`, `descripcion`) VALUES
	(1, 'Cama individual, baño privado, televisión, conexión a internet Wi-Fi'),
	(2, 'Cama doble, baño privado, televisión, conexión a internet Wi-Fi, sofá cama para un acompañante'),
	(3, 'Cama king size, baño privado con bañera, televisión de pantalla plana, minibar, conexión a internet Wi-Fi, escritorio'),
	(4, 'Cama individual, baño privado, televisión, conexión a internet Wi-Fi, acceso a un pequeño jardín privado'),
	(5, 'Cama ajustable, baño adaptado, barras de apoyo, timbre de emergencia, televisión, conexión a internet Wi-Fi'),
	(7, 'Sin descripción');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
