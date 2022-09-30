CREATE PROCEDURE [dbo].[UpdateCustomer] (@Id int,@Address nvarchar(max),@City nvarchar(max),@PhoneNumber nvarchar(max),@FullName nvarchar(max)) as 
begin
UPDATE Customers SET [Address]=@Address, City=@City,PhoneNumber=@PhoneNumber,FullName=@FullName where Id = @Id;
end