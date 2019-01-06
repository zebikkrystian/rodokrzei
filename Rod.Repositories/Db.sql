
create table dbo.SystemLogs 
(
	Id int Identity(1,1) not null,
	IpAddress nvarchar(30) null,
	AccessDate DateTime not null CONSTRAINT [DF_SystemLogs@AccessDate] Default getdate()

	CONSTRAINT [PK_SystemLogs] PRIMARY KEY CLUSTERED 
	( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


create table dbo.Users 
(
	Id int Identity(1,1) not null,
	UserName nvarchar(30) not null,
	[Password] nvarchar(255) not null,
	EditDate DateTime not null CONSTRAINT [DF_Users@EditDate] Default getdate(),


	CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
	( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


create table dbo.Posts 
(
	Id int Identity(1,1) not null,
	Title nvarchar(200) null,
	Content nvarchar(500) null,
	[Day] DateTime not null,
	IsVisible bit not null CONSTRAINT [DF_Posts@IsVisible] Default 0,
	IdUser int not null,
	EditDate DateTime not null CONSTRAINT [DF_Posts@EditDate] Default getdate()

	CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
	( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].Posts  WITH CHECK ADD  CONSTRAINT [FK_Posts@IdUser_Users@Id] FOREIGN KEY(IdUser)
REFERENCES [dbo].Users ([Id])
GO
ALTER TABLE [dbo].Posts CHECK CONSTRAINT [FK_Posts@IdUser_Users@Id]
GO