create type temp as table
(
	Nafn varchar(75),
	Tidni int,
	eignarfall varchar(75),
	eignarfall2 varchar(75)
)
create type stelputable as table
(
	Nafn varchar(75),
	Tidni int
)
--============================================================================================================
--											  STORED PROCEDURES
--============================================================================================================
go
create proc skragotur
@id int
as
begin
declare @Lower int
declare @Upper int
declare @Random int
declare @pn int
declare @nf varchar(75)
declare @hf varchar(75)
declare @rand int

select @Lower = 1
select @Upper = 100
SELECT @rand = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
if @rand <= 33
begin
		select @Lower = MIN(id) from gotur ---- The lowest random number
		select @Upper = MAX(id) from gotur ---- The highest random number
		SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
end

else
begin
		select @Lower = MIN(id) from gotur
		select @Upper = MAX(id) from gotur where gotur.postnumer <= 270
		SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
end

select @pn = (select postnumer from gotur where id = @Random)
select @hf = (select heiti_thagufall from gotur where id = @Random)
select @Lower = 1
select @Upper = 100
SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
set @hf = @hf + STR(@Random)
set @hf = REPLACE(@hf, '        ', ' ')

update nafnogkt
set heimilisfang = @hf
where id = @id

update nafnogkt
set postnr = @pn
where id = @id

end

--Ey�ir �llum g�tum � t�flunni gotur og resettar ID � t�flunni
--exec eydagotur
go
create proc eydagotur
as
begin
delete from gotur
dbcc checkident ('gotur', RESEED, 0) -- resettar ID 
end

--B�r til n�ja g�tu
go
create proc newStreet
@postnumer int,
@heitinf varchar(75),
@heitithf varchar(75)
as
begin
	
	insert into gotur(postnumer,heiti_nefnifall,heiti_thagufall)
	values(@postnumer,@heitinf,@heitithf)
	
end
go

