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
 model_year = @model_year;
 *
FROM
 udfProductInYear(2017);
 *
FROM
 udfProductInYear(2016);