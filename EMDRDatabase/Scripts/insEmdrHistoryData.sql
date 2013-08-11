CREATE PROCEDURE [dbo].[insEmdrHistoryData]
(
	@RegionID int,
	@TypeID int,
	@DateUTC datetime,
	@DateLocalTime datetime,
	@Orders int,
	@Quantity bigint,
	@High float,
	@Low float,
	@Average float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[emdrHistoryData] 
	([RegionID], [TypeID], [DateUTC], [DateLocalTime], [Orders], [Quantity], [High], [Low], [Average]) 
	VALUES (@RegionID, @TypeID, @DateUTC, @DateLocalTime, @Orders, @Quantity, @High, @Low, @Average)
GO