--Setur �ll n�fn inn � t�flu me� t��ni
--N�fnin og t��ni finnast h�r:
--http://hagstofan.is/?PageID=633&src=/temp/Dialog/view.asp?ma=MAN11101%26ti=Eiginn%F6fn+karla+1%2E+jan%FAar+2010++%26path=../Database/mannfjoldi/Nofnkk/%26lang=3%26units=Fj%F6ldi,%20t%ED%F0ni
--exec strakanofn
create proc strakanofn
as
begin
delete from strakaFornofn
declare @strakar as temp
insert into @strakar values('J�n',5442,'J�ns','J�ns')
insert into @strakar values('Sigur�ur',4385,'Sigur�s','Sigur�ar')
insert into @strakar values('Gu�mundur',4137,'Gu�munds','Gu�munds')
insert into @strakar values('Gunnar',3232,'Gunnars','Gunnars')
insert into @strakar values('�lafur',2883,'�lafs','�lafs')
insert into @strakar values('Einar',2530,'Einars','Einars')
insert into @strakar values('Kristj�n',2383,'Kristj�ns','Kristj�ns')
insert into @strakar values('Magn�s',2378,'Magn�s','Magn�s')
insert into @strakar values('Stef�n',2207,'Stef�ns','Stef�ns')
insert into @strakar values('J�hann',1979,'J�hanns','J�hanns')
insert into @strakar values('Bj�rn',1741,'Bj�rns','Bj�rns')
insert into @strakar values('�rni',1643,'�rna','�rna')
insert into @strakar values('Bjarni',1562,'Bjarna','Bjarna')
insert into @strakar values('Helgi',1525,'Helga','Helga')
insert into @strakar values('Arnar',1519,'Arnars', 'Arnars')
insert into @strakar values('Halld�r',1480, 'Halld�rs','Halld�rs')
insert into @strakar values('P�tur',1412,'P�turs','P�turs')
insert into @strakar values('Kristinn',1333,'Kristins','Kristins')
insert into @strakar values('G�sli',1295,'G�sla','G�sla')
insert into @strakar values('Ragnar',1277,'Rangars','Ragnars')
insert into @strakar values('�orsteinn',1245,'�orsteins','�orsteins')
insert into @strakar values('Dan�el',1242,'Dan�els','Dan�els')
insert into @strakar values('Gu�j�n',1184,'Gu�j�ns','Gu�j�ns')
insert into @strakar values('P�ll',1112,'P�ls','P�ls')
insert into @strakar values('Sveinn',1092,'Sveins','Sveins')
insert into @strakar values('Birgir',1047,'Birgis','Birgis')
insert into @strakar values('�skar',1020,'�skars','�skars')
insert into @strakar values('Dav��',1001,'Dav��s','Dav��s')
insert into @strakar values('Andri',947,'Andra','Andra')
insert into @strakar values('Haukur',936,'Hauks','Hauks')
insert into @strakar values('J�hannes',925,'J�hannes','J�hannes')
insert into @strakar values('Karl',919,'Karls','Karls')
insert into @strakar values('R�bert',896,'R�berts','R�berts')
insert into @strakar values('Aron',885,'Arons','Arons')
insert into @strakar values('�g�st',874,'�g�sts','�g�sts')
insert into @strakar values('�sgeir',871,'�sgeirs','�sgeirs')
insert into @strakar values('Bjarki',844,'Bjarka','Bjarka')
insert into @strakar values('T�mas',837,'T�mas','T�mas')
insert into @strakar values('Haraldur',835,'Haralds','Haralds')
insert into @strakar values('Kjartan',830,'Kjartans','Kjartans')
insert into @strakar values('Sigurj�n',799,'Sigurj�ns','Sigurj�ns')
insert into @strakar values('Fri�rik',782,'Fri�riks','Fri�riks')
insert into @strakar values('��r�ur',781,'��r�ar','��r�ar')
insert into @strakar values('Atli',777,'Atla','Atla')
insert into @strakar values('H�r�ur',773,'Har�ar','Har�ar')
insert into @strakar values('J�nas',756,'J�nas','J�nas')
insert into @strakar values('Brynjar',753,'Brynjar','Brynjar')
insert into @strakar values('Benedikt',740,'Benedikts','Benedikts')
insert into @strakar values('Hilmar',737,'Hilmars','Hilmars')
insert into @strakar values('Viktor',737,'Viktors','Viktors')
insert into @strakar values('Alexander',730,'Alexanders','Alexanders')
insert into @strakar values('Baldur',712,'Baldurs','Baldurs')
insert into @strakar values('R�nar',709,'R�nars','R�nars')
insert into @strakar values('Eir�kur',684,'Eir�ks','Eir�ks')
insert into @strakar values('Egill',662,'Egils','Egils')
insert into @strakar values('Sindri',627,'Sindra','Sindra')
insert into @strakar values('Gu�ni',621,'Gu�na','Gu�na')
insert into @strakar values('Sverrir',619,'Sverris','Sverris')
insert into @strakar values('Bj�rgvin',618,'Bj�rginvs','Bj�rgvins')
insert into @strakar values('Krist�fer',607,'Krist�fers','Krist�fers')
insert into @strakar values('S�var',601,'S�vars','S�vars')
insert into @strakar values('�rn',596,'Arnar','Arnar')
insert into @strakar values('K�ri',593,'K�ra','K�ra')
insert into @strakar values('�mar',577,'�mars','�mars')
insert into @strakar values('Ingvar',559,'Ingvars','Ingvars')
insert into @strakar values('Snorri',557,'Snorra','Snorra')
insert into @strakar values('Reynir',556,'Reynis','Reynis')
insert into @strakar values('Hlynur',550,'Hlyns','Hlyns')
insert into @strakar values('Ing�lfur',536,'Ing�lfs','Ing�lfs')
insert into @strakar values('Elvar',522,'Elvars','Elvars')
insert into @strakar values('��rir',515,'��ris','��ris')
insert into @strakar values('Gar�ar',507,'Gar�ars','Gar�ars')
insert into @strakar values('�var',507,'�vars','�vars')
insert into @strakar values('��rarinn',505,'��rarins','��rarins')
insert into @strakar values('Hafsteinn',504,'Hafsteins','Hafsteins')
insert into @strakar values('Gr�tar',503,'Gr�tars','Gr�tars')
insert into @strakar values('Jakob',499,'Jakobs','Jakobs')
insert into @strakar values('Tryggvi',491,'Tryggva','Tryggva')
insert into @strakar values('Valdimar',482,'Valdimars','Valdimars')
insert into @strakar values('Ingi',476,'Inga','Inga')
insert into @strakar values('Vilhj�lmur',475,'Vilhj�lms','Vilhj�lms')
insert into @strakar values('Axel',467,'Axels','Axels')
insert into @strakar values('Ey��r',466,'Ey��rs','Ey��rs')
insert into @strakar values('Arn�r',464,'Arn�rs','Arn�rs')
insert into @strakar values('Hjalti',461,'Hjalta','Hjalta')
insert into @strakar values('Steinar',460,'Steinars','Steinars')
insert into @strakar values('�sak',459,'�saks','�saks')
insert into @strakar values('Matth�as',458,'Matth�as','Matth�as')
insert into @strakar values('Ari',456,'Ara','Ara')
insert into @strakar values('Anton',449,'Antons','Antons')
insert into @strakar values('Birkir',448,'Birkis','Birkis')
insert into @strakar values('Gunnlaugur',445,'Gunnlaugs','Gunnlaugs')
insert into @strakar values('A�alsteinn',444,'A�alsteins','A�alsteins')
insert into @strakar values('Hermann',439,'Hermanns','Hermanns')
insert into @strakar values('Hj�rtur',425,'Hjartars','Hjartars')
insert into @strakar values('�orvaldur',425,'�orvarlds','�orvalds')
insert into @strakar values('Sk�li',418,'Sk�la','Sk�la')
insert into @strakar values('H�kon',412,'H�kons','H�kons')
insert into @strakar values('Hannes',411,'Hannes','Hannes')
insert into @strakar values('Dagur',406,'Dags','Dags')

