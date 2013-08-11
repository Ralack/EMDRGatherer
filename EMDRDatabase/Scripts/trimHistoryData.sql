
-- =============================================
-- Author:		Jason Irvan
-- Create date: 2013-08-09
-- Description:	Deletes all HistoryData that is @TrimDays Old
-- =============================================
CREATE PROCEDURE [dbo].[trimHistoryData]
	@TrimDays int = 0
AS
	SET NOCOUNT OFF;
	DECLARE @CutOffDate DateTime;
	
	SET @CutOffDate =  (SELECT DateAdd(DAY, (0-@TrimDays), SYSUTCDATETIME()));

	 DELETE FROM emdrHistoryData 
		WHERE  ( @CutOffDate > DateUTC);
RETURN 0
