USE [dbSisSodIna]
GO

/****** Object:  View [dbo].[v_InventarioCantidad]    Script Date: 29/02/2016 11:01:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create view [dbo].[v_InventarioCantidad] as

select ig.idIngrediente, ig.nombre, iv.cantidad, Ig.precioCompra from tbInventario Iv
Inner join tbIngredientes Ig ON Ig.idIngrediente = Iv.idIngrediente
 
GO


