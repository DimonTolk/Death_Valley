CREATE TABLE [dbo].[Points]
(
	[PointId] INT NOT NULL IDENTITY,
	[ChartID] INT NOT NULL,
	[PointX] INT NOT NULL,
	[Pointy] INT NOT NULL,
	PRIMARY KEY ([PointId] ASC),
	FOREIGN KEY ([ChartId]) REFERENCES [dbo].[UserData] ([UserDataId]) ON DELETE CASCADE
)
