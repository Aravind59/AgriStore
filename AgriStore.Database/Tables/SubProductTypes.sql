
CREATE TABLE [dbo].[SubProductTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ProductTypeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SubProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SubProductTypes]  WITH CHECK ADD  CONSTRAINT [FK_SubProductTypes_ProductTypes] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
GO

ALTER TABLE [dbo].[SubProductTypes] CHECK CONSTRAINT [FK_SubProductTypes_ProductTypes]
GO


