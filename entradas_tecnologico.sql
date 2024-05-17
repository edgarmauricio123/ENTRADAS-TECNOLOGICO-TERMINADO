-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-05-2024 a las 21:56:40
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `entradas_tecnologico`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `Numero_control_alumno` int(11) NOT NULL,
  `Nombre` varchar(70) NOT NULL,
  `carrera` varchar(20) NOT NULL,
  `correo` varchar(70) NOT NULL,
  `semestre` int(11) NOT NULL,
  `grupo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`Numero_control_alumno`, `Nombre`, `carrera`, `correo`, `semestre`, `grupo`) VALUES
(1, 'Ana Kimberly Gonzalez Roman ', 'Sistemasmex', 'anagonz@gmail.com', 4, '4BS'),
(2620001, 'marco rosas', 'sistemas', 'marcorosas@gmail.com', 4, '4bs'),
(22620002, 'edgar mauricio sarmiento ruiz', 'Mecatronica', 'ajddfsyhdas,fbksdf,', 4, '4BS'),
(22620023, 'sandy santiago', 'mecatronic', 'sansantiago@gmail.com', 4, '4bs'),
(22620035, 'mario', 'sistemas', 'ashdgfkjFHK,sf', 4, '4bs'),
(22620053, 'marlene osorio ramirez', 'sistemas', 'marleneremirez@gmail.com', 4, '4bs'),
(22620066, 'edgar sarmiento ruiz', 'sistemas', 'edgarsarmiento133@gmail.com', 4, '4bs'),
(22620080, 'ari lopez aparicio', 'sistemas', 'vavaygyferhj', 4, '4bs'),
(22620081, 'ana kimberli', 'mecatronic', 'hfiuhlads', 4, '4bs'),
(22620089, '', '', '', 0, ''),
(22620269, 'marlene maricela osorio ramirez', 'Sistemas', 'marleneramirez@gmail.com', 4, '4BS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesores`
--

CREATE TABLE `profesores` (
  `id_profesor` int(11) NOT NULL,
  `ced_profesional` int(15) NOT NULL,
  `nombre` varchar(70) NOT NULL,
  `telefono` varchar(12) NOT NULL,
  `correo` varchar(70) NOT NULL,
  `sexo` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `profesores`
--

INSERT INTO `profesores` (`id_profesor`, `ced_profesional`, `nombre`, `telefono`, `correo`, `sexo`) VALUES
(1, 123456789, 'Jose ALfredo Roman Cruz', '9532303920', 'romanjosealfredo@gmail.com', 'Masculino'),
(2, 123456782, 'Alondra Salcedo', '9532455878', 'alondrasalcedo@gmail.com', 'Femenino'),
(3, 123654987, 'Lucia Sanchez', '9531597553', 'lucisanchez123@gmail.com', 'Femenino');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`Numero_control_alumno`);

--
-- Indices de la tabla `profesores`
--
ALTER TABLE `profesores`
  ADD PRIMARY KEY (`id_profesor`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  MODIFY `Numero_control_alumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22620270;

--
-- AUTO_INCREMENT de la tabla `profesores`
--
ALTER TABLE `profesores`
  MODIFY `id_profesor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
