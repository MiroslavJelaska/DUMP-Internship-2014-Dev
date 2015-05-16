create table Comments(
	Id			int 			not null primary key identity,
	Text		nvarchar(max)	not null,
	CreatedOn	datetime2		not null,

	NoteId		int				not null references Notes(Id),
	UserId		int 			not null references Users(Id)
)