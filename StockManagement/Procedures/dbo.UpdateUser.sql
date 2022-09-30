CREATE PROCEDURE [dbo].[UpdateUser] (@Id int,@Address nvarchar(max),@City nvarchar(max),@Password nvarchar(max),@FullName nvarchar(max),@UserName nvarchar(max)) as 
begin
UPDATE Users SET [Address]=@Address, City=@City,[Password]=@Password,FullName=@FullName,UserName=@UserName where Id = @Id;
end