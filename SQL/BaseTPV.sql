CREATE DATABASE  IF NOT EXISTS `TPV` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `TPV`;
-- MySQL dump 10.13  Distrib 5.1.40, for Win32 (ia32)
--
-- Host: localhost    Database: TPV
-- ------------------------------------------------------
-- Server version	5.1.37

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `lido_lineas_documento`
--

DROP TABLE IF EXISTS `lido_lineas_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lido_lineas_documento` (
  `ID_ELEM_CAB` bigint(20) NOT NULL COMMENT 'Id elemento cabecera',
  `ID_ELEM` bigint(20) NOT NULL COMMENT 'Id elemento linea\n',
  `ID_ELEM_PROD` bigint(20) DEFAULT NULL COMMENT 'Elemento del producto, puede ser nulo, en lineas de texto\n',
  `CANTIDAD_LIDO` double DEFAULT '0' COMMENT 'Cantidad de producto en la linea\n',
  `PVB_LIDO` double DEFAULT '0' COMMENT 'Precio del prodcuto, en bruto, a la hora de calcular la linea\n',
  `PORC_IVA_LIDO` double DEFAULT '0' COMMENT 'Porcentaje (en tanto por 1) de iva aplicado al producto, en el momento de grabar la linea\n',
  `PVP_LIDO` double unsigned zerofill DEFAULT '0000000000000000000000' COMMENT 'Total del precio (pvp_lido*(1+porc_iva_lido))\n',
  `TOTAL_LIDO` double DEFAULT '0' COMMENT 'Total de la linea\n',
  `TEXTO_LIDO` varchar(255) DEFAULT NULL COMMENT 'Texto opcional de la linea\n',
  PRIMARY KEY (`ID_ELEM_CAB`,`ID_ELEM`),
  KEY `IN_ELEM_PROD` (`ID_ELEM_PROD`,`ID_ELEM_CAB`,`ID_ELEM`),
  KEY `FK_LIDO_CADO` (`ID_ELEM_CAB`),
  KEY `FK_LIDO_ELEM` (`ID_ELEM`),
  KEY `FK_LIDO_PROD` (`ID_ELEM_PROD`),
  CONSTRAINT `FK_LIDO_CADO` FOREIGN KEY (`ID_ELEM_CAB`) REFERENCES `cado_cabecera_documento` (`ID_ELEM`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_LIDO_ELEM` FOREIGN KEY (`ID_ELEM`) REFERENCES `elem_elementos` (`ID_ELEMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_LIDO_PROD` FOREIGN KEY (`ID_ELEM_PROD`) REFERENCES `prod_productos` (`ID_ELEM`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lido_lineas_documento`
--

LOCK TABLES `lido_lineas_documento` WRITE;
/*!40000 ALTER TABLE `lido_lineas_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `lido_lineas_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiva_tipos_iva`
--

DROP TABLE IF EXISTS `tiva_tipos_iva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiva_tipos_iva` (
  `COD_TIVA` varchar(3) NOT NULL,
  `DEFECTO_TIVA` enum('S','N') DEFAULT NULL,
  `DESCR_TIVA` varchar(60) DEFAULT NULL,
  `POR_IVA` double DEFAULT '0',
  `VIGENTE_IVA` enum('S','N') DEFAULT 'N',
  PRIMARY KEY (`COD_TIVA`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiva_tipos_iva`
--

LOCK TABLES `tiva_tipos_iva` WRITE;
/*!40000 ALTER TABLE `tiva_tipos_iva` DISABLE KEYS */;
INSERT INTO `tiva_tipos_iva` VALUES ('R04','N','4% Repercutido',1.04,'S'),('R08','N','8% Repercutido',1.08,'S'),('R18','S','18% Repercutido',1.18,'S'),('S04','N','4% Soportado',1.04,'S'),('S08','N','8% Soportado',1.08,'S'),('S18','N','18% Soportado',1.18,'S');
/*!40000 ALTER TABLE `tiva_tipos_iva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pers_personas`
--

DROP TABLE IF EXISTS `pers_personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pers_personas` (
  `ID_ELEM` bigint(20) NOT NULL,
  `NIF_PERS` varchar(15) DEFAULT NULL,
  `NOMBRE_PERS` varchar(255) DEFAULT NULL,
  `DIRE_PERS` varchar(255) DEFAULT NULL,
  `CODPOSTAL_PERS` varchar(5) DEFAULT NULL,
  `POBLACION_PERS` varchar(60) DEFAULT NULL,
  `PROVINCIA_PERS` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`ID_ELEM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pers_personas`
--

LOCK TABLES `pers_personas` WRITE;
/*!40000 ALTER TABLE `pers_personas` DISABLE KEYS */;
INSERT INTO `pers_personas` VALUES (1001000000,'-','CLIENTE CONTADO','-','00000','-','-');
/*!40000 ALTER TABLE `pers_personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prpr_precios_producto`
--

DROP TABLE IF EXISTS `prpr_precios_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prpr_precios_producto` (
  `ID_ELEM_PROD` bigint(20) NOT NULL,
  `ID_ELEM` bigint(20) NOT NULL,
  `VIGENTE_PRECIO` enum('S','N') DEFAULT NULL,
  `PRECIO_COMPRA` double DEFAULT '0',
  `PRECIO_BRUTO` double DEFAULT '0',
  `COD_TIVA` varchar(3) DEFAULT NULL,
  `PORC_IVA` double DEFAULT '0.18',
  `PRECIO_VENTA` double DEFAULT '0',
  PRIMARY KEY (`ID_ELEM_PROD`,`ID_ELEM`),
  KEY `FK_PRPR_PROD` (`ID_ELEM_PROD`),
  KEY `FK_PRPR_TIVA` (`COD_TIVA`),
  CONSTRAINT `FK_PRPR_PROD` FOREIGN KEY (`ID_ELEM_PROD`) REFERENCES `prod_productos` (`ID_ELEM`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_PRPR_TIVA` FOREIGN KEY (`COD_TIVA`) REFERENCES `tiva_tipos_iva` (`COD_TIVA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prpr_precios_producto`
--

LOCK TABLES `prpr_precios_producto` WRITE;
/*!40000 ALTER TABLE `prpr_precios_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `prpr_precios_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_productos`
--

DROP TABLE IF EXISTS `prod_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_productos` (
  `ID_ELEM` bigint(20) NOT NULL,
  `COD_FAMI` varchar(5) DEFAULT NULL,
  `COD_SUFA` varchar(5) DEFAULT NULL,
  `COD_BARRAS` varchar(40) DEFAULT NULL,
  `NOMBRE_PROD` varchar(60) DEFAULT NULL,
  `EXISTENCIAS_PROD` double DEFAULT '0',
  PRIMARY KEY (`ID_ELEM`),
  KEY `FK_PROD_ELEM` (`ID_ELEM`),
  KEY `IN_PROD_BARRAS` (`COD_BARRAS`),
  KEY `FK_PROD_SUFA` (`COD_FAMI`,`COD_SUFA`),
  CONSTRAINT `FK_PROD_ELEM` FOREIGN KEY (`ID_ELEM`) REFERENCES `elem_elementos` (`ID_ELEMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_PROD_SUFA` FOREIGN KEY (`COD_FAMI`, `COD_SUFA`) REFERENCES `sufa_sub_familias` (`COD_FAMI`, `COD_SUFA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_productos`
--

LOCK TABLES `prod_productos` WRITE;
/*!40000 ALTER TABLE `prod_productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fami_familias`
--

DROP TABLE IF EXISTS `fami_familias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fami_familias` (
  `COD_FAMI` varchar(5) NOT NULL,
  `NOMBRE_FAMI` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`COD_FAMI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fami_familias`
--

LOCK TABLES `fami_familias` WRITE;
/*!40000 ALTER TABLE `fami_familias` DISABLE KEYS */;
/*!40000 ALTER TABLE `fami_familias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usua_usuarios`
--

DROP TABLE IF EXISTS `usua_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usua_usuarios` (
  `ID_ELEM` bigint(20) NOT NULL,
  `NOMBRE_USUA` varchar(255) DEFAULT NULL,
  `USUA_USUA` varchar(255) DEFAULT NULL,
  `PASS_USUA` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_ELEM`),
  KEY `FK_USUA_ELEM` (`ID_ELEM`),
  CONSTRAINT `FK_USUA_ELEM` FOREIGN KEY (`ID_ELEM`) REFERENCES `elem_elementos` (`ID_ELEMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usua_usuarios`
--

LOCK TABLES `usua_usuarios` WRITE;
/*!40000 ALTER TABLE `usua_usuarios` DISABLE KEYS */;
INSERT INTO `usua_usuarios` VALUES (52221,'Sistema','SYS','$SYS$'),(52222,'Luis Fernando Valera','admin','admin');
/*!40000 ALTER TABLE `usua_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lgus_logs_usuarios`
--

DROP TABLE IF EXISTS `lgus_logs_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lgus_logs_usuarios` (
  `ID_LOG` bigint(20) NOT NULL,
  `ID_USUA` bigint(20) DEFAULT NULL,
  `FECHA_LOG` date DEFAULT NULL,
  `TEXTO_LOG` longtext,
  PRIMARY KEY (`ID_LOG`),
  KEY `FK_LGUS_USUA` (`ID_USUA`),
  CONSTRAINT `FK_LGUS_USUA` FOREIGN KEY (`ID_USUA`) REFERENCES `usua_usuarios` (`ID_ELEM`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lgus_logs_usuarios`
--

LOCK TABLES `lgus_logs_usuarios` WRITE;
/*!40000 ALTER TABLE `lgus_logs_usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `lgus_logs_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tppe_tipe_pers`
--

DROP TABLE IF EXISTS `tppe_tipe_pers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tppe_tipe_pers` (
  `ID_ELEM` bigint(20) NOT NULL,
  `COD_TIPE` varchar(2) NOT NULL,
  PRIMARY KEY (`ID_ELEM`,`COD_TIPE`),
  KEY `FK_TPPE_PERS` (`ID_ELEM`),
  KEY `FK_TPPE_TIPE` (`COD_TIPE`),
  CONSTRAINT `FK_TPPE_PERS` FOREIGN KEY (`ID_ELEM`) REFERENCES `pers_personas` (`ID_ELEM`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_TPPE_TIPE` FOREIGN KEY (`COD_TIPE`) REFERENCES `tipe_tipo_personas` (`COD_TIPE`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tppe_tipe_pers`
--

LOCK TABLES `tppe_tipe_pers` WRITE;
/*!40000 ALTER TABLE `tppe_tipe_pers` DISABLE KEYS */;
/*!40000 ALTER TABLE `tppe_tipe_pers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sufa_sub_familias`
--

DROP TABLE IF EXISTS `sufa_sub_familias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sufa_sub_familias` (
  `COD_FAMI` varchar(5) NOT NULL,
  `COD_SUFA` varchar(5) NOT NULL,
  `NOMBRE_SUFA` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`COD_FAMI`,`COD_SUFA`),
  KEY `FK_SUFA_FAMI` (`COD_FAMI`),
  CONSTRAINT `FK_SUFA_FAMI` FOREIGN KEY (`COD_FAMI`) REFERENCES `fami_familias` (`COD_FAMI`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sufa_sub_familias`
--

LOCK TABLES `sufa_sub_familias` WRITE;
/*!40000 ALTER TABLE `sufa_sub_familias` DISABLE KEYS */;
/*!40000 ALTER TABLE `sufa_sub_familias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caja_cajas`
--

DROP TABLE IF EXISTS `caja_cajas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caja_cajas` (
  `ID_ELEM` bigint(20) NOT NULL,
  `COD_CAJA` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID_ELEM`),
  KEY `FK_CAJA_ELEM` (`ID_ELEM`),
  CONSTRAINT `FK_CAJA_ELEM` FOREIGN KEY (`ID_ELEM`) REFERENCES `elem_elementos` (`ID_ELEMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caja_cajas`
--

LOCK TABLES `caja_cajas` WRITE;
/*!40000 ALTER TABLE `caja_cajas` DISABLE KEYS */;
/*!40000 ALTER TABLE `caja_cajas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cntd_contador_tido`
--

DROP TABLE IF EXISTS `cntd_contador_tido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cntd_contador_tido` (
  `COD_TIDO` varchar(3) NOT NULL,
  `ANYO_CNTD` int(11) NOT NULL DEFAULT '0',
  `CONTADOR_CNTD` int(11) DEFAULT '0',
  PRIMARY KEY (`COD_TIDO`,`ANYO_CNTD`),
  KEY `FK_CNTD_TIDO` (`COD_TIDO`),
  CONSTRAINT `FK_CNTD_TIDO` FOREIGN KEY (`COD_TIDO`) REFERENCES `tido_tipo_documento` (`COD_TIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cntd_contador_tido`
--

LOCK TABLES `cntd_contador_tido` WRITE;
/*!40000 ALTER TABLE `cntd_contador_tido` DISABLE KEYS */;
/*!40000 ALTER TABLE `cntd_contador_tido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tido_tipo_documento`
--

DROP TABLE IF EXISTS `tido_tipo_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tido_tipo_documento` (
  `COD_TIDO` varchar(3) NOT NULL,
  `DESCR_TIDO` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`COD_TIDO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tido_tipo_documento`
--

LOCK TABLES `tido_tipo_documento` WRITE;
/*!40000 ALTER TABLE `tido_tipo_documento` DISABLE KEYS */;
INSERT INTO `tido_tipo_documento` VALUES ('F','Factura a cliente'),('T','Ticket a cliente');
/*!40000 ALTER TABLE `tido_tipo_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipe_tipo_personas`
--

DROP TABLE IF EXISTS `tipe_tipo_personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipe_tipo_personas` (
  `COD_TIPE` varchar(2) NOT NULL,
  `DESC_TIPE` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`COD_TIPE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipe_tipo_personas`
--

LOCK TABLES `tipe_tipo_personas` WRITE;
/*!40000 ALTER TABLE `tipe_tipo_personas` DISABLE KEYS */;
INSERT INTO `tipe_tipo_personas` VALUES ('CL','Clientes'),('PR','Proveedores');
/*!40000 ALTER TABLE `tipe_tipo_personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cado_cabecera_documento`
--

DROP TABLE IF EXISTS `cado_cabecera_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cado_cabecera_documento` (
  `ID_ELEM` bigint(20) NOT NULL,
  `COD_TIDO` varchar(3) DEFAULT NULL,
  `NUMERO_CADO` int(11) DEFAULT NULL,
  `ANYO_CADO` int(11) DEFAULT NULL,
  `FECHA_SYSTEMA_CADO` date DEFAULT NULL,
  `FECHA_ENTRADA_CADO` date DEFAULT NULL,
  `ID_ELEM_PERS` bigint(20) DEFAULT NULL,
  `PAGADO_CADO` double DEFAULT '0' COMMENT 'Cantidad pagada del documento\n',
  `TOTAL_CADO` double DEFAULT NULL,
  PRIMARY KEY (`ID_ELEM`),
  KEY `IN_TIDO` (`COD_TIDO`,`ID_ELEM`),
  KEY `FK_CADO_TIDO` (`COD_TIDO`),
  KEY `FK_CADO_ELEM` (`ID_ELEM`),
  KEY `FK_CADO_PERS` (`ID_ELEM_PERS`),
  CONSTRAINT `FK_CADO_ELEM` FOREIGN KEY (`ID_ELEM`) REFERENCES `elem_elementos` (`ID_ELEMENTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_CADO_PERS` FOREIGN KEY (`ID_ELEM_PERS`) REFERENCES `pers_personas` (`ID_ELEM`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_CADO_TIDO` FOREIGN KEY (`COD_TIDO`) REFERENCES `tido_tipo_documento` (`COD_TIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cado_cabecera_documento`
--

LOCK TABLES `cado_cabecera_documento` WRITE;
/*!40000 ALTER TABLE `cado_cabecera_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `cado_cabecera_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `elem_elementos`
--

DROP TABLE IF EXISTS `elem_elementos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `elem_elementos` (
  `ID_ELEMENTO` bigint(20) NOT NULL,
  `COD_TIEL` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`ID_ELEMENTO`),
  KEY `FK_ELEM_TIEL` (`COD_TIEL`),
  CONSTRAINT `FK_ELEM_TIEL` FOREIGN KEY (`COD_TIEL`) REFERENCES `tiel_tipo_elemento` (`COD_TIEL`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `elem_elementos`
--

LOCK TABLES `elem_elementos` WRITE;
/*!40000 ALTER TABLE `elem_elementos` DISABLE KEYS */;
INSERT INTO `elem_elementos` VALUES (1001000000,'PER'),(52221,'USA'),(52222,'USA');
/*!40000 ALTER TABLE `elem_elementos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiel_tipo_elemento`
--

DROP TABLE IF EXISTS `tiel_tipo_elemento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiel_tipo_elemento` (
  `COD_TIEL` varchar(3) NOT NULL,
  `DESCR_TIEL` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`COD_TIEL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiel_tipo_elemento`
--

LOCK TABLES `tiel_tipo_elemento` WRITE;
/*!40000 ALTER TABLE `tiel_tipo_elemento` DISABLE KEYS */;
INSERT INTO `tiel_tipo_elemento` VALUES ('DOC','Documentos'),('LID','Lineas documentos'),('PER','Personas'),('PR','Productos'),('PRE','Precios de productos'),('USA','Usuarios');
/*!40000 ALTER TABLE `tiel_tipo_elemento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2010-11-07 21:51:55
