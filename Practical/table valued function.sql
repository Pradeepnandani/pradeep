CREATE FUNCTION udfProductInYear (
 @model_year INT
)
RETURNS TABLE
AS
RETURN
 SELECT
 product_name,
 model_year,
 list_price
 FROM
 production
 WHERE
 model_year = @model_year; create table production( id int primary key not null identity, product_name varchar(max), model_year int ,list_price numeric(18,2));insert into productionvalues('sugar',2017,2400),('rice',2017,2400),('dal',2017,24500),('grapes',2016,24500),('panner',2018,2400);select * from productionSELECT
 *
FROM
 udfProductInYear(2017); SELECT
 *
FROM
 udfProductInYear(2016);