declare datacursor cursor
for
	select Nafn, Tidni, Eignarfall, eignarfall2 from @strakar
	
declare @i int
declare @i2 int
declare @i3 int
declare @nafn varchar(75)
declare @ef varchar(75)
declare @ef2 varchar(75)
set @i = 1
set @i2 = 0
set @i3 = 0

open datacursor
fetch next from datacursor into @nafn, @i2, @ef, @ef2
while @@FETCH_STATUS = 0
begin
	insert into strakaFornofn(Nafn) values (@nafn)
	
	update strakaFornofn
	set Tidni1 = @i
	where Nafn = @nafn
	
	update strakaFornofn
	set eignarfall = @ef
	where Nafn = @nafn
	
	update strakaFornofn
	set eignarfall2 = @ef2
	where Nafn = @nafn
	
	set @i = @i + @i2
	set @i3 = @i2 + @i3
	
	update strakaFornofn
	set Tidni2 = @i3
	where Nafn = @nafn
	
	fetch next from datacursor into @nafn, @i2, @ef, @ef2
end

close datacursor
end
go

--Setur �ll n�fn inn � t�flu me� t��ni
--N�fnin og t��ni finnast h�r:
--http://hagstofan.is/?PageID=633&src=/temp/Dialog/view.asp?ma=MAN11111%26ti=Eiginn%F6fn+kvenna+1%2E+jan%FAar+2010++++%26path=../Database/mannfjoldi/Nofnkvk/%26lang=3%26units=Fj%F6ldi,%20t%ED%F0ni
--exec stelpunofn
create proc stelpunofn
as
begin
delete from stelpurFornofn
declare @stelpur as stelputable
insert into @stelpur values('Gu�r�n',5053)
insert into @stelpur values('Anna',4474)
insert into @stelpur values('Sigr��ur',3693)
insert into @stelpur values('Krist�n',3655)
insert into @stelpur values('Margr�t',3011)
insert into @stelpur values('Helga',2842)
insert into @stelpur values('Sigr�n',2609)
insert into @stelpur values('Ingibj�rg',2334)
insert into @stelpur values('J�hanna',1994)
insert into @stelpur values('Mar�a',1920)
insert into @stelpur values('El�n',1634)
insert into @stelpur values('Katr�n',1423)
insert into @stelpur values('Hildur',1362)
insert into @stelpur values('Ragnhei�ur',1332)
insert into @stelpur values('Gu�bj�rg',1316)
insert into @stelpur values('�sta',1312)
insert into @stelpur values('Erla',1294)
insert into @stelpur values('Lilja',1242)
insert into @stelpur values('Gu�n�',1217)
insert into @stelpur values('�l�f',1174)
insert into @stelpur values('Eva',1169)
insert into @stelpur values('El�sabet',1144)
insert into @stelpur values('Hulda',1103)
insert into @stelpur values('Steinunn',1095)
insert into @stelpur values('S�lveig',1068)
insert into @stelpur values('Au�ur',1064)
insert into @stelpur values('Inga',1045)
insert into @stelpur values('��runn',1044)
insert into @stelpur values('Brynd�s',1035)
insert into @stelpur values('Kolbr�n',1026)
insert into @stelpur values('Berglind',1021)
insert into @stelpur values('Unnur',1020)
insert into @stelpur values('�sd�s',991)
insert into @stelpur values('��ra',991)
insert into @stelpur values('Sara',983)
insert into @stelpur values('�ris',928)
insert into @stelpur values('Hrafnhildur',918)
insert into @stelpur values('J�na',917)
insert into @stelpur values('Birna',885)
insert into @stelpur values('Halld�ra',883)
insert into @stelpur values('��rd�s',846)
insert into @stelpur values('Rakel',841)
insert into @stelpur values('Erna',827)
insert into @stelpur values('Linda',779)
insert into @stelpur values('J�n�na',760)
insert into @stelpur values('Valger�ur',751)
insert into @stelpur values('Gu�laug',744)
insert into @stelpur values('Edda',730)
insert into @stelpur values('Sigurbj�rg',730)
insert into @stelpur values('Hanna',723)
insert into @stelpur values('Sandra',706)
insert into @stelpur values('Hafd�s',705)
insert into @stelpur values('Karen',704)
insert into @stelpur values('Kristjana',687)
insert into @stelpur values('Harpa',674)
insert into @stelpur values('Telma/Thelma',651)
insert into @stelpur values('Hj�rd�s',649)
insert into @stelpur values('L�ra',642)
insert into @stelpur values('Tinna',635)
insert into @stelpur values('Brynja',618)
insert into @stelpur values('Stefan�a',606)
insert into @stelpur values('Hrefna',602)
insert into @stelpur values('Andrea',593)
insert into @stelpur values('Helena',593)
insert into @stelpur values('Arna',591)
insert into @stelpur values('H�lmfr��ur',588)
insert into @stelpur values('R�sa',587)
insert into @stelpur values('A�alhei�ur',587)
insert into @stelpur values('Bj�rg',586)
insert into @stelpur values('Ragnhildur',586)
insert into @stelpur values('�slaug',579)
insert into @stelpur values('Halla',566)
insert into @stelpur values('�g�sta',538)
insert into @stelpur values('Dagn�',533)
insert into @stelpur values('Laufey',523)
insert into @stelpur values('S�ley',521)
insert into @stelpur values('Sigurlaug',521)
insert into @stelpur values('An�ta',520)
insert into @stelpur values('Ingunn',517)
insert into @stelpur values('Elsa',488)
insert into @stelpur values('Marta',480)
insert into @stelpur values('Rannveig',480)
insert into @stelpur values('�orbj�rg',477)
insert into @stelpur values('Sunna',475)
insert into @stelpur values('Soff�a',467)
insert into @stelpur values('Svava/Svafa',465)
insert into @stelpur values('Agnes',464)
insert into @stelpur values('Emil�a',463)
insert into @stelpur values('�sa',457)
insert into @stelpur values('Elva',440)
insert into @stelpur values('Ester',435)
insert into @stelpur values('�ur��ur',431)
insert into @stelpur values('Gu�r��ur',429)
insert into @stelpur values('Herd�s',420)
insert into @stelpur values('Fanney',420)
insert into @stelpur values('Vigd�s',413)
insert into @stelpur values('Ragna',404)
insert into @stelpur values('Kristr�n',402)

