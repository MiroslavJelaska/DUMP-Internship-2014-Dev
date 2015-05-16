create table Notes(
	Id			int 			not null primary key identity,
	Title		nvarchar(max)	not null,
	Text		nvarchar(max)	not null,
	CreatedOn	datetime2		not null,

	UserId		int 			not null references Users(Id)
)