CREATE PROCEDURE [dbo].[UpdateCategory] (@Id int, @CategoryName nvarchar(max),@Description nvarchar(max)) as
begin
UPDATE Categories SET CategoryName=@CategoryName, [Description]=@Description where Id = @Id;
end