declare stelpucursor cursor
for
	select Nafn, Tidni from @stelpur
	
declare @n int
declare @n2 int
declare @n3 int
declare @stelpunafn varchar(75)
set @n = 1
set @n2 = 0
set @n3 = 0

open stelpucursor
fetch next from stelpucursor into @stelpunafn, @n2
while @@FETCH_STATUS = 0
begin
	insert into stelpurFornofn(Nafn) values (@stelpunafn)
	update stelpurFornofn
	set Tidni1 = @n
	where Nafn = @stelpunafn
	
	set @n = @n + @n2
	set @n3 = @n2 + @n3
	update stelpurFornofn
	set Tidni2 = @n3
	where Nafn = @stelpunafn
	fetch next from stelpucursor into @stelpunafn, @n2
end

close stelpucursor
end
go

--B�r til fullt nafn
--exec fulltnafnstrakur 1 (fjoldi), 5(age lower limit), 25 (age upper limit)
go
create proc fulltnafnstrakur
@fjoldi int,
@aldur1 int,
@aldur2 int
as
begin
declare @id int
declare @lower int
declare @Upper int
declare @Random int
declare @fornafn varchar(75)
declare @nafn varchar(75)
declare @eftirnafn varchar(75)
declare @numer int
declare @numer2 int
declare @rand int
declare @counter int
declare @ef varchar(75)
declare @ef2 varchar(75)

select @counter = 0
while @fjoldi > @counter
begin
	select @Lower = MIN(Tidni1) from strakaFornofn ---- The lowest random number
	select @Upper = MAX(Tidni2) from strakaFornofn ---- The highest random number
	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	open strakar
	fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
	while @@FETCH_STATUS = 0
	begin
		if @Random between @numer and @numer2
		begin
			set @nafn = @fornafn
		end
		fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
	end
	close strakar

	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	
	select @lower = 0
	select @Upper = 100
	select @rand = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	if @rand <= 30 --30% l�kur � �v� a� nafni� s� me� tv� forn�fn
	begin
		open strakar
		fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
		while @@FETCH_STATUS = 0
		begin
			if @Random between @numer and @numer2
			begin
				if @fornafn != @nafn
				set @nafn = @nafn +' '+ @fornafn
			end
			fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
		end
		close strakar
	end
	
	select @Lower = MIN(Tidni1) from strakaFornofn 
	select @Upper = MAX(Tidni2) from strakaFornofn
	
	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	open strakar
	fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
	while @@FETCH_STATUS = 0
	begin
		if @Random between @numer and @numer2
		begin
			set @nafn = @nafn +' '+@ef+'son'
		end
		fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
	end
	close strakar
	
	insert into nafnogkt(kt,nafn) values(STR(@counter),@nafn)
	select @id = MAX(id) from nafnogkt
	exec kennitala @id, @nafn, @aldur1, @aldur2
	exec skragotur @id

