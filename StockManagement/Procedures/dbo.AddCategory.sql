CREATE PROCEDURE [dbo].[AddUser] (@CategoryName nvarchar(max),@Description nvarchar(max)) as 
begin
insert into Categories values (@CategoryName,@Description);
end