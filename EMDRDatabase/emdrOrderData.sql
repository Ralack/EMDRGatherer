CREATE TABLE [dbo].[emdrOrderData](
	[OrderDataID] [bigint] IDENTITY(100000,1) NOT NULL,
	[RegionID] [int] NULL,
	[TypeID] [int] NOT NULL,
	[GeneratedAt] [datetime] NOT NULL,
	[GeneratedAtLocalTime] [datetime] NOT NULL,
	[IssueDate] [datetime] NOT NULL,
	[IssueDateLocalTime] [datetime] NOT NULL,
	[SolarSystemID] [int] NULL,
	[StationID] [int] NOT NULL,
	[OrderID] [bigint] NOT NULL,
	[Range] [int] NOT NULL,
	[VolEntered] [bigint] NOT NULL,
	[VolRemaining] [bigint] NOT NULL,
	[VolMin] [bigint] NOT NULL,
	[Price] [float] NOT NULL,
	[duration] [int] NOT NULL,
	[bid] [tinyint] NOT NULL, 
    CONSTRAINT [PK_emdrOrderData] PRIMARY KEY ([OrderDataID]) 
) ON [PRIMARY]

GO


CREATE INDEX [IX_emdrOrderData_RegionID] ON [dbo].[emdrOrderData] ([RegionID])

GO

CREATE INDEX [IX_emdrOrderData_RegionID_SolarSystemID] ON [dbo].[emdrOrderData] ([RegionID] ASC, [SolarSystemID] ASC)

GO

CREATE INDEX [IX_emdrOrderData_RegionID_SolarSystemID_StationID] ON [dbo].[emdrOrderData] ([RegionID] ASC,[SolarSystemID] ASC,[StationID] ASC)
