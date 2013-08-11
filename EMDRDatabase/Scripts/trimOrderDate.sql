
-- =============================================
-- Author:		Jason Irvan
-- Create date: 2013-08-09
-- Description:	Deletes all OrderData that has been completed for 24 hours
-- =============================================
CREATE PROCEDURE trimOrderData 
	@TrimDays int = 0
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
    DELETE FROM emdrOrderData 
		WHERE OrderID IN (
			SELECT OrderID from emdrOrderData
				where (DateAdd(DAY, (duration+@TrimDays), IssueDate ) < SYSUTCDATETIME()));
END
GO
