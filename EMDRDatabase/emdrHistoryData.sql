CREATE TABLE [dbo].[emdrHistoryData](
	[HistoryID] [bigint] IDENTITY(100000,1) NOT NULL,
	[RegionID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[DateUTC] [datetime] NOT NULL,
	[DateLocalTime] [datetime] NOT NULL,
	[Orders] [int] NOT NULL,
	[Quantity] [bigint] NOT NULL,
	[High] [float] NOT NULL,
	[Low] [float] NOT NULL,
	[Average] [float] NOT NULL, 
    CONSTRAINT [PK_emdrHistoryData] PRIMARY KEY ([HistoryID])
) ON [PRIMARY]

GO

CREATE INDEX [IX_emdrHistoryData_RegionID] ON [dbo].[emdrHistoryData] ([RegionID] ASC)

GO

CREATE INDEX [IX_emdrHistoryData_RegionID_TypeID] ON [dbo].[emdrHistoryData] ([RegionID] ASC, [TypeID] ASC)

GO

CREATE INDEX [IX_emdrHistoryData_TypeID] ON [dbo].[emdrHistoryData] ([TypeID] ASC)

GO	