set @counter = @counter + 1
end
end
--exec stelpunofn
--B�r til fullt nafn 
go
create proc fulltnafnstelpur
@fjoldi int,
@aldur1 int,
@aldur2 int
as
begin
declare @id int
declare @lower int
declare @Upper int
declare @Random int
declare @fornafn varchar(75)
declare @nafn varchar(75)
declare @eftirnafn varchar(75)
declare @numer int
declare @numer2 int
declare @rand int
declare @counter int
declare @ef varchar(75)
declare @ef2 varchar(75)	
select @counter = 0
while @fjoldi > @counter
begin
	select @Lower = MIN(Tidni1) from stelpurFornofn ---- The lowest random number
	select @Upper = MAX(Tidni2) from stelpurFornofn ---- The highest random number
	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	open stelpur
	fetch next from stelpur into @fornafn, @numer, @numer2
	while @@FETCH_STATUS = 0
	begin
		if @Random between @numer and @numer2
		begin
			set @nafn = @fornafn
		end
		fetch next from stelpur into @fornafn, @numer, @numer2
	end
	close stelpur

	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	
	select @lower = 0
	select @Upper = 100
	select @rand = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	if @rand <= 30 --30% l�kur � �v� a� nafni� s� me� tv� forn�fn
	begin
		open stelpur
		fetch next from stelpur into @fornafn, @numer, @numer2
		while @@FETCH_STATUS = 0
		begin
			if @Random between @numer and @numer2
			begin
				if @fornafn != @nafn
				set @nafn = @nafn +' '+ @fornafn
			end
			fetch next from stelpur into @fornafn, @numer, @numer2
		end
		close stelpur
	end
	
	select @Lower = MIN(Tidni1) from stelpurFornofn 
	select @Upper = MAX(Tidni2) from stelpurFornofn
	
	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	open strakar
	fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
	while @@FETCH_STATUS = 0
	begin
		if @Random between @numer and @numer2
		begin
			set @nafn = @nafn +' '+@ef2+'d�ttir'
		end
		fetch next from strakar into @fornafn, @numer, @numer2, @ef, @ef2
	end
	close strakar
	insert into nafnogkt(kt,nafn) values(STR(@counter),@nafn)
	select @id = MAX(id) from nafnogkt
	exec kennitala @id, @nafn, @aldur1, @aldur2
	exec skragotur @id
	
set @counter = @counter + 1
end
end

--All-in-one procedure sem b�r til n�fn, kennit�lur og heimilisf�ng og l�mir �au saman
--Notkun: exec nofn fj�ldi karla,fj�ldi kvenna,l�gsti aldur,h�sti aldur
--t.d. exec nofn 10,10,18,68
--select * from nafnogkt
--
--
go
create proc nofn
@karlar int,
@konur int,
@aldur1 int,
@aldur2 int
as
begin

declare @maxid int
declare strakar cursor
for
	select * from strakaFornofn
	
declare stelpur cursor
for
	select * from stelpurFornofn
set nocount on
exec fulltnafnstrakur @karlar, @aldur1, @aldur2
exec fulltnafnstelpur @konur, @aldur1, @aldur2
deallocate strakar
deallocate stelpur
print str(@karlar + @konur) + ' n�fn voru b�in til'
end

 
--Ey�ir str�kanafni
go
create proc eydastrakanafni
@nafn varchar(75)
as
begin
declare @lower int
declare @lower1 int
declare @upper1 int
declare @nafn1 varchar(75)
declare @tidni int
declare @count int
declare @count1 int

declare strakar cursor
for
	select Nafn,tidni1,tidni2 from strakaFornofn

set @count = 0

if @nafn in (select nafn from strakaFornofn)
begin
select @lower = Tidni1 from strakaFornofn
where nafn = @nafn

delete from strakaFornofn
where nafn = @nafn

select @count1 = COUNT(nafn) from strakaFornofn

open strakar
fetch next from strakar into @nafn1, @lower1, @upper1
while @count < @count1
begin
	
	if @lower < @lower1
	begin
	update strakaFornofn
	set Tidni1 = @lower
	where nafn = @nafn1
	
	set @tidni = @upper1 - @lower1 - 1
	set @tidni = @tidni + @lower
	
	update strakaFornofn
	set Tidni2 = @tidni
	where nafn = @nafn1
	
	set @lower = @tidni + 1
	end
	set @count = @count + 1
	fetch next from strakar into @nafn1, @lower1, @upper1
end

close strakar
end

else
begin
print 'Nafn er ekki til'
end

