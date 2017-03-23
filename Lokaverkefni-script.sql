	--============================================================================================================
--											      DROP TABLE
--============================================================================================================
if exists (select * from sys.objects where object_id = OBJECT_ID(N'strakaFornofn') AND type in (N'U')) drop table strakaFornofn
if exists (select * from sys.objects where object_id = OBJECT_ID(N'stelpurFornofn') AND type in (N'U')) drop table stelpurFornofn
if exists (select * from sys.objects where object_id = OBJECT_ID(N'nafnogkt') AND type in (N'U')) drop table nafnogkt
if exists (select * from sys.objects where object_id = OBJECT_ID(N'gotur') AND type in (N'U')) drop table gotur
--============================================================================================================
--											      CREATE TABLE
--============================================================================================================
create table strakaFornofn
(
Nafn varchar(75) unique,
Tidni1 int,
Tidni2 int,
eignarfall varchar(75),
eignarfall2 varchar(75)
)

create table stelpurFornofn
(
Nafn varchar(75) unique,
Tidni1 int,
Tidni2 int
)


create table nafnogkt
(
id int identity(1,1) primary key,
kt char(10),
nafn varchar(75),
heimilisfang varchar(75),
postnr int
)

create table gotur --Gögnin sem fara í þessa töflu eru í textaskrá
(
	id int identity(1,1) primary key,
	postnumer int,
	heiti_nefnifall varchar(75),
	heiti_thagufall varchar(75)
)