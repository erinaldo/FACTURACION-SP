USE [dbSisSodIna]
GO
/****** Object:  StoredProcedure [dbo].[p_PlanillaEmpleados]    Script Date: 29/02/2016 10:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[p_PlanillaEmpleados]
as

select * from v_PlanillaEmpleados