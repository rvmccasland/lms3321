-- MySQL Script generated by MySQL Workbench
-- Tue Apr 23 14:01:12 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema ldbmsrev
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ldbmsrev
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ldbmsrev` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `ldbmsrev` ;

-- -----------------------------------------------------
-- Table `ldbmsrev`.`administrator`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`administrator` (
  `Admin_id` INT(11) NOT NULL,
  `fName` VARCHAR(45) NOT NULL,
  `lName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Admin_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ldbmsrev`.`program`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`program` (
  `Program_id` INT(11) NOT NULL,
  `Program_Title` VARCHAR(45) NOT NULL,
  `Prog_Admin_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Program_id`),
  UNIQUE INDEX `Program_id_UNIQUE` (`Program_id` ASC) VISIBLE,
  INDEX `Prog_Admin_id` (`Prog_Admin_id` ASC) VISIBLE,
  CONSTRAINT `program_ibfk_1`
    FOREIGN KEY (`Prog_Admin_id`)
    REFERENCES `ldbmsrev`.`administrator` (`Admin_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ldbmsrev`.`teacher`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`teacher` (
  `Teacher_id` INT(11) NOT NULL,
  `fName` VARCHAR(45) NOT NULL,
  `lName` VARCHAR(45) NOT NULL,
  `Teacher_Admin_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Teacher_id`),
  UNIQUE INDEX `Teacher_id_UNIQUE` (`Teacher_id` ASC) VISIBLE,
  INDEX `Teacher_Admin_id` (`Teacher_Admin_id` ASC) VISIBLE,
  CONSTRAINT `teacher_ibfk_1`
    FOREIGN KEY (`Teacher_Admin_id`)
    REFERENCES `ldbmsrev`.`administrator` (`Admin_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ldbmsrev`.`student`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`student` (
  `Student_id` INT(11) NOT NULL,
  `fName` VARCHAR(45) NOT NULL,
  `lName` VARCHAR(45) NOT NULL,
  `Birth_Date` DATE NOT NULL,
  `Student_Admin_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Student_id`),
  UNIQUE INDEX `Student_id_UNIQUE` (`Student_id` ASC) VISIBLE,
  INDEX `Student_Admin_id` (`Student_Admin_id` ASC) VISIBLE,
  CONSTRAINT `student_ibfk_1`
    FOREIGN KEY (`Student_Admin_id`)
    REFERENCES `ldbmsrev`.`administrator` (`Admin_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ldbmsrev`.`course`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`course` (
  `Course_id` INT(11) NOT NULL,
  `Course_Title` VARCHAR(45) NOT NULL,
  `Course_Prog_id` INT(11) NULL DEFAULT NULL,
  `Course_Teacher_id` INT(11) NULL DEFAULT NULL,
  `Course_Student_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Course_id`),
  UNIQUE INDEX `course_id_UNIQUE` (`Course_id` ASC) VISIBLE,
  INDEX `Course_Prog_id` (`Course_Prog_id` ASC) VISIBLE,
  INDEX `Course_Teacher_id` (`Course_Teacher_id` ASC) VISIBLE,
  INDEX `Course_Student_id` (`Course_Student_id` ASC) VISIBLE,
  CONSTRAINT `course_ibfk_1`
    FOREIGN KEY (`Course_Prog_id`)
    REFERENCES `ldbmsrev`.`program` (`Program_id`),
  CONSTRAINT `course_ibfk_2`
    FOREIGN KEY (`Course_Teacher_id`)
    REFERENCES `ldbmsrev`.`teacher` (`Teacher_id`),
  CONSTRAINT `course_ibfk_3`
    FOREIGN KEY (`Course_Student_id`)
    REFERENCES `ldbmsrev`.`student` (`Student_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ldbmsrev`.`enrolls`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`enrolls` (
  `Enrolmentl_id` INT(11) NOT NULL,
  `Grade` CHAR(1) NULL DEFAULT NULL,
  `Student_Enroll_id` INT(11) NULL DEFAULT NULL,
  `Course_Enroll_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Enrolmentl_id`),
  INDEX `Student_Enroll_id` (`Student_Enroll_id` ASC) VISIBLE,
  INDEX `Course_Enroll_id` (`Course_Enroll_id` ASC) VISIBLE,
  CONSTRAINT `enrolls_ibfk_1`
    FOREIGN KEY (`Student_Enroll_id`)
    REFERENCES `ldbmsrev`.`student` (`Student_id`),
  CONSTRAINT `enrolls_ibfk_2`
    FOREIGN KEY (`Course_Enroll_id`)
    REFERENCES `ldbmsrev`.`course` (`Course_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ldbmsrev`.`teaches`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ldbmsrev`.`teaches` (
  `Attendance` CHAR(1) NOT NULL,
  `Teacher_Attendance_id` INT(11) NULL DEFAULT NULL,
  `Course_Attendance_id` INT(11) NULL DEFAULT NULL,
  `Student_Attendance_id` INT(11) NULL DEFAULT NULL,
  `Attendance_Date` DATE NOT NULL,
  PRIMARY KEY (`Attendance_Date`),
  INDEX `Teacher_Attendance_id` (`Teacher_Attendance_id` ASC) VISIBLE,
  INDEX `Student_Attendance_id` (`Student_Attendance_id` ASC) VISIBLE,
  INDEX `Course_Attendance_id` (`Course_Attendance_id` ASC) VISIBLE,
  CONSTRAINT `teaches_ibfk_1`
    FOREIGN KEY (`Teacher_Attendance_id`)
    REFERENCES `ldbmsrev`.`teacher` (`Teacher_id`),
  CONSTRAINT `teaches_ibfk_2`
    FOREIGN KEY (`Student_Attendance_id`)
    REFERENCES `ldbmsrev`.`student` (`Student_id`),
  CONSTRAINT `teaches_ibfk_3`
    FOREIGN KEY (`Course_Attendance_id`)
    REFERENCES `ldbmsrev`.`course` (`Course_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
