-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sudriaautomotores
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `car`
--

DROP TABLE IF EXISTS `car`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `car` (
  `id_car` int NOT NULL AUTO_INCREMENT,
  `id_car_brand` int NOT NULL,
  `id_car_model` int NOT NULL,
  `id_car_type` int NOT NULL,
  `id_car_fuel` int NOT NULL,
  `km` int NOT NULL,
  `year` int NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `priority` tinyint NOT NULL DEFAULT '0',
  `actived` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_car`),
  KEY `fk_car_brand_idx` (`id_car_brand`),
  KEY `fk_car_model_idx` (`id_car_model`),
  KEY `fk_car_type_idx` (`id_car_type`),
  KEY `fk_car_fuel_idx` (`id_car_fuel`),
  CONSTRAINT `fk_car_brand` FOREIGN KEY (`id_car_brand`) REFERENCES `car_brands` (`id_car_brand`),
  CONSTRAINT `fk_car_fuel` FOREIGN KEY (`id_car_fuel`) REFERENCES `car_fuel` (`id_car_fuel`),
  CONSTRAINT `fk_car_model` FOREIGN KEY (`id_car_model`) REFERENCES `car_models` (`id_car_model`),
  CONSTRAINT `fk_car_type` FOREIGN KEY (`id_car_type`) REFERENCES `car_type` (`id_car_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `car`
--

LOCK TABLES `car` WRITE;
/*!40000 ALTER TABLE `car` DISABLE KEYS */;
/*!40000 ALTER TABLE `car` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-16 13:09:51