deallocate strakar
end

--Ey�ir stelpunafni --select * from stelpurfornofn exec eydastelpunafni 'Margr�t'
go
create proc eydastelpunafni
@nafn varchar(75)
as
begin
declare @lower int
declare @lower1 int
declare @upper1 int
declare @nafn1 varchar(75)
declare @tidni int
declare @count int
declare @count1 int
declare stelpur cursor
for
	select nafn,tidni1,tidni2 from stelpurFornofn

set @count = 0

if @nafn in (select nafn from stelpurFornofn)
begin
select @lower = Tidni1 from stelpurFornofn
where nafn = @nafn

delete from stelpurFornofn
where nafn = @nafn

select @count1 = COUNT(nafn) from stelpurFornofn

open stelpur
fetch next from stelpur into @nafn1, @lower1, @upper1
while @count < @count1
begin
	
	if @lower < @lower1
	begin
	update stelpurFornofn
	set Tidni1 = @lower
	where nafn = @nafn1
	
	set @tidni = @upper1 - @lower1 - 1
	set @tidni = @tidni + @lower
	
	update stelpurFornofn
	set Tidni2 = @tidni
	where nafn = @nafn1
	
	set @lower = @tidni + 1
	end
	set @count = @count + 1
	fetch next from stelpur into @nafn1, @lower1, @upper1
end

close stelpur
end
else
begin
print 'Nafn er ekki til'
end

deallocate stelpur

end

--B�tir vi� str�kanafni
--exec baetavidstrakanafni 'asdf',5000,'asdff','asdfff'
go
create proc baetavidstrakanafni
@nafn varchar(75),
@tidni int,
@ef varchar(75),
@ef2 varchar(75)
as
begin
declare @lower int
declare @upper int
select @lower = MAX(tidni2) from strakaFornofn
set @lower = @lower + 1
set @upper = @lower + @tidni
insert into strakaFornofn values(@nafn, @lower, @upper, @ef, @ef2)
end

--B�tir vi� stelpunafni select * from stelpurfornofn
go
create proc baetavidstelpunafni
@nafn varchar(75),
@tidni int
as
begin
declare @lower int
declare @upper int
select @lower = MAX(tidni2) from stelpurFornofn
set @lower = @lower + 1
set @upper = @lower + @tidni
insert into stelpurFornofn values(@nafn, @lower, @upper)
end


