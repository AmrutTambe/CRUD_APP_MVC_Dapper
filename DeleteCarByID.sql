USE [CarDB]
GO

/****** Object:  StoredProcedure [dbo].[DeleteCarById]    Script Date: 16-11-2021 16:55:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[DeleteCarById]
(
@ID int
)
as
begin
Delete from Cars where Id=@ID
End 
GO


