CREATE PROCEDURE [dbo].[insEmdrOrderData]
(
	@RegionID int,
	@TypeID int,
	@GeneratedAt datetime,
	@GeneratedAtLocalTime datetime,
	@IssueDate datetime,
	@IssueDateLocalTime datetime,
	@SolarSystemID int,
	@StationID int,
	@OrderID bigint,
	@Range int,
	@VolEntered bigint,
	@VolRemaining bigint,
	@VolMin bigint,
	@Price float,
	@duration int,
	@bid tinyint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[emdrOrderData] ([RegionID], [TypeID], [GeneratedAt], [GeneratedAtLocalTime], [IssueDate], [IssueDateLocalTime], [SolarSystemID], [StationID], [OrderID], [Range], [VolEntered], [VolRemaining], [VolMin], [Price], [duration], [bid]) VALUES (@RegionID, @TypeID, @GeneratedAt, @GeneratedAtLocalTime, @IssueDate, @IssueDateLocalTime, @SolarSystemID, @StationID, @OrderID, @Range, @VolEntered, @VolRemaining, @VolMin, @Price, @duration, @bid)
GO


