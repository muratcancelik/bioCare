-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: eva
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Temporary view structure for view `satis_urun_musteri_personel`
--

DROP TABLE IF EXISTS `satis_urun_musteri_personel`;
/*!50001 DROP VIEW IF EXISTS `satis_urun_musteri_personel`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `satis_urun_musteri_personel` AS SELECT 
 1 AS `Satis No`,
 1 AS `Urun Ad`,
 1 AS `Musteri`,
 1 AS `Personel`,
 1 AS `Fiyat`,
 1 AS `Tarih`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `kategori_urun`
--

DROP TABLE IF EXISTS `kategori_urun`;
/*!50001 DROP VIEW IF EXISTS `kategori_urun`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `kategori_urun` AS SELECT 
 1 AS `Urun No`,
 1 AS `Urun Ad`,
 1 AS `Marka`,
 1 AS `Aciklama`,
 1 AS `Kategori`,
 1 AS `Stok`,
 1 AS `Fiyat`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `satisloggoster`
--

DROP TABLE IF EXISTS `satisloggoster`;
/*!50001 DROP VIEW IF EXISTS `satisloggoster`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `satisloggoster` AS SELECT 
 1 AS `Satis No`,
 1 AS `Musteri`,
 1 AS `Personel`,
 1 AS `Urun`,
 1 AS `Aciklama`,
 1 AS `Tarih`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `musterilog_goster`
--

DROP TABLE IF EXISTS `musterilog_goster`;
/*!50001 DROP VIEW IF EXISTS `musterilog_goster`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `musterilog_goster` AS SELECT 
 1 AS `Musteri No`,
 1 AS `Musteri Ad Soyad`,
 1 AS `Yapilan Islem`,
 1 AS `Tarih`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `urunloggoster`
--

DROP TABLE IF EXISTS `urunloggoster`;
/*!50001 DROP VIEW IF EXISTS `urunloggoster`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `urunloggoster` AS SELECT 
 1 AS `Urun Ad`,
 1 AS `Aciklama`,
 1 AS `Tarih`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `personel_departman_maas`
--

DROP TABLE IF EXISTS `personel_departman_maas`;
/*!50001 DROP VIEW IF EXISTS `personel_departman_maas`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `personel_departman_maas` AS SELECT 
 1 AS `Numara`,
 1 AS `Personel Ad Soyad`,
 1 AS `T.C Kimlik`,
 1 AS `Telefon Numarasi`,
 1 AS `Departman`,
 1 AS `Maas`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `musteri_adsoyad`
--

DROP TABLE IF EXISTS `musteri_adsoyad`;
/*!50001 DROP VIEW IF EXISTS `musteri_adsoyad`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `musteri_adsoyad` AS SELECT 
 1 AS `No`,
 1 AS `AdSoyad`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `satis_urun_musteri_personel`
--

/*!50001 DROP VIEW IF EXISTS `satis_urun_musteri_personel`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `satis_urun_musteri_personel` AS select `satis`.`s_ID` AS `Satis No`,`urun`.`u_Ad` AS `Urun Ad`,concat(`musteri`.`m_Ad`,' ',`musteri`.`m_Soyad`) AS `Musteri`,concat(`personel`.`p_Ad`,' ',`personel`.`p_Soyad`) AS `Personel`,`fiyat`.`f_Fiyat` AS `Fiyat`,`satis`.`s_Tarih` AS `Tarih` from ((((`satis` join `urun` on((`satis`.`s_UrunId` = `urun`.`u_Id`))) join `personel` on((`satis`.`s_PersonelId` = `personel`.`p_Id`))) join `musteri` on((`satis`.`s_MusteriId` = `musteri`.`m_Id`))) join `fiyat` on((`satis`.`s_Fiyat` = `fiyat`.`f_Id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `kategori_urun`
--

/*!50001 DROP VIEW IF EXISTS `kategori_urun`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `kategori_urun` AS select `urun`.`u_Id` AS `Urun No`,`urun`.`u_Ad` AS `Urun Ad`,`marka`.`marka_ad` AS `Marka`,`urun`.`u_Aciklama` AS `Aciklama`,`kategori`.`k_Ad` AS `Kategori`,`urun`.`u_Stok` AS `Stok`,`fiyat`.`f_Fiyat` AS `Fiyat` from (((`urun` join `marka` on((`urun`.`u_Marka` = `marka`.`marka_id`))) join `kategori` on((`urun`.`u_Kategori` = `kategori`.`k_Id`))) join `fiyat` on((`urun`.`U_Fiyat` = `fiyat`.`f_Id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `satisloggoster`
--

/*!50001 DROP VIEW IF EXISTS `satisloggoster`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `satisloggoster` AS select `satislog`.`s_Id` AS `Satis No`,concat(`musteri`.`m_Ad`,' ',`musteri`.`m_Soyad`) AS `Musteri`,concat(`personel`.`p_Ad`,' ',`personel`.`p_Soyad`) AS `Personel`,`urun`.`u_Ad` AS `Urun`,`satislog`.`s_LogIslem` AS `Aciklama`,`satislog`.`s_Tarih` AS `Tarih` from (((`satislog` join `urun` on((`satislog`.`s_UrunId` = `urun`.`u_Id`))) join `personel` on((`satislog`.`s_PersonelId` = `personel`.`p_Id`))) join `musteri` on((`satislog`.`s_MusteriId` = `musteri`.`m_Id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `musterilog_goster`
--

/*!50001 DROP VIEW IF EXISTS `musterilog_goster`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `musterilog_goster` AS select `musterilog`.`m_Id` AS `Musteri No`,concat(`musterilog`.`m_Ad`,' ',`musterilog`.`m_Soyad`) AS `Musteri Ad Soyad`,`musterilog`.`m_LogIslem` AS `Yapilan Islem`,`musterilog`.`m_Tarih` AS `Tarih` from `musterilog` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `urunloggoster`
--

/*!50001 DROP VIEW IF EXISTS `urunloggoster`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `urunloggoster` AS select `urunlog`.`u_Ad` AS `Urun Ad`,`urunlog`.`u_Log` AS `Aciklama`,`urunlog`.`u_Tarih` AS `Tarih` from `urunlog` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `personel_departman_maas`
--

/*!50001 DROP VIEW IF EXISTS `personel_departman_maas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `personel_departman_maas` AS select `personel`.`p_Id` AS `Numara`,concat(`personel`.`p_Ad`,' ',`personel`.`p_Soyad`) AS `Personel Ad Soyad`,`personel`.`p_TcKimlik` AS `T.C Kimlik`,`personel`.`p_TelNO` AS `Telefon Numarasi`,`departman`.`d_Ad` AS `Departman`,`maas`.`m_Maas` AS `Maas` from ((`personel` join `departman` on((`personel`.`p_Departman` = `departman`.`d_Id`))) join `maas` on((`personel`.`p_Maas` = `maas`.`m_ID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `musteri_adsoyad`
--

/*!50001 DROP VIEW IF EXISTS `musteri_adsoyad`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `musteri_adsoyad` AS select `musteri`.`m_Id` AS `No`,concat(`musteri`.`m_Ad`,' ',`musteri`.`m_Soyad`) AS `AdSoyad` from `musteri` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-05 14:42:43
