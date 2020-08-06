use DailyNews
go
create procedure SelectAllNews
@ReaderId int
as
begin
select News.id , News.Title , news.Details , news.DateAndTime , news.Region , 
news.Author , Observers.Name Observer , Resources.Name Resource , news.Image , news.Video,
News_Readers.IsMyFavourite , News_Readers.IsRated , News_Readers.IsRead , News_Readers.ReaderRate,
[dbo].[GetTotalRate](News.id)

from news
inner join News_Readers on News_Readers.ReaderId = @ReaderId

inner join Observers on news.ObserverId = Observers.Id

inner join Resources on news.ResourceId = Resources.Id
end;