USE [DailyNews]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNews]    Script Date: 7/20/2020 6:11:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SelectAllNews]
@ReaderId int
as
begin
select News.id , News.Title , news.Details , news.DateAndTime , news.Region , 
news.Author , Observers.Name Observer , Resources.Name Resource , news.Image , news.Video,
News_Readers.IsMyFavourite , News_Readers.IsRated , News_Readers.IsRead , News_Readers.ReaderRate,
[dbo].[GetTotalRate](News.id) TotalRate

from news
inner join News_Readers on News_Readers.ReaderId = @ReaderId

inner join Observers on news.ObserverId = Observers.Id

inner join Resources on news.ResourceId = Resources.Id
end;