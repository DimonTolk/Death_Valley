CREATE TABLE [dbo].[UserDatas] (
    [UserDataId] INT        IDENTITY (1, 1) NOT NULL,
    [a]          INT        NOT NULL,
    [b]          INT        NOT NULL,
    [c]          INT        NOT NULL,
    [step]       FLOAT (53) NOT NULL,
    [RangeFrom]  INT        NOT NULL,
    [RangeTo]    INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([UserDataId] ASC)
);

