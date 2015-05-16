create table Users(
	Id				int 			not null primary key identity,
	FullName		nvarchar(max)	not null,
	IsPremiumUser	bit				not null,
	CreatedOn		datetime2		not null
)