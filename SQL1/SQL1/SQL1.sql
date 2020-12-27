CREATE TABLE [dbo].[Order]
(
	[orderId] INT NOT NULL IDENTITY, 
    [orderDate] DATETIME NOT NULL, 
    [customerId] INT NOT NULL, 
    CONSTRAINT [PK_Order] PRIMARY KEY ([orderId])
);

CREATE TABLE [dbo].[Customer]
(
	[customerId] INT NOT NULL IDENTITY, 
    [firstName] NVARCHAR(64) NOT NULL, 
    [lastName] NVARCHAR(64) NOT NULL, 
    CONSTRAINT [PK_Customer] PRIMARY KEY ([customerId]) 
);

CREATE TABLE [dbo].[Product]
(
	[productId] INT NOT NULL IDENTITY, 
    [description] VARCHAR(64) NOT NULL, 
    CONSTRAINT [PK_Product] PRIMARY KEY ([productId]) 
);

CREATE TABLE [dbo].[OrderLine]
(
	[orderId] INT NOT NULL, 
    [productId] INT NOT NULL, 
    [quantity] INT NOT NULL, 
    CONSTRAINT [PK_OrderLine] PRIMARY KEY ([orderId], [productId])
);
