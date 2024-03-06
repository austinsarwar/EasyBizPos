-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: easybiz
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_code` varchar(255) NOT NULL,
  `customer_name` varchar(255) NOT NULL,
  `phone_number` varchar(255) DEFAULT NULL,
  `email_address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoice` (
  `invoice_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `payment_type` varchar(255) NOT NULL,
  `total_amount` decimal(10,2) NOT NULL,
  `amount_tendered` decimal(10,2) NOT NULL,
  `bank_account_name` varchar(255) DEFAULT NULL,
  `bank_account_number` varchar(255) DEFAULT NULL,
  `date_recorded` date DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`invoice_id`),
  KEY `invoice_users_FK` (`user_id`),
  KEY `invoice_customers_FK` (`customer_id`),
  CONSTRAINT `invoice_customers_FK` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`),
  CONSTRAINT `invoice_users_FK` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `product_id` int(11) NOT NULL AUTO_INCREMENT,
  `product_code` varchar(255) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `company` varchar(255) NOT NULL,
  `number_in_stock` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `cost` decimal(10,2) NOT NULL,
  `case_size` int(11) NOT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'012345678901','Potato Chips','Lays',100,1.50,0.75,24),(2,'123456789012','Tortilla Chips','Doritos',80,2.00,1.00,24),(3,'234567890123','Cola','Coca-Cola',120,1.00,0.50,12),(4,'345678901234','Lemon-Lime Soda','Sprite',100,1.00,0.50,12),(5,'456789012345','Chocolate Bar','Hershey',75,1.25,0.60,6),(6,'567890123456','Gummy Bears','Haribo',90,0.75,0.35,6),(7,'678901234567','Coffee','Starbucks',60,2.50,1.20,6),(8,'789012345678','Energy Drink','Red Bull',50,3.00,1.50,6),(9,'890123456789','Juice Box','Minute Maid',70,1.50,0.75,12),(10,'901234567890','Sports Drink','Gatorade',80,2.00,1.00,12),(11,'012345678912','Crackers','Ritz',85,1.25,0.60,6),(12,'123456789123','Popcorn','Orville Redenbacher',95,1.75,0.90,6),(13,'234567891234','Ice Cream','Ben & Jerrys',55,3.50,1.75,6),(14,'345678912345','Popsicle','Popsicle',65,1.00,0.50,6),(15,'456789123456','Granola Bar','Nature Valley',90,1.25,0.60,6),(16,'567891234567','Trail Mix','Planters',75,1.75,0.85,6),(17,'678912345678','Bottled Water','Dasani',110,1.00,0.50,24),(18,'789123456789','Flavored Water','Propel',100,1.25,0.60,24),(19,'890123456790','Yogurt','Chobani',65,1.75,0.85,6),(20,'901234567901','Pudding Cup','Jell-O',85,1.50,0.70,6),(21,'012345678923','Sandwich','Jimmy Johns',45,4.50,2.25,6),(22,'123456789134','Hot Dog','Nathans Famous',50,3.00,1.50,6),(23,'234567891245','Pizza Slice','Dominos',40,2.50,1.25,6),(24,'345678912356','Burrito','Taco Bell',30,2.00,1.00,6),(25,'456789123467','Donut','Krispy Kreme',60,1.25,0.60,6),(26,'567891234578','Muffin','Dunkin Donuts',55,1.50,0.70,6),(27,'678912345689','Bag of Chips','Lays',80,1.50,0.75,6),(28,'789123456790','Bottle of Soda','Coca-Cola',100,1.00,0.50,12),(29,'890123456901','Candy Bar','Hershey',70,1.25,0.60,6),(30,'901234567912','Cotton Candy','Carnival',65,2.00,1.00,6),(31,'012345678934','Cold Brew Coffee','Starbucks',50,3.00,1.50,6),(32,'123456789145','Frozen Lemonade','Minute Maid',55,1.75,0.85,6),(33,'234567891256','Pink Lemonade','Country Time',60,1.50,0.75,6),(34,'345678912367','Pina Colada Mix','Master of Mixes',40,2.50,1.25,6),(35,'456789123478','Honey Roasted Peanuts','Planters',75,1.75,0.85,6),(36,'567891234589','Honey','Nature Nates',60,3.00,1.50,6),(37,'678912345690','Soft Drink','Pepsi',90,1.25,0.60,6),(38,'789123456901','Soft Pretzel','Auntie Annes',55,2.00,1.00,6),(39,'890123456912','Protein Bar','Quest',80,2.50,1.25,6),(40,'901234567923','Protein Shake','Premier Protein',70,3.00,1.50,6),(41,'012345678945','Cookie','Chips Ahoy!',85,1.00,0.50,6);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sales` (
  `sales_id` int(11) NOT NULL AUTO_INCREMENT,
  `invoice_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `unit_price` decimal(10,2) NOT NULL,
  `sub_total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`sales_id`),
  KEY `sales_invoice_FK` (`invoice_id`),
  KEY `sales_products_FK` (`product_id`),
  CONSTRAINT `sales_invoice_FK` FOREIGN KEY (`invoice_id`) REFERENCES `invoice` (`invoice_id`),
  CONSTRAINT `sales_products_FK` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'jdoe','hash1','John Doe'),(2,'jsmith','hash2','Jane Smith'),(3,'ajohnson','hash3','Alice Johnson'),(4,'bbrown','hash4','Bob Brown'),(5,'ewilson','hash5','Eve Wilson');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'easybiz'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-03-05 18:40:01
