USE [dbSisSodIna]
GO
/****** Object:  StoredProcedure [dbo].[p_CantidadMinima]    Script Date: 29/02/2016 10:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/* Procedimiento Almacenado para pasar la informacion al reporte. */
CREATE  proc [dbo].[p_CantidadMinima]
as

select * from v_InventarioMinimo


