-- =============================================
-- Author:		Jason Irvan
-- Create date: 2013-08-06
-- Description:	Merges EMDR updates
-- =============================================
CREATE PROCEDURE [dbo].[mergeEMDROrderData] 
	-- Add the parameters for the stored procedure here
	@RegionID int, 
	@TypeID int,
	@GeneratedAt DateTime,
	@GeneratedAtLocalTime DateTime,
	@IssueDate DateTime,
	@IssueDateLocalTime DateTime,
	@SolareSysteID int,
	@StationID int,
	@OrderID bigint,
	@Range int,
	@VolEntered bigint,
	@VolRemaining bigint,
	@VolMin bigint,
	@Price float,
	@duration int,
	@bid tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    MERGE emdrOrderData AS t
		USING (SELECT @RegionID, @TypeID,@GeneratedAt,@GeneratedAtLocalTime,@IssueDate,
			@IssueDateLocalTime,@SolareSysteID,@StationID,@OrderID,@Range,@VolEntered,
			@VolRemaining,@VolMin,@Price,@duration,@bid)
			AS s ( RegionID, TypeID,GeneratedAt,GeneratedAtLocalTime,IssueDate,
			IssueDateLocalTime,SolareSysteID,StationID,OrderID,[Range],VolEntered,
			VolRemaining,VolMin,Price,duration,bid)
		ON t.OrderID = s.OrderID
	WHEN MATCHED AND (t.GeneratedAt < s.GeneratedAt) THEN
		UPDATE SET 
		t.RegionID = s.RegionID, 
		t.TypeID = s.TypeID,
		t.GeneratedAt = s.GeneratedAt,
		t.GeneratedAtLocalTime = s.GeneratedAtLocalTime,
		t.IssueDate = s.IssueDate,
		t.IssueDateLocalTime = s.IssueDateLocalTime,
		t.SolarSystemID = s.SolareSysteID,
		t.StationID = s.StationID,
		t.OrderID = s.OrderID,
		t.[Range] = s.[Range],
		t.VolEntered = s.VolEntered,
		t.VolRemaining = s.VolRemaining,
		t.VolMin = s.VolMin,
		t.Price = s.Price,
		t.duration = s.duration,
		t.bid = s.bid
	WHEN NOT MATCHED THEN
		INSERT 
           ([RegionID]
           ,[TypeID]
           ,[GeneratedAt]
           ,[GeneratedAtLocalTime]
           ,[IssueDate]
           ,[IssueDateLocalTime]
           ,[SolarSystemID]
           ,[StationID]
           ,[OrderID]
           ,[Range]
           ,[VolEntered]
           ,[VolRemaining]
           ,[VolMin]
           ,[Price]
           ,[duration]
           ,[bid])
     VALUES
		(s.RegionID, 
		s.TypeID,
		s.GeneratedAt,
		s.GeneratedAtLocalTime,
		s.IssueDate,
		s.IssueDateLocalTime,
		s.SolareSysteID,
		s.StationID,
		s.OrderID,
		s.[Range],
		s.VolEntered,
		s.VolRemaining,
		s.VolMin,
		s.Price,
		s.duration,
		s.bid);
END

GO


