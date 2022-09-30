CREATE PROCEDURE [dbo].[AddUser] (@Address nvarchar(max),@City nvarchar(max),@Password nvarchar(max),@FullName nvarchar(max),@UserName nvarchar(max)) as 
begin
insert into Users values (@Address,@City,@Password,@FullName,@UserName);
end