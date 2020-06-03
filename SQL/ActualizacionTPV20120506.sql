SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

ALTER SCHEMA `TPV`  DEFAULT CHARACTER SET utf8  DEFAULT COLLATE utf8_general_ci ;

USE `TPV`;



CREATE  TABLE IF NOT EXISTS `TPV`.`weel_web_estado_elemento` (
  `ID_ELEMENTO` BIGINT(20) NOT NULL ,
  `FECHA_ULTIMA_ACTUALIZACION` DATETIME NULL DEFAULT NULL ,
  `FORZAR_ACTUALIZACION` ENUM('S','N') NULL DEFAULT 'N' ,
  `NO_MOSTRAR_WEB` ENUM('S','N') NULL DEFAULT NULL ,
  PRIMARY KEY (`ID_ELEMENTO`) ,
  INDEX `FK_WEEL_ELEM` (`ID_ELEMENTO` ASC) ,
  CONSTRAINT `FK_WEEL_ELEM`
    FOREIGN KEY (`ID_ELEMENTO` )
    REFERENCES `TPV`.`elem_elementos` (`ID_ELEMENTO` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE  TABLE IF NOT EXISTS `TPV`.`care_cab_reservas` (
  `ID_ELEM` BIGINT(20) NOT NULL ,
  `ID_ELEM_CADO` BIGINT(20) NULL DEFAULT NULL ,
  `ID_ELEM_PERS` BIGINT(20) NULL DEFAULT NULL ,
  `COD_ESRE` VARCHAR(3) NULL DEFAULT NULL ,
  `FECHA_GRABACION_CARE` DATETIME NULL DEFAULT NULL ,
  `NUMERO_CADO` VARCHAR(50) NULL DEFAULT NULL ,
  `FECHA_ESRE` DATETIME NULL DEFAULT NULL ,
  PRIMARY KEY (`ID_ELEM`) ,
  INDEX `FK_CARE_ELEM` (`ID_ELEM` ASC) ,
  INDEX `FK_CARE_CADO` (`ID_ELEM_CADO` ASC) ,
  INDEX `FK_CARE_PERS` (`ID_ELEM_PERS` ASC) ,
  INDEX `FK_CARE_ESRE` (`COD_ESRE` ASC) ,
  CONSTRAINT `FK_CARE_ELEM`
    FOREIGN KEY (`ID_ELEM` )
    REFERENCES `TPV`.`elem_elementos` (`ID_ELEMENTO` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CARE_CADO`
    FOREIGN KEY (`ID_ELEM_CADO` )
    REFERENCES `TPV`.`cado_cabecera_documento` (`ID_ELEM` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CARE_PERS`
    FOREIGN KEY (`ID_ELEM_PERS` )
    REFERENCES `TPV`.`pers_personas` (`ID_ELEM` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CARE_ESRE`
    FOREIGN KEY (`COD_ESRE` )
    REFERENCES `TPV`.`esre_estado_reservas` (`COD_ESRE` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE  TABLE IF NOT EXISTS `TPV`.`lire_lin_reservas` (
  `ID_ELEM` BIGINT(20) NOT NULL ,
  `ID_ELEM_CARE` BIGINT(20) NOT NULL ,
  `ID_ELEM_PROD` BIGINT(20) NULL DEFAULT NULL ,
  `DESCRIPCION_PROD` VARCHAR(60) NULL DEFAULT NULL ,
  `CANTIDAD_PROD` DOUBLE NULL DEFAULT NULL ,
  PRIMARY KEY (`ID_ELEM`, `ID_ELEM_CARE`) ,
  INDEX `FK_LIRE_CARE` (`ID_ELEM_CARE` ASC) ,
  INDEX `FK_LIRE_PROD` (`ID_ELEM_PROD` ASC) ,
  INDEX `FK_LIRE_ELEM` (`ID_ELEM` ASC) ,
  CONSTRAINT `FK_LIRE_CARE`
    FOREIGN KEY (`ID_ELEM_CARE` )
    REFERENCES `TPV`.`care_cab_reservas` (`ID_ELEM` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_LIRE_PROD`
    FOREIGN KEY (`ID_ELEM_PROD` )
    REFERENCES `TPV`.`prod_productos` (`ID_ELEM` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_LIRE_ELEM`
    FOREIGN KEY (`ID_ELEM` )
    REFERENCES `TPV`.`elem_elementos` (`ID_ELEMENTO` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE  TABLE IF NOT EXISTS `TPV`.`esre_estado_reservas` (
  `COD_ESRE` VARCHAR(3) NOT NULL ,
  `DESCR_ESRE` VARCHAR(60) NULL DEFAULT NULL ,
  PRIMARY KEY (`COD_ESRE`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE  TABLE IF NOT EXISTS `TPV`.`moca_movimientos_caja` (
  `ID_ELEM` BIGINT(20) NOT NULL ,
  `ID_ELEM_CAB` BIGINT(20) NOT NULL ,
  `ID_ELEM_CADO` BIGINT(20) NULL DEFAULT NULL ,
  `FECHA_MOCA` DATETIME NULL DEFAULT NULL ,
  `ENTRADA_MOCA` DOUBLE NULL DEFAULT NULL ,
  `SALIDA_MOCA` DOUBLE NULL DEFAULT NULL ,
  PRIMARY KEY (`ID_ELEM`, `ID_ELEM_CAB`) ,
  INDEX `FK_MOCA_CAJA` (`ID_ELEM_CAB` ASC) ,
  INDEX `FK_MOCA_CADO` (`ID_ELEM_CADO` ASC) ,
  INDEX `FK_MOCA_ELEM` (`ID_ELEM` ASC) ,
  CONSTRAINT `FK_MOCA_CAJA`
    FOREIGN KEY (`ID_ELEM_CAB` )
    REFERENCES `TPV`.`caja_cajas` (`ID_ELEM` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_MOCA_CADO`
    FOREIGN KEY (`ID_ELEM_CADO` )
    REFERENCES `TPV`.`cado_cabecera_documento` (`ID_ELEM` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_MOCA_ELEM`
    FOREIGN KEY (`ID_ELEM` )
    REFERENCES `TPV`.`elem_elementos` (`ID_ELEMENTO` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;