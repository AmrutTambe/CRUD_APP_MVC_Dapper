USE [CarDB]
GO

/****** Object:  StoredProcedure [dbo].[GetCars]    Script Date: 16-11-2021 16:59:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create Procedure [dbo].[GetCars]  
as  
begin  
select Id as ID,CarName,CarModel, Company,Price from Cars
End  
GO


