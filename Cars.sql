use [CarDB]
go

create proc [dbo].[cars]
(
@CarName nvarchar(50),
@CarModel nvarchar(50),
@Company nvarchar(50),
@Price int
)
as
begin
Insert into Cars values(@CarName,@CarModel,@Company, @Price)
End 