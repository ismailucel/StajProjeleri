CREATE PROCEDURE [dbo].[AddOrder] (@OrderDate DATETIME,@Quantity float,@ProductId int,@ProductPrice int,@CustomerId int) as 
begin
insert into Orders values (@OrderDate,@Quantity,@ProductId,@ProductPrice,@CustomerId);
end