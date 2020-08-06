create function GetTotalRate(@NewsId int)
returns int as
begin
declare @Total int, @Count int;
select @Total = sum(ReaderRate), @Count = count(ReaderRate) from News_Readers where IsRated = 1 and NewsId = @NewsId;
return @Total/@Count;
end;