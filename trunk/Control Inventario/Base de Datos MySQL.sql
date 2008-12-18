-- phpMyAdmin SQL Dump
-- version 2.11.7
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 16-12-2008 a las 15:14:48
-- Versión del servidor: 5.0.51
-- Versión de PHP: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `inventario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulos`
--

CREATE TABLE IF NOT EXISTS `articulos` (
  `id` int(5) NOT NULL auto_increment,
  `nombre` varchar(50) NOT NULL,
  `precio` double NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `existencia` varchar(5) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Volcar la base de datos para la tabla `articulos`
--

INSERT INTO `articulos` (`id`, `nombre`, `precio`, `descripcion`, `existencia`) VALUES
(1, 'Jabon de Mano', 13.5, 'Jabon para manos.', '99'),
(3, 'Pua 1.5mm', 10, 'Pua de guitarra de 1.5mm', '10'),
(4, 'Pua 2.5mm', 10, 'Pua de Guitarra de 2.5mm', '9'),
(5, 'Pua .5mm', 10, 'Pua de guitarra de .5mm', '10'),
(6, 'Laptop Vaio', 17500, 'Laptop Vaio VGN-FW170J', '0'),
(12, 'Monitor Plasma 22"', 22000, 'Es un monitor de plasma de 22 Pulgadas muy bonito.', '4'),
(8, 'iPhone', 3000, 'iPhone 1G, 8Gb', '6'),
(11, 'Pluma', 5.5, 'Pluma azul', '63');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencia`
--

CREATE TABLE IF NOT EXISTS `asistencia` (
  `id` int(4) NOT NULL auto_increment,
  `idUsuario` int(3) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `tipo` int(1) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=28 ;

--
-- Volcar la base de datos para la tabla `asistencia`
--

INSERT INTO `asistencia` (`id`, `idUsuario`, `fecha`, `hora`, `tipo`) VALUES
(1, 1, '2008-12-16', '13:30:30', 1),
(2, 1, '2008-12-16', '13:30:50', 2),
(3, 3, '2008-12-16', '13:30:54', 1),
(4, 3, '2008-12-16', '13:32:00', 1),
(5, 1, '2008-12-16', '13:34:03', 1),
(6, 2, '2008-12-16', '13:36:01', 1),
(7, 2, '2008-12-16', '13:36:03', 2),
(8, 1, '2008-12-16', '13:36:52', 1),
(9, 1, '2008-12-16', '14:14:46', 1),
(10, 1, '2008-12-16', '14:15:05', 1),
(11, 1, '2008-12-16', '14:16:28', 1),
(12, 1, '2008-12-16', '14:16:56', 2),
(13, 1, '2008-12-16', '14:16:57', 1),
(14, 0, '2008-12-16', '14:20:21', 1),
(15, 1, '2008-12-16', '14:20:37', 1),
(16, 1, '2008-12-16', '14:21:25', 2),
(17, 1, '2008-12-16', '14:21:26', 1),
(18, 1, '2008-12-16', '14:26:59', 1),
(19, 1, '2008-12-16', '14:47:19', 1),
(20, 1, '2008-12-16', '14:48:31', 1),
(21, 1, '2008-12-16', '14:49:32', 1),
(22, 1, '2008-12-16', '14:56:49', 1),
(23, 1, '2008-12-16', '15:02:04', 1),
(24, 1, '2008-12-16', '15:04:42', 1),
(25, 1, '2008-12-16', '15:06:00', 1),
(26, 1, '2008-12-16', '15:08:09', 1),
(27, 1, '2008-12-16', '15:11:24', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras`
--

CREATE TABLE IF NOT EXISTS `compras` (
  `id` int(6) NOT NULL auto_increment,
  `idProvedor` int(4) NOT NULL,
  `idArticulo` int(4) NOT NULL,
  `cantidad` int(5) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

--
-- Volcar la base de datos para la tabla `compras`
--

INSERT INTO `compras` (`id`, `idProvedor`, `idArticulo`, `cantidad`, `fecha`) VALUES
(30, 4, 6, 10, '2008-10-27'),
(31, 1, 8, 1, '2008-10-27'),
(32, 2, 6, 5, '2008-10-28'),
(33, 2, 6, 26, '2008-10-28'),
(34, 3, 11, 50, '2008-10-28'),
(35, 1, 3, 5, '2008-10-28'),
(36, 1, 6, 1, '2008-10-28'),
(38, 1, 11, 5, '2008-12-15'),
(39, 6, 1, 100, '2008-12-15'),
(40, 1, 12, 5, '2008-12-15');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE IF NOT EXISTS `facturas` (
  `id` int(4) NOT NULL auto_increment,
  `cliente` text NOT NULL,
  `importe` double NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcar la base de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`id`, `cliente`, `importe`, `fecha`) VALUES
(1, 'ChokoCrispy', 13.5, '2008-12-16'),
(2, 'No mames', 18, '2008-12-06'),
(3, 'Casita', 13.5, '2008-12-16'),
(4, 'Cliente Patito', 22000, '2008-12-16');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ganancias`
--

CREATE TABLE IF NOT EXISTS `ganancias` (
  `id` int(5) NOT NULL auto_increment,
  `monto` float(10,2) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=40 ;

--
-- Volcar la base de datos para la tabla `ganancias`
--

INSERT INTO `ganancias` (`id`, `monto`, `fecha`) VALUES
(12, 3000.00, '2008-10-27'),
(13, 3000.00, '2008-10-27'),
(14, 17500.00, '2008-10-27'),
(15, 17500.00, '2008-10-27'),
(16, 5.50, '2008-10-27'),
(17, 15.50, '2008-10-27'),
(18, 17500.00, '2008-10-28'),
(19, 875000.00, '2008-10-28'),
(20, 50.00, '2008-10-28'),
(21, 17500.00, '2008-11-02'),
(22, 3000.00, '2008-12-12'),
(23, 3000.00, '2008-12-12'),
(24, 13.50, '2008-12-12'),
(25, 3000.00, '2008-12-12'),
(26, 3000.00, '2008-12-12'),
(27, 6000.00, '2008-12-12'),
(28, 22000.00, '2008-12-15'),
(29, 13.50, '2008-12-16'),
(30, 13.50, '2008-12-16'),
(31, 13.50, '2008-12-16'),
(32, 13.50, '2008-12-16'),
(33, 13.50, '2008-12-16'),
(34, 13.50, '2008-12-16'),
(35, 27.00, '2008-12-16'),
(36, 13.50, '2008-12-16'),
(37, 13.50, '2008-12-16'),
(38, 22000.00, '2008-12-16'),
(39, 22000.00, '2008-12-16');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preventa`
--

CREATE TABLE IF NOT EXISTS `preventa` (
  `id` int(3) NOT NULL auto_increment,
  `idArticulo` int(4) NOT NULL,
  `cantidad` int(4) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Volcar la base de datos para la tabla `preventa`
--


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provedores`
--

CREATE TABLE IF NOT EXISTS `provedores` (
  `id` int(3) NOT NULL auto_increment,
  `nombre` varchar(30) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `telefono` varchar(30) NOT NULL,
  `rfc` varchar(30) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcar la base de datos para la tabla `provedores`
--

INSERT INTO `provedores` (`id`, `nombre`, `direccion`, `telefono`, `rfc`) VALUES
(1, 'Cliente', '', '', ''),
(2, 'Delphi', '', '', ''),
(3, 'UACJ', 'Avenida del Charro', '617 7816', 'LIEJ200687'),
(4, 'EDS', 'Direccion', 'Telefono', 'Rfcito'),
(6, 'Smart', 'Calle de la Mision', '617 77 77', 'SMART112233');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(3) NOT NULL auto_increment,
  `user` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `tipousuario` varchar(1) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcar la base de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `user`, `password`, `nombre`, `tipousuario`) VALUES
(1, 'NOVALYS', 'CLAUDIA', 'JORGE LIMAS', '1'),
(2, 'CHIKIPAO', 'CLAUDIA', 'PALOMA RINCON', '0'),
(3, 'ADMIN', 'ADMIN', 'ADMIN', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE IF NOT EXISTS `ventas` (
  `id` int(6) NOT NULL auto_increment,
  `idArticulo` int(4) NOT NULL,
  `cantidad` int(5) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=52 ;

--
-- Volcar la base de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id`, `idArticulo`, `cantidad`, `fecha`) VALUES
(26, 11, 1, '2008-10-27'),
(27, 4, 1, '2008-10-27'),
(28, 11, 1, '2008-10-27'),
(29, 6, 1, '2008-10-28'),
(30, 6, 50, '2008-10-28'),
(31, 3, 5, '2008-10-28'),
(32, 6, 1, '2008-11-02'),
(33, 8, 1, '2008-12-12'),
(34, 8, 1, '2008-12-12'),
(35, 1, 1, '2008-12-12'),
(36, 8, 1, '2008-12-12'),
(37, 8, 1, '2008-12-12'),
(38, 8, 2, '2008-12-12'),
(39, 12, 1, '2008-12-15'),
(40, 1, 1, '2008-12-16'),
(41, 1, 1, '2008-12-16'),
(42, 1, 1, '2008-12-16'),
(43, 1, 1, '2008-12-16'),
(44, 1, 1, '2008-12-16'),
(45, 1, 1, '2008-12-16'),
(46, 1, 1, '2008-12-16'),
(47, 1, 1, '2008-12-16'),
(48, 1, 1, '2008-12-16'),
(49, 1, 1, '2008-12-16'),
(50, 12, 1, '2008-12-16'),
(51, 12, 1, '2008-12-16');
