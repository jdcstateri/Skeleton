USE [p2792783]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblProduct_FilterByItemId]
		@ItemId = 6

SELECT	@return_value as 'Return Value'

GO
