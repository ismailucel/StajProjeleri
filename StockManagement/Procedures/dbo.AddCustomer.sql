CREATE PROCEDURE [dbo].[AddCustomer] (@Address nvarchar(max),@City nvarchar(max),@PhoneNumber nvarchar(max),@FullName nvarchar(max)) as 
begin
insert into Customers values (@Address,@City,@PhoneNumber,@FullName);
end