--B�r til random, l�glega kennit�lu
go
create proc kennitala
@id int,
@nafn varchar(75),
@aldur1 int,
@aldur2 int
as
begin
	declare @string char(2)
	declare @counter int
	declare @days int
	declare @date datetime
	declare @yearTable table (monthName VARCHAR(20), numDays INT) --K��i sem �g fann � netinu (http://www32.brinkster.com/srisamp/sqlArticles/article_5.htm)
																  --gefur nafn � m�nu�i og hversu margir dagar eru � �eim m�nu�i.
	begin
		set nocount on
		set @counter = 1
		while (@counter < 13)
		begin
			set @date = CONVERT(DATETIME, STR(@counter) + '/01/2010')
			select @days = DAY(DATEADD (m, 1, DATEADD (d, 1 - DAY(@date), @date)) - 1) 

			INSERT INTO @yearTable VALUES (@counter, @days) -- skiptir �t @counter fyrir DATENAME (month, @date) til �ess a� f� nafni� � m�nu�inum
			set @counter = @counter + 1
		end
	end
	
	declare @random int
	declare @lower int
	declare @Upper int
	declare @kt varchar(75)
	declare @bit bit
	
	--f��ingar �r
		select @Lower = YEAR(GETDATE()) - @aldur2 --1930
		select @Upper = YEAR(GETDATE()) - @aldur1 --2010
		SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
		select @string = SUBSTRING(str(@random),9,len(str(@random)))
		set @kt = @string
		set @kt = REPLACE(@kt, ' ', '')
		
	---F� f��ingarm�nu�
		select @Lower = 1 ---- The lowest random number
		select @Upper = 12 ---- The highest random number
		SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
		if @random < 10
		begin
			set @string = STR(0)+STR(@Random) + @kt
			set @kt = STR(0)+STR(@Random) + @kt
		end
		else 
			set @kt = STR(@random) + @kt
	

	
		
	--f��ingardagur
		select @Lower = 1
		select @Upper = numdays from @yearTable where @random = monthName
		set @Upper = @Upper + 1
	
		if @Upper = 28 and @random % 4 = 0
		set @Upper = @Upper +1 -- Ef �a� er hlaup�r b�tist einn dagur vi� febr�ar
	
		SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
		if @random < 10
		begin
			set @kt = STR(0) + STR(@random) + @kt
		end
		else 
		begin
			set @kt = str(@random) + @kt
		end
		set @kt = REPLACE(@kt, ' ', '')

		
		--sj�undi og �ttundi stafurinn
		set @lower = 20
		set @Upper = 99
		SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
		set @kt = @kt + STR(@random)
		set @kt = REPLACE(@kt, ' ', '')
	
	
	
		--Varatalan -- http://www.fmr.is/pages/1109
		declare @teljari int
		declare @tala int
		declare @summa int
		declare @summa2 int
		declare @varatala int
		declare @byrjun int
		set @teljari = 1
		set @summa = 0
		set @byrjun = 1
		
		while @teljari < 9
		begin
			set @string = SUBSTRING(@kt,@byrjun,1)
			set @tala = cast(@string as INT)
	
			set @summa = case @teljari 
					when 1 then @summa + (@tala * 3)
					when 2 then @summa + (@tala * 2)
					when 3 then @summa + (@tala * 7)
					when 4 then @summa + (@tala * 6)
					when 5 then @summa + (@tala * 5)
					when 6 then @summa + (@tala * 4)
					when 7 then @summa + (@tala * 3)
					when 8 then @summa + (@tala * 2)
					end 
			set @byrjun = @byrjun + 1
			set @teljari = @teljari + 1
		end
	
		if @summa % 11 = 1
		begin
			set @summa = @summa +1
		end
	
		set @summa2 = @summa % 11
		set @varatala = 11 - @summa2
	
		if @varatala = 11
			set @varatala = 0
		
		set @kt = @kt + STR(@varatala)
		set @kt = REPLACE(@kt, ' ', '')
		
		if @nafn like '%son'
		begin
		set @kt = @kt + STR(1)
		end
		
		if @nafn like '%d�ttir'
		begin
		set @kt = @kt + STR(0)
		end
		
		set @kt = REPLACE(@kt, ' ', '')
		
		if @kt not in (select kt from nafnogkt)
		begin
		update nafnogkt 
		set kt = @kt 
		where @id = id
		end
end

--Declare-ar cursora
go
create proc declarecursor
as
begin
declare strakar cursor
for
	select * from strakaFornofn --setja cursor � ey�astr�k
	
declare stelpur cursor
for
	select * from stelpurFornofn
	
declare eydastrak cursor
for
	select nafn, tidni1, tidni2 from strakaFornofn
	
declare gotur cursor
for
	select id,postnumer, heiti_nefnifall from gotur
end

--Ey�ir n�fnum �r nafnogkt t�flunni og resettar ID
go
create proc eydaurnafnogkt
as
begin
delete from nafnogkt
dbcc checkident ('nafnogkt', RESEED, 0) -- resettar ID 
end


--Finnur stuff
go
create proc finnanafn
@nafn varchar(75)
as 
begin
select id, kt, nafn, heimilisfang, postnr from nafnogkt where nafn like '%'+@nafn+' %'
end
--
go
create proc finnakt
@kt char(10)
as
begin
select ID, kt, nafn, heimilisfang, postnr from nafnogkt where kt like '%'+@kt+'%'
end
--exec finnakt '0809606031' select * from nafnogkt
go
create proc finnaid
@id int
as
begin
select id, kt, nafn, heimilisfang, postnr from nafnogkt where id = @id
end
--
go
create proc finnaHeimilisfang
@hf varchar(75)
as
begin
select id, kt, nafn, heimilisfang, postnr from nafnogkt where heimilisfang like '%'+@hf+'%'
end
--
go
create proc finnaPostnr
@pn int
as
begin
select id, kt, nafn, heimilisfang, postnr from nafnogkt where postnr = @pn
end
--
go
create proc getNafnList
as
begin
	select id, kt, nafn, heimilisfang, postnr from nafnogkt
end
--
go
create proc faStrakaNofn
as
begin
	select Nafn,Tidni1, Tidni2, eignarfall, eignarfall2 from strakaFornofn
end
--
go
create proc faStelpuNofn
as
begin
	select Nafn,Tidni1, Tidni2 from stelpurFornofn
end
--
go
create proc getStrakaNafn
as
begin
	select strakafornofn.Nafn, strakafornofn.Tidni1, strakafornofn.Tidni2 from strakaFornofn
end
--
go
create proc getStelpuNafn
as
begin
	select stelpurFornofn.Nafn, stelpurFornofn.Tidni1, stelpurFornofn.Tidni2 from stelpurFornofn
end
-----------------
go
create proc breytaStraki
@nafn varchar(75),
@nyttnafn varchar(75),
@tidni int
as
begin
	declare @nafn1 varchar(75)
	declare @upper int
	declare @upper1 int
	declare @lower1 int
	declare @lower int
	declare @count int
	declare @count1 int
	declare @tidni1 int
	
	set @count = 0
	select @count1 = COUNT(nafn) from strakaFornofn

	declare strakar cursor
	for
	select Nafn,tidni1,tidni2 from strakaFornofn
	
	select @lower = tidni1 from strakaFornofn where nafn = @nafn
	
	update strakaFornofn
	set Tidni2 = @lower + @tidni
	where Nafn = @nafn
	
	update strakaFornofn
	set Nafn = @nyttnafn
	where Nafn = @nafn
	
	select @upper = Tidni2 from strakaFornofn where nafn = @nyttnafn
	
	open strakar
	fetch next from strakar into @nafn1, @lower1, @upper1
	while @count < @count1
	begin
	
	
	if @lower < @lower1
	begin
	
	update strakaFornofn
	set Tidni1 = @upper + 1
	where nafn = @nafn1
	
	set @tidni1 = @upper1 - @lower1
	select @lower1 = tidni1 from strakaFornofn where strakaFornofn.Nafn = @nafn1
	
	update strakaFornofn
	set Tidni2 = @lower1 + @tidni1
	where nafn = @nafn1
	
	select @upper = Tidni2 from strakaFornofn where nafn = @nafn1
	
	end
	
	set @count = @count + 1
	fetch next from strakar into @nafn1, @lower1, @upper1
	end

	close strakar


	deallocate strakar
end
--
go
create proc breytaStelpu
@nafn varchar(75),
@nyttnafn varchar(75),
@tidni int
as
begin
	declare @nafn1 varchar(75)
	declare @upper int
	declare @upper1 int
	declare @lower1 int
	declare @lower int
	declare @count int
	declare @count1 int
	declare @tidni1 int
	
	set @count = 0
	select @count1 = COUNT(nafn) from stelpurFornofn

	declare stelpur cursor
	for
	select Nafn,tidni1,tidni2 from stelpurFornofn
	
	select @lower = tidni1 from stelpurFornofn where nafn = @nafn
	
	update stelpurFornofn
	set Tidni2 = @lower + @tidni
	where Nafn = @nafn
	
	update stelpurFornofn
	set Nafn = @nyttnafn
	where Nafn = @nafn
	
	select @upper = Tidni2 from stelpurFornofn where nafn = @nafn
	
	open stelpur
	fetch next from stelpur into @nafn1, @lower1, @upper1
	while @count < @count1
	begin
	
	
	if @upper < @upper1
	begin
	
	update stelpurFornofn
	set Tidni1 = @upper + 1
	where nafn = @nafn1
	
	set @tidni1 = @upper1 - @lower1
	
	update stelpurFornofn
	set Tidni2 = @lower1 + @tidni1
	where nafn = @nafn1
	
	select @upper = Tidni2 from stelpurFornofn where nafn = @nafn1
	
	end
	
	set @count = @count + 1
	fetch next from strakar into @nafn1, @lower1, @upper1
	end

	close stelpur


	deallocate stelpur
end
----
go
create proc eydastrakanafni
@nafn varchar(75)
as
begin
declare @lower int
declare @lower1 int
declare @upper1 int
declare @nafn1 varchar(75)
declare @tidni int
declare @count int
declare @count1 int

declare strakar cursor
for
	select Nafn,tidni1,tidni2 from strakaFornofn

set @count = 0

if @nafn in (select nafn from strakaFornofn)
begin
select @lower = Tidni1 from strakaFornofn
where nafn = @nafn

delete from strakaFornofn
where nafn = @nafn

select @count1 = COUNT(nafn) from strakaFornofn

open strakar
fetch next from strakar into @nafn1, @lower1, @upper1
while @count < @count1
begin
	
	if @lower < @lower1
	begin
	update strakaFornofn
	set Tidni1 = @lower
	where nafn = @nafn1
	
	set @tidni = @upper1 - @lower1 - 1
	set @tidni = @tidni + @lower
	
	update strakaFornofn
	set Tidni2 = @tidni
	where nafn = @nafn1
	
	set @lower = @tidni + 1
	end
	set @count = @count + 1
	fetch next from strakar into @nafn1, @lower1, @upper1
end

close strakar
end

else
begin
print 'Nafn er ekki til'
end

deallocate strakar
end
--
go
create proc faStrak
@strakur varchar(75)
as
begin
	declare @tidni int
	set @tidni = (select tidni2 from strakaFornofn where nafn = @strakur) - (select tidni1 from strakaFornofn where nafn = @strakur)
	select nafn, @tidni as t��ni from strakaFornofn where nafn = @strakur
end
--
go
create proc faStelpu
@stelpa varchar(75)
as
begin
	declare @tidni int
	set @tidni = (select tidni2 from stelpurFornofn where nafn = @stelpa) - (select tidni1 from stelpurFornofn where nafn = @stelpa)
	select nafn, @tidni as t��ni from stelpurFornofn where nafn = @stelpa
end
--