
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Price] [numeric](18, 4) NULL,
	[SubProductTypeId] [uniqueidentifier] NOT NULL,
	[QuantityTypeId] [uniqueidentifier] NULL,
	[NetQuantity] [numeric](18, 4) NULL,
	[BrandId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_QuantityTypes] FOREIGN KEY([QuantityTypeId])
REFERENCES [dbo].[QuantityTypes] ([Id])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_QuantityTypes]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_SubProductTypes] FOREIGN KEY([SubProductTypeId])
REFERENCES [dbo].[SubProductTypes] ([Id])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_SubProductTypes]
GO


